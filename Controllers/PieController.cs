using BethanyPieShop_2.Models;
using BethanyPieShop_2.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop_2.Controllers
{
    public class PieController : Controller
    {
        private IPieRepository _pieRepository;
        private ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository,ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository; 
        }
        public ViewResult List()
        {
            PieListViewModel pieListViewModel = new PieListViewModel();
            pieListViewModel.Pies = _pieRepository.AllPies;
            pieListViewModel.CurrentCategory = "Cheese Cake";
            return View(pieListViewModel);
        }
        public IActionResult Details(int id) {
           var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();
            else
            return View(pie);
        }
    
    }
}
