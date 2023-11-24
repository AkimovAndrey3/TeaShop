using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShop
{
   public class Category
    {
        public List<string> Categories { get; set; }
        
        public Category()
        {
            Categories = new List<string> {"Черный чай", "Зеленый чай", "Чай в пакетиках", "Фруктовый чай", 
                "Травяной чай", "Ассорти и подарочные наборы"
           };
        }

        public IReadOnlyCollection<string> GetCategories()
        {
            return Categories.AsReadOnly();
        }
    }
}
