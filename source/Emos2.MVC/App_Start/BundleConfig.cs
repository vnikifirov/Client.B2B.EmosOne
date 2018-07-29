using System.Web;
using System.Web.Optimization;

namespace Emos2.MVC
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));


            //Leave path the same for dynamic path resolution
            bundles.Add(new ScriptBundle("~/Scripts/plugins-bundle").Include(
                        "~/Scripts/jquery-1.10.2.min.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/jquery-ui.js",
                        "~/Scripts/jquery-ui-timepicker-addon.js",
                        "~/Scripts/jquery.unobtrusive-ajax.min.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/jquery.loader.min.js",
                        "~/Scripts/bootstrap-multiselect.js"));


            bundles.Add(new ScriptBundle("~/Scripts/custom-bundle").IncludeDirectory("~/Scripts/Custom", "*.js", true));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css-bundle").Include(
                    "~/Content/main.css",
                    "~/Content/jquery.loader.min.css",
                    "~/Content/jquery-ui.css",
                    "~/Content/jquery-ui.theme.css",
                    "~/Content/jquery-ui-timepicker-addon.css",
                    "~/Content/bootstrap-multiselect.css"));

            BundleTable.EnableOptimizations = true;
            foreach (var bundle in bundles)
            {
                bundle.Transforms.Clear();
            }


        }
    }
}
