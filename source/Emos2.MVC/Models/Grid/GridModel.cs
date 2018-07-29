using Emos2.MVC.Models.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;

namespace Emos2.MVC.Models.Grid
{
    public class GridModel<T> : BaseGridModel
    {
        public GridModel(IQueryable<T> rows, int selectedPage, string gridID, string refreshJavascriptFunctionName) : base(gridID, refreshJavascriptFunctionName)
        {
            this.PaginationModel = new GridPaginationModel(rows.Count(), selectedPage, gridID, refreshJavascriptFunctionName);
            this.Rows = this.ExecutePagination(rows);
        }

        public GridModel(IQueryable<T> rows, int selectedPage, int itemsPerPage, string gridID, string refreshJavascriptFunctionName) : base(gridID, refreshJavascriptFunctionName)
        {
            this.PaginationModel = new GridPaginationModel(rows.Count(), selectedPage, itemsPerPage, gridID, refreshJavascriptFunctionName);
            this.Rows = this.ExecutePagination(rows);
        }

        public GridModel(IQueryable<T> rows, GridStateModel gridState, FilterModel filterModel, string gridID, string refreshJavascriptFunctionName) : base(gridID, refreshJavascriptFunctionName)
        {
            this.FilterModel = filterModel;
            rows = this.ExecuteFiltersOnRows(rows);
            rows = this.ExecuteSorting(rows, gridState);

            this.PaginationModel = new GridPaginationModel(rows.Count(), gridState.SelectedPage, gridState.ItemsPerPage, gridID, refreshJavascriptFunctionName);
            this.Rows = this.ExecutePagination(rows);
        }


        public GridPaginationModel PaginationModel { get; private set; }
        public FilterModel FilterModel { get; private set; }
        public IQueryable<T> Rows { get; private set; }
        public bool Redirect { get; set; } = false;
        public IEnumerable<T> DataSource { get; set; }
		public int ParentEntityId { get; set; }
        public string StringParentEntityId { get; set; }

		private IQueryable<T> ExecuteFiltersOnRows(IQueryable<T> rows)
        {
            // Rows filtering
            bool isThereAnyFilterWithSetValue = this.FilterModel.Filters.Any(f => f.Value.PropertyState.PropertyValue != null && f.Value.PropertyState.FilterValue != FilterValue.Undefined);
            if (!isThereAnyFilterWithSetValue) return rows;

            // If the source type is Interface which inherits other Interfaces, filtering by the properties from inherited interfaces must be done
            // in the Interface type to which they belong. Because the filtering is done with the 'Expressions', filters needs to be divide by the
            // types, filtered by the types, and then Union the filter results
            Dictionary<Type, IEnumerable<FilterPropertyModel>> filters = this.GetFiltersByTheProperExpressionType();

            IQueryable<T> resultRows = null;

            foreach (var filter in filters)
            {
                IQueryable<T> filteredRows = this.FilterRows(filter.Key, filter.Value, rows);

                if (resultRows == null) resultRows = filteredRows;
                else resultRows = resultRows.Intersect(filteredRows);
            }


            return resultRows;
        }

        private IQueryable<T> ExecutePagination(IQueryable<T> rows)
        {
            // Rows pagination
            int skipRows = (this.PaginationModel.SelectedPage - 1) * this.PaginationModel.ItemsPerPage;
            int itemsPerPage = this.PaginationModel.ItemsPerPage;

            return rows.Skip(skipRows).Take(itemsPerPage);
        }

        private IQueryable<T> ExecuteSorting(IQueryable<T> rows, GridStateModel gridState)
        {
            if (gridState.FilterState == null) return rows;

            SortingDirection sortingDirection = gridState.FilterState.SortingDirection;
            string sortingColumn = gridState.FilterState.SortingColumn;
            Type sortingColumnType = gridState.FilterState.SortingPropertyType;

            if (string.IsNullOrWhiteSpace(sortingColumn) || sortingDirection == SortingDirection.Undefined) return rows;

            // If the source type is Interface, which inherits another Interface, and the property belongs to this base Interface,
            // 'Expression' will throw an error. Then, sorting needs to be done by this base Interface type.
            Type sortingType = this.GetExpressionType(sortingColumn);

            // If the source type is Interface, and if the property, by which sorting is executing, is not declared on the source type,
            // but on the Interfaces that this source Interface inherits, than the sorting must be done in the Interface which declares
            // the property by which sorting is executing
            object sortingRows = this.CastSourceRowsToTheProperExpressionType(sortingType, rows);

            ParameterExpression sortingParameter = Expression.Parameter(sortingType, "p");
            Expression parameterExpression = Expression.PropertyOrField(sortingParameter, sortingColumn);
            LambdaExpression sortingExpression = Expression.Lambda(parameterExpression, new[] { sortingParameter });
            string sortingMethodName = string.Empty;

            switch (sortingDirection)
            {
                case SortingDirection.Ascending:
                    sortingMethodName = "OrderBy";
                    break;

                case SortingDirection.Descending:
                    sortingMethodName = "OrderByDescending";
                    break;
            }

            MethodInfo sortingMethod = typeof(Queryable).GetMethods().Where(m => m.Name.Equals(sortingMethodName)).Where(m => m.GetParameters().Length == 2).Single();
            MethodInfo genericSortingMethod = sortingMethod.MakeGenericMethod(new[] { sortingType, parameterExpression.Type });

            object sortedRows = genericSortingMethod.Invoke(null, new object[] { rows, sortingExpression });

            return this.CastRowsToTheSourceType(sortingType, sortedRows);
        }

