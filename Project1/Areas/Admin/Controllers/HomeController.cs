using Microsoft.AspNetCore.Mvc;
using Project1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        
         
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.ServiceItems.GetServiceItems());
        }
    
    }
}
