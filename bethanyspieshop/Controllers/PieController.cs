
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bethanyspieshop.Models;
using bethanyspieshop.ViewModels;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Logging;

namespace bethanyspieshop.Controllers
{
    public class PieController : Controller
    {


        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;


        public PieController(IPieRepository pieRepository,ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }
        public IActionResult List()
        {
            PieListViewModel pieListViewModel = new PieListViewModel();
            pieListViewModel.Pies = _pieRepository.Pies;
            pieListViewModel.CurrentCategory = "cheese cake";
            return View(pieListViewModel);
        }

        public IActionResult details(int id)
        {
            return View(_pieRepository.GetPieById(id));
        }
      
    }
}