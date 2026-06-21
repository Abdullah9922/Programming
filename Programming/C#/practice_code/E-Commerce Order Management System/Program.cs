using System;

namespace ECommerceSystem
{
    // ----------------------------
    // Product (base class) and its subclasses
    // ----------------------------
    public class Product
    {
        public int Id { get; }
        public string Name { get; }
        public double Price { get; }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public virtual string GetDetails()
        {
            return $"Product[Id={Id}, Name={Name}, Price={Price:F2}]";
        }
    }

    public class Electronics : Product
    {
        public int Warranty { get; } // warranty period in months

        public Electronics(int id, string name, double price, int warranty)
            : base(id, name, price)
        {
            Warranty = warranty;
        }

        public override string GetDetails()
        {
            return $"Electronics[Id={Id}, Name={Name}, Price={Price:F2}, Warranty={Warranty} months]";
        }
    }

    public class Clothing : Product
    {
        public string Size { get; }

        public Clothing(int id, string name, double price, string size)
            : base(id, name, price)
        {
            Size = size;
        }

        public override string GetDetails()
        {
            return $"Clothing[Id={Id}, Name={Name}, Price={Price:F2}, Size={Size}]";
        }
    }

    // ----------------------------
    // Customer
    // ----------------------------
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }

    // ----------------------------
    // Order (base class) and OnlineOrder (subclass)
    // ----------------------------
    public class Order
    {
        protected int OrderId { get; }
        protected Product Product { get; }
        protected int Quantity { get; }

        public Order(int orderId, Product product, int quantity)
        {
            OrderId = orderId;
            Product = product;
            Quantity = quantity;
        }

        public virtual double CalculateTotal()
        {
            return Product.Price * Quantity;
        }

        public virtual void PrintInvoice()
        {
            Console.WriteLine("---------- INVOICE ----------");
            Console.WriteLine($"Order ID   : {OrderId}");
            Console.WriteLine($"Product    : {Product.GetDetails()}");
            Console.WriteLine($"Quantity   : {Quantity}");
            Console.WriteLine($"Total      : {CalculateTotal():F2}");
            Console.WriteLine("------------------------------");
        }
    }

    public class OnlineOrder : Order
    {
        public double DeliveryCharge { get; }

        public OnlineOrder(int orderId, Product product, int quantity, double deliveryCharge)
            : base(orderId, product, quantity)
        {
            DeliveryCharge = deliveryCharge;
        }

        public override double CalculateTotal()
        {
            return base.CalculateTotal() + DeliveryCharge;
        }

        public override void PrintInvoice()
        {
            Console.WriteLine("------- ONLINE INVOICE -------");
            Console.WriteLine($"Order ID        : {OrderId}");
            Console.WriteLine($"Product         : {Product.GetDetails()}");
            Console.WriteLine($"Quantity        : {Quantity}");
            Console.WriteLine($"Delivery Charge : {DeliveryCharge:F2}");
            Console.WriteLine($"Total           : {CalculateTotal():F2}");
            Console.WriteLine("-------------------------------");
        }
    }

    // ----------------------------
    // Payment (abstract class) and its subclasses
    // ----------------------------
    public abstract class Payment
    {
        protected double Amount { get; }

        public Payment(double amount)
        {
            Amount = amount;
        }

        public abstract void ProcessPayment();
    }

    public class CreditCardPayment : Payment
    {
        public string CardNumber { get; }

        public CreditCardPayment(double amount, string cardNumber)
            : base(amount)
        {
            CardNumber = cardNumber;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing credit card payment of {Amount:F2} using card ending in {CardNumber.Substring(CardNumber.Length - 4)}.");
        }
    }

    public class PayPalPayment : Payment
    {
        public string Email { get; }

        public PayPalPayment(double amount, string email)
            : base(amount)
        {
            Email = email;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing PayPal payment of {Amount:F2} via account {Email}.");
        }
    }

    // ----------------------------
    // Demo / Main program
    // ----------------------------
    class Program
    {
        static void Main(string[] args)
        {
            // Create products
            Product laptop = new Electronics(1, "Laptop", 75000.00, 24);
            Product shirt = new Clothing(2, "T-Shirt", 850.00, "L");

            Console.WriteLine(laptop.GetDetails());
            Console.WriteLine(shirt.GetDetails());
            Console.WriteLine();

            // Create customer
            Customer customer = new Customer("Rahim Uddin", "rahim@example.com");
            Console.WriteLine($"Customer: {customer.GetName()}");
            Console.WriteLine();

            // Normal order
            Order order1 = new Order(101, laptop, 1);
            order1.PrintInvoice();
            Console.WriteLine();

            // Online order (with delivery charge)
            Order order2 = new OnlineOrder(102, shirt, 3, 100.00);
            order2.PrintInvoice();
            Console.WriteLine();

            // Payments
            Payment creditPayment = new CreditCardPayment(order1.CalculateTotal(), "1234567812345678");
            creditPayment.ProcessPayment();

            Payment paypalPayment = new PayPalPayment(order2.CalculateTotal(), "rahim@example.com");
            paypalPayment.ProcessPayment();
        }
    }
}
