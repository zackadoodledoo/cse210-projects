using System;
using System.Collections.Generic;

namespace Foundation2
{
    //Address class
    class Address
    {
        private string streetAddress;
        private string city;
        private string stateOrProvince;
        private string country;

        public Address(string streetAddress, string city, string stateOrProvince, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.stateOrProvince = stateOrProvince;
            this.country = country;
        }

        //Method to check if the address is in the USA
        public bool IsInUSA()
        {
            return country.ToLower() == "usa";
        }

        //Method to get the full address as string
        public string GetFullAddress()
        {
            return $"{streetAddress}\n{city}, {stateOrProvince}\n{country}"; 
        }
    }

    // Customer class
    class Customer
    {
        private string name;
        private Address address;

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        //Method to get the customer name
        public string GetName()
        {
            return name;
        }

        //Method to check if the customer lives in the USA
        public bool IsInUSA()
        {
            return address.IsInUSA();
        }

        //Method to get the customer's address
        public string GetAddress()
        {
            return address.GetFullAddress();
        }
    }

    //Product class
    class Product
    {
        private string productName;
        private string productId;
        private double pricePerUnit;
        private int quantity;

        public Product(string productName, string productId, double pricePerUnit, int quantity)
        {
            this.productName = productName;
            this.productId = productId;
            this.pricePerUnit = pricePerUnit;
            this.quantity = quantity;
        }

        //Method to get the total cost of the product
        public double GetTotalCost()
        {
            return pricePerUnit * quantity;
        }

        //Method to get the product name and ID for packing label
        public string GetProductDetails()
        {
            return $"{productName} (ID: {productId})";
        } 
    }

    //Order class
    class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
            products = new List<Product>();
        }

        //Method to add a product to the order
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        //Method to calculate the total cost of the order
        public double GetTotalCost()
        {
            double total = 0;
            foreach (Product product in products)
            {
                total += product.GetTotalCost();
            }

            // Add shipping cost based on customer's location
            double shippingCost = customer.IsInUSA() ? 5.00 : 35.00;
            return total + shippingCost;
        }

        //Method to get the packing label
        public string GetPackinglabel()
        {
            string packingLabel = "Packing label:\n";
            foreach (Product product in products)
            {
                packingLabel += product.GetProductDetails() + "\n";
            }
            return packingLabel;
        }

        //Method to get the shipping label
        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress()}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Create Address
            Address address1 = new Address("485 Maple Drive", "Mayfield", "FL", "USA");
            Address address2 = new Address("456 Oak St", "Vancouver", "BC", "Canada");

            //Create customers
            Customer customer1 = new Customer("Beaver Cleaver", address1);
            Customer customer2 = new Customer("Dudley Do-Right", address2);

            //Create products
            Product product1 = new Product("Laptop", "A123", 999.99, 1);
            Product product2 = new Product("Mouse", "B456", 25.50, 2);
            Product product3 = new Product("Monitor", "C789", 199.99, 3);
            Product product4 = new Product("Keyboard", "D012", 49.99, 4);

            //Create orders and add products
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product3);
            order2.AddProduct(product4);

            //Display order details
            Console.WriteLine(order1.GetPackinglabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");
            Console.WriteLine(new string('-', 40)); //Seperator

            Console.WriteLine(order2.GetPackinglabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");

        }
    }
}