using System.Web;
using System.Web.Optimization;

namespace Store
{
    public class BundleConfig
    {
        //Дополнительные сведения об объединении см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jsfw/jquery").Include(
                        "~/Scripts/jsfw/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jsfw/jqueryval").Include(
                        "~/Scripts/jsfw/jquery.validate*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // используйте средство сборки на сайте http://modernizr.com, чтобы выбрать только нужные тесты.
            bundles.Add(new ScriptBundle("~/bundles/jsfw/modernizr").Include(
                        "~/Scripts/jsfw/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/jsfw/bootstrap").Include(
                      "~/Scripts/jsfw/bootstrap.js",
                      "~/Scripts/jsfw/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/jsfw/knockout").Include(
                     "~/Scripts/jsfw/knockout-*"));

            bundles.Add(new ScriptBundle("~/bundles/plugins/snapsvg").Include(
                "~/Scripts/jsfw/snap.svg.js",
                "~/Scripts/plugins/snapsvg/svgicons-config.js",
                "~/Scripts/plugins/snapsvg/svgicons.js",
                "~/Scripts/plugins/snapsvg/svgicons-definition.js"));

            bundles.Add(new ScriptBundle("~/bundles/plugins/slimScroll").Include(
                    "~/Scripts/plugins/slimScroll/jquery.slimscroll.min.js"));

            bundles.Add(new StyleBundle("~/Content/css/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/site.css",
                      "~/Content/css/Main.css"));

            // Присвойте EnableOptimizations значение false для отладки. Дополнительные сведения
            // см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
