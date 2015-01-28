using System.Web;
using System.Web.Optimization;

namespace Store
{
    public class BundleConfig
    {
        //Дополнительные сведения об объединении см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {           
            #region Frameworks scripts

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jsfw/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jsfw/jquery.validate*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // используйте средство сборки на сайте http://modernizr.com, чтобы выбрать только нужные тесты.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/jsfw/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/jsfw/bootstrap.js",
                      "~/Scripts/jsfw/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                     "~/Scripts/jsfw/knockout-*"));

            bundles.Add(new ScriptBundle("~/bundles/snapsvg").Include(
                "~/Scripts/jsfw/snap.svg.js",
                "~/Scripts/plugins/snapsvg/svgicons-config.js",
                "~/Scripts/plugins/snapsvg/svgicons.js",
                "~/Scripts/plugins/snapsvg/svgicons-definition.js"));

            bundles.Add(new ScriptBundle("~/bundles/slimScroll").Include(
                    "~/Scripts/plugins/slimScroll/jquery.slimscroll.min.js"));

            #endregion Frameworks scripts

            #region Custom scripts

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/app/AppViewModel.js"));

            #endregion Custom scripts

            #region CSS

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/site.css",
                      "~/Content/css/Main.css"));

            #endregion CSS

            // Присвойте EnableOptimizations значение false для отладки. Дополнительные сведения
            // см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
