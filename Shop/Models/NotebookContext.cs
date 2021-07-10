using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Shop.Models
{
    public class NotebookContext: DbContext
    {// Наборы объектов ноутбук и покупки, для взаимодействия с БД
        public DbSet<Notebook> Notebooks { get; set; }
        public DbSet<Pokupka> Pokupkas { get; set; }
    }
} 