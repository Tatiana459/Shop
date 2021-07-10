using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Shop.Models;
namespace Shop.Controllers
{
    public class HomeController : Controller
    { // контекст данных

        NotebookContext db = new NotebookContext();
        public ActionResult Index()
        {//Извлекаем объекты из БД  

            IEnumerable<Notebook> notebooks = db.Notebooks;

            //ViewBag - динамическое свойство, определяет переменную, передает значение,
            // затем в представлении извлекает это значение
            //ViewBag.Notebooks хранит набор ноутбуков

            ViewBag.Notebooks = notebooks;
            return View();
        }

        //Метод для покупки ноутбука

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.NoteBookId = id;
            return View();
        }


        //Метод для добавления информации о покупке

        [HttpPost]
        public string Buy(Pokupka pokupka)
        {
            pokupka.Data = DateTime.Now;

            // заносим информацию о покупке в БД
            db.Pokupkas.Add(pokupka);
            db.SaveChanges();
            return " Спасибо " + pokupka.Buyer + " за покупку";


        }

    }
}