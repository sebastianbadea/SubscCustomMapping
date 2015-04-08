using System.Collections.Generic;

namespace Web.Models
{
    public class DProvider : Dto
    {
        public DProvider()
        {
            ProvidersDomains = new List<DProviderDomain>();
        }
        public string Name { get; set; }
        public string Cui { get; set; }
        public List<DProviderDomain> ProvidersDomains { get; set; }
    }
}