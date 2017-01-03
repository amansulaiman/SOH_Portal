using System.Web;
using System.Web.Optimization;

namespace Grading_SOH_Final_Rel
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Enable Bundle Optimation
            //BundleTable.EnableOptimizations = true;

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.1.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            bundles.Add(new StyleBundle("~/Bundles/css")
                .Include("~/Content/css/bootstrap.css")
                .Include("~/Content/css/select2.css")
                .Include("~/Content/css/datepicker3.css")
                .Include("~/Content/css/AdminLTE.css")
                .Include("~/Content/css/skins/skin-blue.css")
                .Include("~/Content/MyStyle.css"));

            bundles.Add(new ScriptBundle("~/Bundles/js")
                .Include("~/Content/js/plugins/bootstrap/bootstrap.js")
                .Include("~/Content/js/plugins/fastclick/fastclick.js")
                .Include("~/Content/js/plugins/slimscroll/jquery.slimscroll.js")
                .Include("~/Content/js/plugins/select2/select2.full.js")
                .Include("~/Content/js/plugins/moment/moment.js")
                .Include("~/Content/js/plugins/datepicker/bootstrap-datepicker.js")
                .Include("~/Content/js/plugins/icheck/icheck.js")
                .Include("~/Content/js/app.js")
                .Include("~/Content/js/init.js"));

            bundles.Add(new ScriptBundle("~/Bundles/ejgrid")
                .Include("~/Scripts/ej/ej.widget.grid.min.js")
                );

            bundles.Add(new ScriptBundle("~/Bundles/ejchart")
                .Include("~/Scripts/ej/ej.widget.chart.min.js")
                );

            bundles.Add(new StyleBundle("~/bundles/ejstyles")
                .Include("~/ejThemes/bootstrap-theme/ej.theme.min.css", "~/ejThemes/ej.widgets.core.bootstrap.min.css"));

            
            bundles.Add(new ScriptBundle("~/bundles/ejscripts").Include(
                           "~/Scripts/jsrender.min.js",
                           "~/Scripts/jquery.easing-1.3.min.js",
                            "~/Scripts/ej/ej.unobtrusive.min.js"));

        }
    }
}
