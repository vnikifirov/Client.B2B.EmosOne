using AutoMapper;
using Emos2.Infrastructure;
using Emos2.Infrastructure.Entities;
using Emos2.Infrastructure.Entities.Database;
using Emos2.Infrastructure.Entities.Users;
using Emos2.Infrastructure.Repositories;
using Emos2.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Emos2.Services
{
    public abstract class ServiceBaseESR<TEntity> : IServiceBaseESR<TEntity> where TEntity : class, IEntity
    {
        protected readonly IRepositoryESR<TEntity> baseRepository;
        protected readonly IMapper mapper;

      ///  private  IClientService emos1ClientService;

        public ServiceBaseESR(IRepositoryESR<TEntity> repository)
        {
            this.baseRepository = repository;
            this.mapper = this.GenerateMapper();
        }

        public void SetClientConnectionString(string connectionString)
        { 
            baseRepository.SetContextConnectionString(connectionString);
        }

        #region Private, protected methods

        private IMapper GenerateMapper()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg => {

                cfg.CreateMap<UserCreateData, UserData>();
                cfg.CreateMap<UserUpdateData, UserData>();
            });

            return mapperConfiguration.CreateMapper();
        }

        #endregion

        #region IServiceBase<IEntity> implementations

        public void Delete(int id)
        {
            TEntity entity = this.baseRepository.Select(id);

            this.Delete(entity);
        }

        public void Delete(TEntity entity)
        {
            this.baseRepository.Delete(entity);
            this.baseRepository.SaveChanges();
        }

        public bool Exists(int id)
        {
            return this.Select(id) != null;
        }

        public void Save(TEntity entity)
        {
            if (this.baseRepository.Exists(entity))
            {
                this.baseRepository.Update(entity);
            }
            else
            {
                this.baseRepository.Insert(entity);
            }

            this.baseRepository.SaveChanges();
        }

        public TEntity Select(int id)
        {
            return this.baseRepository.Select(id);
        }

        public IQueryable<TEntity> SelectAll()
        {
            return this.baseRepository.SelectAll();
        }

        public IQueryable<TEntity> SelectAllBy(Expression<Func<TEntity, bool>> predicate)
        {
            return this.baseRepository.SelectBy(predicate);
        }

        public PaginationList<TEntity> SelectAllByPagination<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> keySelector, Expression<Func<TEntity, bool>> predicate)
        {
            return this.baseRepository.SelectByPaginated<TKey>(pageIndex, pageSize, keySelector, predicate);
        }

        public PaginationList<TEntity> SelectAllPagination<TKey>(int pageIndex, int pageSize, Expression<Func<TEntity, TKey>> keySelector)
        {
            return this.baseRepository.SelectByPaginated<TKey>(pageIndex, pageSize, keySelector, null);
        }

        #endregion
    }
}
