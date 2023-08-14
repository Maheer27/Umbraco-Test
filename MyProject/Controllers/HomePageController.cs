using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using MyProject.models;
using System.Globalization;
using System.Xml.Linq;
using Umbraco.BLL;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Web.Website.Controllers;

namespace MyProject.Controllers
{
    public class HomePageController : RenderController
    {
        private readonly ILogger logger;
        private readonly UmbracoHelper umbracoHelper;

        public HomePageController(ILogger<HomePageController> logger,
            ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor, UmbracoHelper umbracoHelper) 
            : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
            this.umbracoHelper = umbracoHelper;
        }
        public CultureInfo CurrentCulture
        {
            get => Thread.CurrentThread.CurrentCulture;

            set => Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = value;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var culture = CurrentCulture.Name;
            var highlightNode = umbracoHelper.ContentSingleAtXPath("//homePage") as HomePage;
            var bodytext = highlightNode.GetProperty("bodytext").GetValue().ToString();

            HomeVIewModel homevm = new HomeVIewModel();
            homevm.bodyText = "test";
            homevm.pageTitle = "test Title";
            return View("~/Views/HomePage.cshtml", homevm);
        }
    }
}
