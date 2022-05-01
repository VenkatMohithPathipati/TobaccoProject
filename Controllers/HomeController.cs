using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using TobaccoProject.Models;

namespace TobaccoProject.Controllers
{
    public class HomeController : Controller
    {
        HttpClient httpClient;



        static string BASE_URL = "https://chronicdata.cdc.gov/resource/";
        static string API_KEY = "6iceb3x0nyb6rswyvv31pvg89";
        public ActionResult Index()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string Tobacco_API_PATH = BASE_URL + "rnvb-cpxx.json";
            string tobaccoData = "";

            rootTobacco rootTob = new rootTobacco();

            httpClient.BaseAddress = new Uri(Tobacco_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(Tobacco_API_PATH)
                .GetAwaiter().GetResult();
                //HttpResponseMessage response = httpClient.GetAsync(BASE_URL)
                // .GetAwaiter().GetResult();





                if (response.IsSuccessStatusCode)
                {
                    tobaccoData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }



                if ((!tobaccoData.Equals("")))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    rootTob.Property1 = JsonConvert.DeserializeObject<List<TobaccoProject.Models.Tobacco>>(tobaccoData);
                }




                //dbContext.Parks.Add(parks);
                //await dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }
            return View(rootTob);
        }

        public ActionResult Aboutus()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Tobaccoprotables()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string Tobacco_API_PATH = BASE_URL + "rnvb-cpxx.json";
            string tobaccoData = "";

            rootTobacco rootTob = null;

            httpClient.BaseAddress = new Uri(Tobacco_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(Tobacco_API_PATH)
                .GetAwaiter().GetResult();
                //HttpResponseMessage response = httpClient.GetAsync(BASE_URL)
                // .GetAwaiter().GetResult();





                if (response.IsSuccessStatusCode)
                {
                    tobaccoData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }



                if ((!tobaccoData.Equals("")))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    rootTob = JsonConvert.DeserializeObject<rootTobacco>(tobaccoData);
                }




                //dbContext.Parks.Add(parks);
                //await dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }
            return View(rootTob);
        }

        public ActionResult TobaccoProducts()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Tobproandhealth()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            string Tobacco_API_PATH = BASE_URL + "rnvb-cpxx.json";
            string tobaccoData = "";

            rootTobacco rootTob = null;

            httpClient.BaseAddress = new Uri(Tobacco_API_PATH);

            try
            {
                HttpResponseMessage response = httpClient.GetAsync(Tobacco_API_PATH)
                .GetAwaiter().GetResult();
                //HttpResponseMessage response = httpClient.GetAsync(BASE_URL)
                // .GetAwaiter().GetResult();





                if (response.IsSuccessStatusCode)
                {
                    tobaccoData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }



                if ((!tobaccoData.Equals("")))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    rootTob = JsonConvert.DeserializeObject<rootTobacco>(tobaccoData);
                }




                //dbContext.Parks.Add(parks);
                //await dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }
            return View(rootTob);
        }
    }
}




