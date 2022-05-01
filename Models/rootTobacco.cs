using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TobaccoProject.Models
{
    public class rootTobacco
    {
        public List<Tobacco> Property1 { get; set; }
    }

    public class Tobacco
    {
        public string year { get; set; }
        public string locationabbrev { get; set; }
        public string locationdesc { get; set; }
        public string population { get; set; }
        public string topic { get; set; }
        public string measure { get; set; }
        public string submeasure { get; set; }
        public string data_value_unit { get; set; }
        public string domestic { get; set; }
        public string imports { get; set; }
        public string total { get; set; }
        public string domestic_per_capita { get; set; }
        public string imports_per_capita { get; set; }
        public string total_per_capita { get; set; }
    }

}