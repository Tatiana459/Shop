using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Shop.Models;


namespace Shop.Models
{//Code First добавляем данные в БД
    public class NotebookDbInitializer:DropCreateDatabaseAlways<NotebookContext>
    {
        protected override void Seed(NotebookContext db)
        {
            db.Notebooks.Add(new Notebook { Name = "Aser Nitro",
                Price = 27000.0,
                Harakter = "15.6\'," +
                "Intel Core i5, RAM 16Гб, HDD1Тб" });
            db.Notebooks.Add(new Notebook
            {
                Name = "HP ENVY",
                Price = 31000.0,
                Harakter = "15.6\' Intel Core i5, RAM 16Гб, без HDD, Windows 10"});
            base.Seed(db);
        }
    }
}