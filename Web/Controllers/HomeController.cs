using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult SubscribeFromMapping()
        {
            var provider = CreateProvider();
            return View(provider);
        }

        private DProvider CreateProvider()
        {
            var provider = new DProvider 
            {
                Id = Guid.NewGuid(),
                Name = "name",
                Cui = "cui",
                ProvidersDomains = new List<DProviderDomain> 
                {
                    new DProviderDomain{ Id = Guid.NewGuid(), Details = "domain details", From = DateTime.Now, IdDomain= Guid.NewGuid(), Name = "domain name"},
                    new DProviderDomain{ Id = Guid.NewGuid(), Details = "domain details", From = DateTime.Now, IdDomain= Guid.NewGuid(), Name = "domain name2"},
                    new DProviderDomain{ Id = Guid.NewGuid(), Details = "domain details", From = DateTime.Now, IdDomain= Guid.NewGuid(), Name = "domain name3"},
                    new DProviderDomain{ Id = Guid.NewGuid(), Details = "domain details", From = DateTime.Now, IdDomain= Guid.NewGuid(), Name = "domain name4"}
                }
            };

            return provider;
        }
    }
}