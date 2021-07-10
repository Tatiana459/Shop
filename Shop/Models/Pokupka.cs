using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Pokupka
    { //Id покупки
        public int PokId { get; set; }

        //Дата покупки
       public DateTime Data { get; set; }

// Фамилия, имя покупателя
public string Buyer { get; set; }
//Id ноутбука
        public int NoteBookId { get; set; }
    }
}