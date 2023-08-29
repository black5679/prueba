using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Domain.Models
{
    public class ProvinceModel
    {
        public string ProvinceCode { get; set; }
        public string RegionCode { get; set; }
        public string ProvinceDescription { get; set; }
        public ProvinceModel(string provinceCode, string regionCode, string provinceDescription)
        {
            ProvinceCode = provinceCode;
            RegionCode = regionCode;
            ProvinceDescription = provinceDescription;
        }
    }
}