        private Type GetExpressionType(string propertyColumn)
        {
            Type type = typeof(T);

            if (type.IsInterface && !type.GetProperties().Any(p => p.Name.Equals(propertyColumn)))
            {
                IEnumerable<PropertyInfo> properties = (new[] { type }).Concat(type.GetInterfaces()).SelectMany(i => i.GetProperties());

                type = properties.First(p => p.Name.Equals(propertyColumn)).DeclaringType;
            }

            return type;
        }

        private object CastSourceRowsToTheProperExpressionType(Type sortingType, IQueryable<T> sourceRows)
        {
            if (sortingType == typeof(T)) return sourceRows;

            MethodInfo castingMethod = typeof(Queryable).GetMethod("Cast");
            MethodInfo castingMethodGeneric = castingMethod.MakeGenericMethod(sortingType);

            return castingMethodGeneric.Invoke(null, new object[] { sourceRows });
        }

        private IQueryable<T> CastRowsToTheSourceType(Type rowsType, object rows)
        {
            if (rowsType == typeof(T)) return (IQueryable<T>)rows;

            MethodInfo castingMethod = typeof(Queryable).GetMethod("Cast");
            MethodInfo castingMethodGeneric = castingMethod.MakeGenericMethod(typeof(T));

            return (IQueryable<T>)castingMethodGeneric.Invoke(null, new object[] { rows });
        }

        /// <summary>
        /// Dividing the property filters by the type where they are declared in the source type. For example, 'ISubmissionData' inherits the 'ISubmissionBase',
        /// this means that the result will have two rows, one where there are filter properties that are declared on the 'ISubmissionData', and the other row 
        /// where there are properties that are declared on the 'ISubmissionBase'
        /// </summary>
        private Dictionary<Type, IEnumerable<FilterPropertyModel>> GetFiltersByTheProperExpressionType()
        {
            Dictionary<Type, IEnumerable<FilterPropertyModel>> propertyFilters = new Dictionary<Type, IEnumerable<FilterPropertyModel>>();
            IEnumerable<KeyValuePair<string, FilterBaseModel>> filters = this.FilterModel.Filters.Where(f => f.Value.PropertyState.PropertyValue != null && f.Value.PropertyState.FilterValue != FilterValue.Undefined);

            foreach (var filter in filters)
            {
                Type expressionType = this.GetExpressionType(filter.Value.ColumnName);

                if (propertyFilters.Keys.Any(k => k == expressionType))
                {
                    List<FilterPropertyModel> properties = propertyFilters[expressionType] as List<FilterPropertyModel>;

                    properties.Add(filter.Value.PropertyState);
                }
                else
                {
                    propertyFilters.Add(expressionType, new List<FilterPropertyModel>() { filter.Value.PropertyState });
                }
            }

            return propertyFilters;
        }

        public IQueryable<T> FilterRows(Type expressionType, IEnumerable<FilterPropertyModel> filters, IQueryable<T> sourceRows)
        {
            object rows = this.CastSourceRowsToTheProperExpressionType(expressionType, sourceRows);

            // Setting the Paramater upon which filtering will be executed. Parameter type is the same as the Type of the DataSource
            ParameterExpression filterParameter = Expression.Parameter(expressionType, "p");
            Expression filterExpression = null;

            // Generating Where clause
            foreach (var propertyState in filters)
            {
                // If the property value is set to NULL, this means that this property is not used for the filtering
                if (propertyState.PropertyValue == null || propertyState.FilterValue == FilterValue.Undefined) continue;

                Expression propertyFilterExpression;
                Expression propertyExpression = Expression.PropertyOrField(filterParameter, propertyState.PropertyName);
                Expression filterValueExpression = Expression.Constant(propertyState.PropertyValue, propertyExpression.Type);
                switch (propertyState.FilterValue)
                {
                    case FilterValue.IsEqualTo:
                        //var parameterExp = Expression.Parameter(expressionType, "p");
                        //var propertyExp = Expression.Property(parameterExp, "CurrentStateId");
                        //MethodInfo method = typeof(List<int>).GetMethod("Contains");
                        //var someValue = Expression.Constant(new List<int>() { 40, 55 }, typeof(List<int>));
                        //var containsMethodExp = Expression.Call(someValue, method, propertyExp);

                        //propertyFilterExpression = Expression.Lambda<Func<T, bool>>(containsMethodExp, parameterExp);
                        //propertyFilterExpression = Expression.Lambda(containsMethodExp, parameterExp);
                        propertyFilterExpression = Expression.Equal(propertyExpression, filterValueExpression);

                        break;

                    case FilterValue.Contains:
                        Expression notNullExpression = Expression.NotEqual(propertyExpression, Expression.Constant(null));
                        Expression containsExpression = Expression.Call(propertyExpression, typeof(string).GetMethod("Contains"), filterValueExpression);

                        // Only if Expression 'notNullExpression' is true, Expression 'containsExpression' will be processed
                        propertyFilterExpression = Expression.AndAlso(notNullExpression, containsExpression);
                        break;

                    default:
                        continue;
                }

                if (filterExpression == null) filterExpression = propertyFilterExpression;
                else filterExpression = Expression.And(filterExpression, propertyFilterExpression);
            }

            MethodInfo whereMethod = typeof(Queryable).GetMethods().First(m => m.Name.Equals("Where"));
            MethodInfo whereMethodGeneric = whereMethod.MakeGenericMethod(expressionType);

            if (filterExpression == null)
            {
                filterExpression = Expression.Empty();
            }

            var whereClause = Expression.Lambda(filterExpression, filterParameter);


            object filteredRows = whereMethodGeneric.Invoke(null, new object[] { rows, whereClause });

            return this.CastRowsToTheSourceType(expressionType, filteredRows);

        }

    }
}