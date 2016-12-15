using System.Web;
using System.Web.Optimization;

namespace TdH_2
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jqwidgets").Include(
                        "~/Scripts/jqxcore.js",
                        "~/Scripts/jqxdata.js",
                        "~/Scripts/jqx-all.js",
                        "~/Scripts/jqxbutton.js",
                        "~/Scripts/jqxlistbox.js",
                        "~/Scripts/jqxmenu.js",
                        "~/Scripts/jqxscrollbar.js",
                        "~/Scripts/jqxgrid.js",
                        "~/Scripts/jqxdropdownlist.js",
                        "~/Scripts/jqxgrid.aggregates.js",
                        "~/Scripts/jqxgrid.columnsreorder.js",
                        "~/Scripts/jqxgrid.columnsresize.js",
                        "~/Scripts/jqxgrid.edit.js",
                        "~/Scripts/jqxgrid.export.js",
                        "~/Scripts/jqxgrid.filter.js",
                        "~/Scripts/jqxgrid.grouping.js",
                        "~/Scripts/jqxgrid.pager.js",
                        "~/Scripts/jqxgrid.selection.js",
                        "~/Scripts/jqxgrid.sort.js",
                        "~/Scripts/jqxgrid.storage.js"));

            bundles.Add(new ScriptBundle("~/bundles/toastr", "http://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js").Include("~/Scripts/toastr.js"));

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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/jqx.base.css",
                        "~/Content/jqx.arctic.css",
                        "~/Content/jqx.black.css",
                        "~/Content/jqx.bootstrap.css",
                        "~/Content/jqx.classic.css",
                        "~/Content/jqx.darkblue.css",
                        "~/Content/jqx.energyblue.css",
                        "~/Content/jqx.fresh.css",
                        "~/Content/jqx.highcontrast.css",
                        "~/Content/jqx.metro.css",
                        "~/Content/jqx.metrodark.css",
                        "~/Content/jqx.office.css",
                        "~/Content/jqx.orange.css",
                        "~/Content/jqx.shinyblack.css",
                        "~/Content/jqx.summer.css",
                        "~/Content/jqx.web.css",
                        "~/Content/jqx.ui-darkness.css",
                        "~/Content/jqx.ui-lightness.css",
                        "~/Content/jqx.ui-le-frog.css",
                        "~/Content/jqx.ui-overcast.css",
                        "~/Content/jqx.ui-redmond.css",
                        "~/Content/jqx.ui-smoothness.css",
                        "~/Content/jqx.ui-start.css",
                        "~/Content/jqx.ui-sunny.css",
                        "~/Content/bootstrap.css",
                        "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/content/toastr", "http://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css").Include("~/Content/toastr.css"));
        }
    }
}
