using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using CoreDemo.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager (new EfWriterRepository ());
        [HttpGet]
        public IActionResult Index()
        {
			var viewModel = new IlViewModel
			{
				Iller = IlListesi().ConvertAll(x =>
					new SelectListItem
					{
						Value = x.ilKod.ToString(),
						Text = x.ilAd
					})
			};
			//Sayfa yüklenince çalışır
			return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p)
        {
			WriterValidator wv = new WriterValidator();
			ValidationResult results = wv.Validate(p);
			if (results.IsValid)
			{
                //Ekleme işlemi yapılırken http get ve post attribute lerinin tanımlandığı metotların isimleri aynı olmak zorundadır
                //Sayfada buton tetiklenince çalışır
                p.WriterStatus = true;
                p.WriterAbout = "Yazar hakkında...";
                wm.TAdd(p);
                return RedirectToAction("Index", "Blog");
            } 
			else
			{
				foreach(var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
            
        }

		private List<IlModel> IlListesi()
		{
			return new List<IlModel>
		{
			new IlModel { ilKod = 1, ilAd = "İstanbul" },
			new IlModel { ilKod = 2, ilAd = "Ankara" },
			new IlModel { ilKod = 3, ilAd = "İzmir" }
            // Diğer illeri buraya ekleyebilirsiniz
        };
		}
	}
}
