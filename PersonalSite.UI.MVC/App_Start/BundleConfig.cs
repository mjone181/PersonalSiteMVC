﻿using System.Web;
using System.Web.Optimization;

namespace PersonalSite.UI.MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/Scripts/bootstrap.min.js",
                      "~/Content/Scripts/jquery.js"));

            bundles.Add(new StyleBundle("~/Content/assets/css").Include(
                      "~/Content/CSS/assets/css/bootstrap.css",
                      "~/Content/CSS/assets/css/animate.css",
                      "~/Content/CSS/assets/css/prettyPhoto.css",
                      "~/Content/CSS/assets/css/pe-icons.css",
                      "~/Content/CSS/assets/css/style.css",
                      "~/Content/CSS/assets/css/font-awesome.min.css"));
        }
    }
}
