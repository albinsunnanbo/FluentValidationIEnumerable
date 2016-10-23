using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FluentValidation_Issue_349_IEnumerableModels.Models;

namespace FluentValidation_Issue_349_IEnumerableModels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SingleModel()
        {
            var model = new MyModel
            {
                MyProperty = "Hello",
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult SingleModel(MyModel model)
        {
            return View(model);
        }

        public IActionResult IEnumerableModel()
        {
            var model = new List<MyModel>
            {
                new MyModel
                {
                    MyProperty = "Hello",
                },
                new MyModel
                {
                    MyProperty = "World",
                },
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult IEnumerableModel(IEnumerable<MyModel> model)
        {
            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
