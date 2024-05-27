using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        enum Functions
        {
            Design,
            Logistics,
            Сonstruction
        }

        enum Type
        {
            Brick,
            FromFoamBlocks,
            FromAeratedConcreteBlocks,
            Frame,
            MadeOfWood
        }

        class Customer
        {
            public Customer() { }

            public Customer(Guid id)
            {
                this.id = id;
            }

            public Customer(string firstName, int phone)
            {
                id = Guid.NewGuid();
                this.firstName = firstName;
                this.phone = phone;
            }

            public Customer(Guid id, string firstName, int phone)
            {
                this.id = id;
                this.firstName = firstName;
                this.phone = phone;
            }

            public Customer(Guid id, string firstName, string lastName, string midleName, int phone, string posmailingAddress) : this(id, firstName, phone)
            {
                this.lastName = lastName;
                this.midleName = midleName;
                PosmailingAddress = posmailingAddress;
            }

            public Customer(Customer customer)
            {
                id = customer.id;
                firstName = customer.firstName;
                lastName = customer.lastName;
                midleName = customer.midleName;
                phone = customer.phone;
                PosmailingAddress = customer.PosmailingAddress;
            }

            public Customer(Guid id, string firstName, string lastName, string midleName, string phone, string posmailingAddress)
            {
                this.id = id;
                this.firstName = firstName;
                this.lastName = lastName;
                this.midleName = midleName;
                this.phone = Convert.ToInt32(phone);
                PosmailingAddress = posmailingAddress;
            }

            public Guid id;
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string midleName { get; set; }
            public int phone { get; set; }
            public string PosmailingAddress { get; set; }

            public virtual void Print()
            {
                Console.WriteLine($"ID: {id}, First name: {firstName}, Last name: {lastName}, Middle name: {midleName}, Phone: {phone}");
            }

            public void Display()
            {
                Console.WriteLine("This is a method of the base class.");
            }
        }

        class Manager : Customer
        {
            public Manager() { }

            public Manager(int salary)
            {
                this.salary = salary;
            }

            public Manager(Guid id, string firstName, int phone, string departament) : base(id, firstName, phone)
            {
                this.departament = departament;
            }

            public Manager(int salary, string departament, string powers) : this(salary)
            {
                this.departament = departament;
                this.powers = powers;
            }

            public Manager(string firstName, int phone, int salary) : base(firstName, phone)
            {
                this.salary = salary;
            }

            public Manager(Guid id, string departament) : base(id)
            {
                this.departament = departament;
            }

            public int salary { get; set; }
            public string departament { get; set; }
            public string powers { get; set; }

            public override void Print()
            {
                Console.WriteLine($"Manager: {id}, {firstName}, {phone}, {departament}");
            }

            public virtual void SendReport(string report)
            {
                Console.WriteLine("Sending report via email: " + report);
            }
        }

        class Worker : Manager
        {
            public Worker() { }

    public Worker(Guid id, string firstName, int phone, string departament, Functions functions) : base(id, firstName, phone, departament)
            {
                this.functions = functions;
            }

            public Worker(Guid id, string departament, Functions functions) : base(id, departament)
            {
                this.functions = functions;
            }

            public Worker(Functions functions)
            {
                this.functions = functions;
            }

            public Worker(string firstName, int phone, int salary, Functions functions) : base(firstName, phone, salary)
            {
                this.functions = functions;
            }

            public Worker(string firstName, int phone, int salary) : base(firstName, phone, salary) { }

            public Functions functions { get; set; }

            public override void Print()
            {
                Console.WriteLine($"Worker: {id}, {firstName}, {phone}, {departament}, Function: {functions}");
            }

            public sealed override void SendReport(string report)
            {
                Console.WriteLine("Sending report via SMS: " + report);
            }
        }

        sealed class Project
        {
            public Project() { }

            public Project(Project project)
            {
                id = project.id;
                type = project.type;
                OrderDate = project.OrderDate;
                CastomerId = project.CastomerId;
            }

            public Project(Guid id, Type type)
            {
                this.id = id;
                this.type = type;
            }

            public Project(Guid id, Type type, DateTime orderDate, Guid castomerId) : this(id, type)
            {
                CastomerId = castomerId;
                OrderDate = orderDate;
            }

            public Project(Guid id, Guid castomerId)
            {
                this.id = id;
                CastomerId = castomerId;
            }

            public Guid id { get; set; }
            public Type type { get; set; }
            public DateTime OrderDate { get; set; }
            public Guid CastomerId { get; set; }
        }
    static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
