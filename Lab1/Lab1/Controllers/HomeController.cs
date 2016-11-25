using Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Folder root = createTempDate();

            return View(root);
        }

        public Folder createTempDate()
        {
            return new Folder()
            {
                Name = "root",
                Date = DateTime.Now,
                Subelements = new List<Element>()
                {
                    new File() { Name = "file1", Date = DateTime.Now, Size = 153 },
                    new File() { Name = "file2", Date = DateTime.Now, Size = 70 },
                    new Folder()
                    {
                        Name = "folder1",
                        Date = DateTime.Now,
                        Subelements = new List<Element>()
                        {
                            new File() { Name = "file3", Date = DateTime.Now, Size = 85 },
                            new File() { Name = "file4", Date = DateTime.Now, Size = 39 },
                            new File() { Name = "file5", Date = DateTime.Now, Size = 107 },
                            new Folder()
                            {
                                Name = "folder3",
                                Date = DateTime.Now,
                                Subelements = new List<Element>()
                                {
                                    new File() { Name = "file9", Date = DateTime.Now, Size = 302 },
                                    new File() { Name = "file10", Date = DateTime.Now, Size = 86 }
                                }
                            }
                        }
                    },
                    new Folder()
                    {
                        Name = "folder2",
                        Date = DateTime.Now,
                        Subelements = new List<Element>()
                        {
                            new File() { Name = "file6", Date = DateTime.Now, Size = 257 },
                            new File() { Name = "file7", Date = DateTime.Now, Size = 5 },
                            new File() { Name = "file8", Date = DateTime.Now, Size = 68 }
                        }
                    }
                }
            };
        }
    }
}