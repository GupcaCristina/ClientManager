using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ClientManager.BLL.Interfaces;
using ClientManager.DTO;
using ClientManager.Web.Models.ClientViewModels;
using DomainUtil;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientManager.Web.Controllers
{
    public class ClientController : Controller
    {
        private IClientServices _clientServices;
        private IMapper _mapper;
        public ClientController(IClientServices clientServices, IMapper mapper)
        {
            _clientServices = clientServices;
            _mapper = mapper;
        }
        // GET: Client
        public ActionResult Index(int page, DateTime? addedDate, string searchString)
        {
            var pageSize = 10;
            var clients = _clientServices.GetPaginatedList(pageSize, addedDate, searchString,page);
            var clientsViewModel = _mapper.Map<PaginatedList<ClientDetailsViewModel>>(clients);
            clientsViewModel.PageIndex = clients.PageIndex;
            clientsViewModel.TotalPages = clients.TotalPages;

            return View(clientsViewModel);
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateClientViewModel clientViewModel)
        {
            try
            {
                var client = _mapper.Map<CreateClientDTO>(clientViewModel);
                _clientServices.AddClient(client);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Client/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}