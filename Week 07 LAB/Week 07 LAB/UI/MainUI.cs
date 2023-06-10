using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_07_LAB.BL;
using Week_07_LAB.DL;

namespace Week_07_LAB.UI
{
    class MainUI
    {
        public static CoffeeShop shopName()
        {
            Console.WriteLine("Enter Shop Name You Want to Set ");
            string name = Console.ReadLine();
            CoffeeShop objN = new CoffeeShop(name);
            return objN;
        }
        public static int menu(string name)
        {
            int choice;
            Console.WriteLine("Welcome To The " + name + " Coffee Shop");
            Console.WriteLine("1. Add a Menu ");
            Console.WriteLine("2. View The Cheapest In The Menu ");
            Console.WriteLine("3. View The Drinks Menu ");
            Console.WriteLine("4. View The Foods Menu ");
            Console.WriteLine("5. Add Order ");
            Console.WriteLine("6. FulFill The Order ");
            Console.WriteLine("7. View The Orders List ");
            Console.WriteLine("8. Total PayAble Amount ");
            Console.WriteLine("9. Exit ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static MenuItem addMenu()
        {
            Console.WriteLine("Add Product Name ");
            string name = Console.ReadLine();
            Console.WriteLine("Add Product Type ");
            string type = Console.ReadLine();
            Console.WriteLine("Add Product Price ");
            int price = int.Parse(Console.ReadLine());
            MenuItem objA = new MenuItem(name, type, price);
            return objA;
        }
        public static void CheepestPrice(CoffeeShop s)
        {
            MenuItem objM = CoffeeShopList.cheapestItem(s);
            Console.WriteLine("Name"+ "\t" + "Type" + "\t" + "Cheapest Price");
            Console.WriteLine();
            Console.WriteLine(objM.name + "\t" + objM.type + "\t" + objM.price);

        }
        public static void ViewDrink(CoffeeShop c)
        {
            Console.WriteLine("Name" + "\t" + "Type" + "\t" + "Drink Price");
            for (int x = 0; x < c.menu.Count; x++)
            {
                if (c.menu[x].type == "Drink")
                {
                    Console.WriteLine(c.menu[x].name + "\t" + c.menu[x].type + "\t" + c.menu[x].price);      
                }
            }
        }
        public static void ViewCoffee(CoffeeShop c)
        {
            Console.WriteLine("Name" + "\t" + "Type" + "\t" + "Coffee Price");
            for (int x = 0; x < c.menu.Count; x++)
            {
                if (c.menu[x].type == "Coffee")
                {
                    Console.WriteLine(c.menu[x].name + "\t" + c.menu[x].type + "\t" + c.menu[x].price);
                }
            }
        }
        public static MenuItem addOrder()
        {
            Console.WriteLine("ENter Product Name You Want To Order");
            string name = Console.ReadLine();
            MenuItem m = new MenuItem(name);
            return m;
        }
        public static void OC()
        {
            Console.WriteLine("The Item Is Currently Available ");
        }
        public static void OCN()
        {
            Console.WriteLine("The Item Is Currently Unavailable ");
        }
        public static void op_6(string order)
        {
            Console.WriteLine("The " + order + "is Ready");
        }
        public static void elseForop_6()
        {
            Console.WriteLine("All orders have been fulfilled");
        }
        public static void showorderedlist(string ordered)
        {
            Console.WriteLine();
            Console.WriteLine("Ordered item are: " + ordered);
        }
        public static void elseForop_7()
        {
            Console.WriteLine();
            Console.WriteLine(" All item has been exhausted");
        }
        public static void totalPrice(float price)
        {
            Console.WriteLine();
            Console.WriteLine(" The total bill is: " + price); ;
        }
    }
}
