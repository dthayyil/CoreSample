using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiemensGamesa.Model.WeatherRanges;
using SiemensGamesa.Services.Contracts;

namespace SiemensGamesa.Web.Controllers
{
    public class WeatherRanges : Controller
    {
        private readonly IWeatherRangesServices WeatherRangesServices;

        public WeatherRanges(IWeatherRangesServices weatherRangesServices)
        {
            WeatherRangesServices = weatherRangesServices;
        }

        public ActionResult Index()
        {
            return View(WeatherRangesServices.Index());
        }
         
        public ActionResult Create()
        {
            return View();
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WeatherRangesViewModel model)
        {
            try
            {
                WeatherRangesServices.Create(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
 
        public ActionResult Edit(int id)
        {
            return View(WeatherRangesServices.Get(id));
        }

        // POST: WeatherRanges/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(WeatherRangesViewModel model)
        {
            try
            {
                WeatherRangesServices.Edit(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
         
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id )
        {
            try
            {
                WeatherRangesServices.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
