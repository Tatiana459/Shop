using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{//Создание класса ноутбук
    public class Notebook
    {
        public int  Id {get;set;}

        //Название ноутбука
        public string Name { get; set; }

        //Цена
        public double Price { get; set; }

        //Характеристики ноутбука
        public string Harakter { get; set; }

    }
}