using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibeyTechnicalTest.Backend.Domain.Models
{
    public class UbigeoModel
    {
        public string UbigeoCode { get; set; }
        public string ProvinceCode { get; set; }
        public string RegionCode { get; set; }
        public string UbigeoDescription { get; set; }
        public UbigeoModel(string ubigeoCode, string provinceCode, string regionCode, string ubigeoDescription)
        {
            UbigeoCode = ubigeoCode;
            ProvinceCode = provinceCode;
            RegionCode = regionCode;
            UbigeoDescription = ubigeoDescription;
        }
    }
}
