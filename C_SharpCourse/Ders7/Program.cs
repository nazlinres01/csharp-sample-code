using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Ders7
{
    class Program
    {
        //sınıflar burda da tanımlanır,ya da ayrı bir sınıf açılır oraya yazılabilir.
        //sınıf çağırma işlemi static void Main içerisinde olmalı.
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add();
            //customerManager.Update();


            //ProductManager productManager = new ProductManager();
            //productManager.Add();
            //productManager.Update();
            

            Customer customer = new Customer();
            customer.City = "İstanbul";
            customer.Id = 1;
            customer.FirstName = "Nazlı";
            customer.LastName = "Esmeray";

            //Bu şekilde de yapılabilir...
            Customer customer2 = new Customer
            {
                Id = 2,
                City = "Ankara",
                FirstName = "Ayşe",
                LastName = "Fatma"
            };

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.City);
            Console.ReadLine();


        }
    }
    //class CustomerManager//ilk harf büyük harfle yazılır
    //{
    //    public void Add()
    //    {
    //        Console.WriteLine("Customer Added");
    //    }
    //    public void Update()
    //    {
    //        Console.WriteLine("Customer Updated");

    //    }
    //}

    class Customer
    {
        //property
        public int Id  { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
