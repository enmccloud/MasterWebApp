using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomePageMcCloud.Models.Student;
using Microsoft.AspNetCore.Mvc;

namespace HomePageMcCloud.Controllers
{
    public class StudentController : Controller
    {
            public IActionResult Index()
            {
                var viewModel = new Student
                {

                };

                return View(viewModel);
            }

            public IActionResult StudentListView()
            {
                //I am adjusting the variables here to see the different levels of access from no access to admin.
                int id = 4;

                // Criteria for NO access.
                if (id <= 2)
                {
                    var viewModel = new StudentList
                    {
                        Title = "You do not have suffiecient access level to view this data.",
                        Students = new List<string> { }
                    };
                    return View(viewModel);
                }

                // Criteria for partial access.
                else if (id >= 2 && id <= 8)
                {
                var viewModel = new StudentList
                {
                    Title = "Student Registry",
                    Students = new List<string>
                    {
                        "Nikki McCloud", "Jon Campbell", "Rick Sanchez", "Morty Smith", "Summer Smith",
                    }
                    };
                    return View(viewModel);
                }

                // Criteria for Admin access.
                else
                {
                    var viewModel = new StudentList
                    {
                        Title = "Hello, Admin!",
                        Students = new List<string>
                    {
                        "Nikki McCloud - A-", "Jon Campbell - A+", "Rick Sanchez - A+", "Morty Smith - D", "Summer Smith - B-",
                    
                    }
                    };
                    return View(viewModel);
                }
            }

            [HttpPost]
            public IActionResult Index(Student model)
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                return RedirectToAction("Index", "Student");
            }
        }
    }