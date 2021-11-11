using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using BookStore.ViewModels;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Linq;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private IMemoryCache _cache;
        private readonly IWebHostEnvironment env;

        public HomeController(IMemoryCache memoryCache, IWebHostEnvironment hostingEnvironment)
        {
            _cache = memoryCache;
            env = hostingEnvironment;

        }
        public IActionResult Index(string Message = null)
        {
            //get or set List
            List<BookViewModel> model = _cache.GetOrCreate("List", entry =>
            {
                return new List<BookViewModel>();
            });
            ViewBag.Message = Message;
            return View(model);
        }

        public IActionResult Borrow_Return(BookViewModel Item = null)
        {
            try
            {
                if (Item != null)
                {
                    //get or set the history list
                    List<BookViewModel.History> HistoryList = _cache.GetOrCreate("History", entry => { return new List<BookViewModel.History>(); });

                    BookViewModel.History Data = new BookViewModel.History();
                    Data.Date = DateTime.Now; //set today's date
                    Data.Type = Item.isAvailable ? false : true; //set type 0-Borrow, 1-Return
                    Data.Id = Item.Id;
                    HistoryList.Add(Data); // Add change in list
                    _cache.Set("History", HistoryList);


                    //UPDATE MAIN LIST, CHANGING BORROW OR RETURN
                    List<BookViewModel> model = _cache.GetOrCreate("List", entry =>
                    {
                        return new List<BookViewModel>();
                    });
                    if (model.Count > 0)
                    {
                        var main = model.Single(r => r.Id.Equals(Item.Id));
                        main.isAvailable = !main.isAvailable; //set the availability of the book
                        _cache.Set("List", model);//save in the main list

                        //model.Remove(itemToRemove);
                    }
                }
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                return RedirectToAction("Error", new { Message = e.Message });
            }



        }
        [HttpGet]
        [HttpPost]
        public IActionResult Details(Guid id, string Message = null)
        {
            //get or set List
            List<BookViewModel> model = _cache.GetOrCreate("List", entry => { return new List<BookViewModel>(); });
            if (model.Count > 0 && id != Guid.Empty)
            {
                var main = model.Single(r => r.Id.Equals(id));

                //get history
                List<BookViewModel.History> HistoryList = _cache.GetOrCreate("History", entry => { return new List<BookViewModel.History>(); });
                main.HistListB = HistoryList.Where(x => x.Id.Equals(id) && x.Type.Equals(false)).ToList();
                main.HistListR = HistoryList.Where(x => x.Id.Equals(id) && x.Type.Equals(true)).ToList();
                ViewBag.Message = Message;
                return View(main);
            }


            return RedirectToAction("Index");

        }


        [HttpPost]
        public IActionResult SaveBook(BookViewModel New = null)
        {
            try
            {
                //Saves the image in an specific folder and rename the Cover. If the user didn't upload an image, is gona show the Default.jpeg in the page list
                if (New.DocuFile != null)
                    if (UploadCover(New.DocuFile))
                        New.Cover = New.DocuFile.FileName;

                //get or set the List in the Cache
                List<BookViewModel> model = _cache.GetOrCreate("List", entry =>
                {
                    return new List<BookViewModel>();
                });

                //Add the form in the list
                model.Add(New);

                //Save it in the cache
                _cache.Set("List", model);

                return RedirectToAction("Index", new { Message = "Success!, The book was added." });
            }
            catch (Exception e)
            {
                return RedirectToAction("Error", new { Message = e.Message });
            }

        }

        [HttpPost]
        public IActionResult DeleteBook(BookViewModel Item = null)
        {
            if (Item.isAvailable)
            {
                //get or set List
                List<BookViewModel> model = _cache.GetOrCreate("List", entry =>
                {
                    return new List<BookViewModel>();
                });
                if (model.Count > 0)
                {
                    var main = model.Single(r => r.Id.Equals(Item.Id));
                    model.Remove(main);
                }
                return RedirectToAction("Index", new { Message = "Success!, The book was deleted." });

            }
            else
                return RedirectToAction("Details", new { id=Item.Id, Message = "This book is borrowed, please return it in order to delete it." });

        }

        public bool UploadCover(IFormFile file)
        {
            string webRootPath = env.WebRootPath;
            string fName = string.Empty;

            try
            {
                ////loop through all the files
                if (!string.IsNullOrEmpty(file.FileName))
                {
                    fName = file.FileName;

                    string path = Path.Combine(webRootPath, "images", "Covers", fName);
                    if (!(Directory.Exists(path)))
                    {
                        string filePath = Path.Combine(webRootPath, "images", "Covers", fName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                        }
                    }

                }
                return true;

            }
            catch (Exception e)
            {
                return false;

            }
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(string Message = null)
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
