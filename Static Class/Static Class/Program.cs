using System;

namespace Static_Class
{
    static class Product
    {
        public static int ProductID;
        public static string ProductName;
        public static int UnitPrice;
        public static int Quantity;
        public static int TotalPrice;

        static Product()
        {
            ProductID = 101;
            ProductName = "iPhone 15 Pro Max";
            UnitPrice = 150000;
        }
        public static void GetProductDetails()
        {
            Console.WriteLine("Product ID: {0}", ProductID);
            Console.WriteLine("Product Name: {0}", ProductName);
            Console.WriteLine("Unit Price: {0:N2} BDT", UnitPrice);

        }

        public static void SetQuantity()
        {
            Console.Write("Enter quantity: ");
            Quantity = int.Parse(Console.ReadLine());
            TotalPrice = Quantity * UnitPrice;
        }

        
        public static void GetTotalPrice()
        {
            Console.WriteLine("Quantity: {0}", Quantity);
            Console.WriteLine("Total Price: {0:N2} BDT", TotalPrice);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
         
            Product.GetProductDetails();
            Product.SetQuantity(); 
            Product.GetTotalPrice();
            Console.ReadLine();
        }
    }
}
