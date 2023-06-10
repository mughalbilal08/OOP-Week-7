using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_07_LAB.DL;

namespace Week_07_LAB.BL
{
    class MenuItem
    {
        public string name;
        public string type;
        public int price;
        public MenuItem()
        {

        }
        public MenuItem(string name, string type, int price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }
        public MenuItem(string name)
        {
            this.name = name;
        }
    }
}
