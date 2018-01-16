using MultiplePlatform.Common;
using MultiplePlatform.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultiplePlatform.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICapitalService _capitalService;
        private readonly ITest _itest;

        public HomeController(ICapitalService _capitalService, ITest _itest)
        {
            this._capitalService = _capitalService;
            this._itest = _itest;
        }
        // GET: Home
        public ActionResult Index()
        {
            //注释
        var sss=    _capitalService.TableNoTracking.ToList();
           var dasdsa= _itest.GetSomeThing();
            return View();
        }
    }
}