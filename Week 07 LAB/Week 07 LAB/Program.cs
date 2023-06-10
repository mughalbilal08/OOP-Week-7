using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_07_LAB.UI;
using Week_07_LAB.BL;
using Week_07_LAB.DL;

namespace Week_07_LAB
{
    class Program
    {
        public static CoffeeShop objC = MainUI.shopName();
        static void Main(string[] args)
        {
            int option = 0;
            while (option != 9)
            {
                Console.Clear();
                option = MainUI.menu(objC.nameS);
                Console.Clear();
                if (option == 1)
                {
                    MenuItem objM = MainUI.addMenu();
                    CoffeeShopList.addMenuItemsInMenuList(objC, objM);
                    Console.ReadKey();
                }
                if (option == 2)
                {
                    MainUI.CheepestPrice(objC);
                    Console.ReadKey();
                }
                if (option == 3)
                {
                    MainUI.ViewDrink(objC);
                    Console.ReadKey();
                }
                if (option == 4)
                {
                    MainUI.ViewCoffee(objC);
                    Console.ReadKey();
                }
                if (option == 5)
                {
                    MenuItem objO = MainUI.addOrder();
                    bool check = CoffeeShopList.addOrderCheck(objC, objO);
                    if (check)
                    {
                        MainUI.OC();

                    }
                    else
                    {
                        MainUI.OCN();
                    }
                    Console.ReadKey();
                }
                if (option == 6)
                {
                    bool check = CoffeeShopList.orderFullFillCheck(objC);
                    if (check)
                    {
                        CoffeeShopList.viewOrderedFull(objC);
                        CoffeeShopList.emptylist(objC);
                    }
                    else
                    {
                        MainUI.elseForop_6();
                    }
                    Console.ReadKey();
                }
                if (option == 7)
                {
                    bool check = CoffeeShopList.orderFullFillCheck(objC);
                    if (check)
                    {
                        CoffeeShopList.viewAllOrderedList(objC);    
                    }
                    else
                    {
                        MainUI.elseForop_7();
                    }
                    Console.ReadKey();
                }
                if (option == 8)
                {
                    float priceC = CoffeeShopList.retUrnPriceOfOrder(objC);
                    MainUI.totalPrice(priceC);
                    Console.ReadKey();
                }
                if (option == 9)
                {

                }
            }
        }
    }
}
