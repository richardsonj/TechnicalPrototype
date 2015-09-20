using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Technical_Prototype.Models;

namespace Technical_Prototype.Controllers
{
    public class DataAPIController : Controller
    {
        private DataDBContext db = new DataDBContext();
        //
        // GET: /DataAPI/
        public string Index()
        {
            return "default view";
        }

        //
        // GET: /DataAPI/GetDataPoints/
        public string GetDataPoints()
        {
            List<DataModel> datapoints = db.Data.ToList();
            string jsonData = JsonConvert.SerializeObject(datapoints);
            return jsonData;
        }
	}
}