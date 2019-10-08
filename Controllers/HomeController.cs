using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dojodachi.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("dojodachi")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetObjectFromJson<Dachi>("dachi") == null)
            {
                Dachi dachi = new Dachi();
                HttpContext.Session.SetObjectAsJson("dachi", dachi);
                ViewBag.Fullness = HttpContext.Session.GetObjectFromJson<Dachi>("dachi").Fullness;
                ViewBag.Happiness = HttpContext.Session.GetObjectFromJson<Dachi>("dachi").Happiness;
                ViewBag.Meals = HttpContext.Session.GetObjectFromJson<Dachi>("dachi").Meals;
                ViewBag.Energy = HttpContext.Session.GetObjectFromJson<Dachi>("dachi").Energy;
                ViewBag.Message = HttpContext.Session.GetObjectFromJson<Dachi>("dachi").Message;
            }
            else if(HttpContext.Session.GetObjectFromJson<Dachi>("dachi").Energy >= 100 && HttpContext.Session.GetObjectFromJson<Dachi>("dachi").Fullness >= 100 && HttpContext.Session.GetObjectFromJson<Dachi>("dachi").Happiness >= 100)
            {
                return RedirectToAction("win");
            }
            else if(HttpContext.Session.GetObjectFromJson<Dachi>("dachi").Fullness <= 0 || HttpContext.Session.GetObjectFromJson<Dachi>("dachi").Happiness <= 0)
            {
                return RedirectToAction("lose");
            }
            else
            {
                ViewBag.Fullness = HttpContext.Session.GetObjectFromJson<Dachi>("dachi").Fullness;
                ViewBag.Happiness = HttpContext.Session.GetObjectFromJson<Dachi>("dachi").Happiness;
                ViewBag.Meals = HttpContext.Session.GetObjectFromJson<Dachi>("dachi").Meals;
                ViewBag.Energy = HttpContext.Session.GetObjectFromJson<Dachi>("dachi").Energy;
                ViewBag.Message = HttpContext.Session.GetObjectFromJson<Dachi>("dachi").Message;
            }
            return View("index");
        }

        [HttpGet("feed")]
        public IActionResult Feed()
        {
            Dachi dachi = HttpContext.Session.GetObjectFromJson<Dachi>("dachi");
            dachi.Feed();
            HttpContext.Session.SetObjectAsJson("dachi", dachi);
            return RedirectToAction("index");
        }

        [HttpGet("play")]
        public IActionResult Play()
        {
            Dachi dachi = HttpContext.Session.GetObjectFromJson<Dachi>("dachi");
            dachi.Play();
            HttpContext.Session.SetObjectAsJson("dachi", dachi);
            return RedirectToAction("index");
        }

        [HttpGet("work")]
        public IActionResult Work()
        {
            Dachi dachi = HttpContext.Session.GetObjectFromJson<Dachi>("dachi");
            dachi.Work();
            HttpContext.Session.SetObjectAsJson("dachi", dachi);
            return RedirectToAction("index");
        }

        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            Dachi dachi = HttpContext.Session.GetObjectFromJson<Dachi>("dachi");
            dachi.Sleep();
            HttpContext.Session.SetObjectAsJson("dachi", dachi);
            return RedirectToAction("index");
        }

        [HttpGet("win")]
        public IActionResult Win()
        {
            return View("win");
        }

        [HttpGet("lose")]
        public IActionResult Lose()
        {
            return View("lose");
        }

        [HttpGet("restart")]
        public IActionResult Restart()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            string value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
