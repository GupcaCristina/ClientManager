//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using AutoMapper;
//using LearningPortal.BLL.Interfaces;
//using LearningPortal.Web.Models.UserViewModels;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace LearningPortal.Web.Controllers
//{
//    public class UserController : Controller
//    {
//        private readonly IUserServices _userServices;
//        private IMapper _mapper;
//        public UserController(IUserServices userServices, IMapper mapper)
//        {
//            _userServices = userServices;
//            _mapper = mapper;
//        }

//        // GET: User
//        //public ActionResult Index()
//        //{
//        //    return View();
//        //}

//        // GET: User/Details/5
//        public ActionResult Details(string id= "e7135b9e-5057-4484-803f-620447ebb885")
//        {
//            var userDto= _userServices.GetUserDetails(id);
//            var user = _mapper.Map<UserDetailsViewModel>(userDto);

//            return View(user);
//        }

////        // GET: User/Create
////        public ActionResult Create()
////        {
////            return View();
////        }

////        // POST: User/Create
////        [HttpPost]
////        [ValidateAntiForgeryToken]
////        public ActionResult Create(IFormCollection collection)
////        {
////            try
////            {
////                // TODO: Add insert logic here

////                return RedirectToAction(nameof(Index));
////            }
////            catch
////            {
////                return View();
////            }
////        }

////        // GET: User/Edit/5
////        public ActionResult Edit(int id)
////        {
////            return View();
////        }

////        // POST: User/Edit/5
////        [HttpPost]
////        [ValidateAntiForgeryToken]
////        public ActionResult Edit(int id, IFormCollection collection)
////        {
////            try
////            {
////                // TODO: Add update logic here

////                return RedirectToAction(nameof(Index));
////            }
////            catch
////            {
////                return View();
////            }
////        }

////        // GET: User/Delete/5
////        public ActionResult Delete(int id)
////        {
////            return View();
////        }

////        // POST: User/Delete/5
////        [HttpPost]
////        [ValidateAntiForgeryToken]
////        public ActionResult Delete(int id, IFormCollection collection)
////        {
////            try
////            {
////                // TODO: Add delete logic here

////                return RedirectToAction(nameof(Index));
////            }
////            catch
////            {
////                return View();
////            }
////        }
//    }
//}