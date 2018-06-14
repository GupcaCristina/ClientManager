using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ClientManager.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ClientManager.Models;
using ClientManager.Web.Models.ClientViewModels;

namespace ClientManager.Controllers
{
    public class HomeController : Controller
    {
        private IClientServices _clientServices;
        private IMapper _mapper;

        public HomeController(IClientServices clientServices, IMapper mapper)
        {
            _clientServices = clientServices;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var clients = _clientServices.GetClientsByBirthday();
            ViewData["clientsViewModel"] = _mapper.Map<List<ClientDetailsViewModel>>(clients);
           
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
