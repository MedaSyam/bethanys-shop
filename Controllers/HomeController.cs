using BethanyPieShop_2.Models;
using BethanyPieShop_2.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop_2.Controllers
{
    public class HomeController : Controller
    {
        private IPieRepository _pieRepository;
        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;

        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };
                 
            return View(homeViewModel);
        }
    }
}
