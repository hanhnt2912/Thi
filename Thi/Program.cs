using System;
using Thi.entity;

namespace Thi
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[5];
            
            var productname = "Sach1";
            products[0] = new Book();
            
            
            products[0].productName = productname;
            products[0].productId = 0;
            products[0].productPrice = 2500;
            Console.WriteLine("Product {0} -Book: (id={1},name={2},price={3}) - computeTax = {4}", 0, products[0].productId,
                products[0].productName, products[0].productId, products[0].productPrice);
            
            var productname1 = "Sach2";
            products[1] = new Book();
            
            
            products[1].productName = productname1;
            products[1].productId = 1;
            products[1].productPrice = 2500;
            Console.WriteLine("Product {0} -Book: (id={1},name={2},price={3}) - computeTax = {4}", 1, products[1].productId,
                products[1].productName, products[1].productId, products[1].productPrice);
            
            var productname2 = "Sach3";
            products[2] = new Book();
            
            
            products[2].productName = productname1;
            products[2].productId = 2;
            products[2].productPrice = 2500;
            Console.WriteLine("Product {0} -Book: (id={1},name={2},price={3}) - computeTax = {4}", 2, products[2].productId,
                products[2].productName, products[2].productId, products[2].productPrice);
            
            var productname3 = "phone1";
            products[3] = new phone();
            
            
            products[3].productName = productname1;
            products[3].productId = 3;
            products[3].productPrice = 2500;
            Console.WriteLine("Product {0} -Book: (id={1},name={2},price={3}) - computeTax = {4}", 3, products[3].productId,
                products[3].productName, products[3].productId, products[3].productPrice);
            
            var productname4 = "phone2";
            products[4] = new phone();
            
            
            products[4].productName = productname1;
            products[4].productId = 4;
            products[4].productPrice = 2500;
            Console.WriteLine("Product {0} -Book: (id={1},name={2},price={3}) - computeTax = {4}", 4, products[4].productId,
                products[4].productName, products[4].productId, products[4].productPrice);
        }
        
        
    }
}