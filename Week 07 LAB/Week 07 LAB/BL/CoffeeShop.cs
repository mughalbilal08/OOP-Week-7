using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_07_LAB.BL
{
    class CoffeeShop
    {
        public string nameS;
        public List<MenuItem> menu;
        public List<string> orders;
        public CoffeeShop()
        {

        }
        public CoffeeShop(string nameS)
        {
            this.nameS = nameS;
        }


    }
}
