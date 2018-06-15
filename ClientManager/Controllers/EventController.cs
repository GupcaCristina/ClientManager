using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ClientManager.BLL.Interfaces;
using ClientManager.Web.Models.ClientViewModels;
using ClientManager.Web.Models.Event;
using DomainUtil;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientManager.Web.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        private IEventServices _eventServices;
        private IMapper _mapper;
        public EventController(IEventServices clientServices, IMapper mapper)
        {
            _eventServices = clientServices;
            _mapper = mapper;
        }
        // GET: Client
        public ActionResult Index(int page, DateTime? addedDate)
        {
            var pageSize = 10;
            var events = _eventServices.GetPaginatedList(pageSize, addedDate, page);
            var clientsViewModel = _mapper.Map<PaginatedList<EventViewModel>>(events);
            clientsViewModel.PageIndex = events.PageIndex;
            clientsViewModel.TotalPages = events.TotalPages;

            return View(clientsViewModel);
        }

        // GET: Event/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Event/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Event/Edit/5
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

        // GET: Event/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Event/Delete/5
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