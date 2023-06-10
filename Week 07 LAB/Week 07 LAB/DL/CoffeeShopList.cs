using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_07_LAB.UI;
using Week_07_LAB.BL;

namespace Week_07_LAB.DL
{
    class CoffeeShopList
    {
        public static void addMenuItemsInMenuList(CoffeeShop c, MenuItem m)
        {
            c.menu.Add(m);
        }
        public static MenuItem cheapestItem(CoffeeShop c)
        {
            int price = c.menu[0].price;
            int index = 0;
            for (int x = 0; x < c.menu.Count; x++)
            {
                if (price > c.menu[x].price)
                {
                    price = c.menu[x].price;
                    index = x;
                }
            }
            return c.menu[index];
        }
        public static bool addOrderCheck(CoffeeShop c, MenuItem m)
        {
            for (int x = 0; x < c.menu.Count; x++)
            {
                if (m.name == c.menu[x].name)
                {
                    c.orders.Add(m.name);
                    return true;
                }
            }
            return false;
        }
        public static bool orderFullFillCheck(CoffeeShop c)
        {
            if (c.orders.Count != 0)
            {
                return true;
            }
            return false;
        }
        public static void emptylist(CoffeeShop shop)
        {
            for (int x = 0; x < shop.orders.Count; x++)
            {
                shop.orders.RemoveAt(x);
            }
        }
        public static void viewOrderedFull(CoffeeShop c)
        {
            for (int x = 0; x < c.orders.Count; x++)
            {
                MainUI.op_6(c.orders[x]);
            }
        }
        public static void viewAllOrderedList(CoffeeShop s)
        {
            for (int x = 0; x < s.orders.Count; x++)
            {
                MainUI.showorderedlist(s.orders[x]);
            }
        }
        public static void totalPrice(CoffeeShop s)
        {
            for (int x = 0; x < s.menu.Count; x++)
            {
                MainUI.totalPrice(s.menu[x].price);
            }
        }
        public static float retUrnPriceOfOrder(CoffeeShop c)
        {
            float price = 0;
            for (int x = 0; x < c.menu.Count; x++)
            {
                for (int y = 0; y < c.orders.Count; y++)
                {
                    if (c.orders[y] == c.menu[x].name)
                    {
                        price = price + c.menu[x].price;
                    }
                }
            }
            return price;
        }

    }
}
