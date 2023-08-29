namespace LibeyTechnicalTest.Backend.Domain.Models
{
    public class RegionModel
    {
        public string RegionCode { get; set; }
        public string RegionDescription { get; set; }
        public RegionModel(string regionCode, string regionDescription)
        {
            RegionCode = regionCode;
            RegionDescription = regionDescription;
        }
    }
}
