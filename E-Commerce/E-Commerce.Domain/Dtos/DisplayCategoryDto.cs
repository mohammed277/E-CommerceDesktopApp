using E_Commerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Dtos
{
    public class DisplayCategoryDto
    {
        public int ID { get; private set; }
        public string Name { get; set; }

        static private int nextId = 1;
        static public int NextId
        {
            get { return nextId++; }
        }

        public DisplayCategoryDto()
        {
            ID = NextId;
        }

    }

}
