using System;

namespace Web.Models
{
    public class DProviderDomain: Dto
    {
        public Guid? IdDomain { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public DateTime From { get; set; }
        public DateTime? To { get; set; }
        public string UserName { get; set; }
    }
}