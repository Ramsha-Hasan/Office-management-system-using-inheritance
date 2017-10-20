using System;

namespace ConsoleApp3
{
    class Worker
    {
        public string name, fatherName, ID;
        public int pay, hour, bonus;

        public Worker()
        {
            Console.WriteLine("This is base class constructor");
        }

       
        public virtual void PrintData()
        {
            Console.Write("Name: {0}\nFatherName: {1}\nID: {2}\nPay: {3}\nHour: {4}",name,fatherName,ID,pay,hour);
        }

        public int payCalc()
        {

            if(hour > 8)
            {
                pay = pay + bonus;
                return pay;
            }
            else
            {
                return pay;
            }
        }
    }

    class Manager : Worker
    {
        public Manager()
        {
            
            Console.WriteLine("This is a manager class constructor");
        }
    }

    class Guard : Worker
    {
           public Guard()
        {
            Console.WriteLine("This is guard class constructor");
        }

        public override void PrintData()
        {
            Console.Write("Name: {0}\nFatherName: {1}\nID: {2}\nHour: {3}", name, fatherName, ID, hour);
        }
    }
   
    class Program 
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.name = "Ramsha Hasan";
            manager.fatherName = "Abid Hasan";
            manager.ID = "RU2202";
            manager.pay = 70000;
            manager.hour = 9;
            manager.bonus = 10000;

            manager.payCalc();
            manager.PrintData();

            Guard guard = new Guard();
            guard.name = "Ghulaam";
            guard.fatherName = "Rasool";
            guard.ID = "YU890";
            guard.pay = 7500;
            guard.hour = 8;

            guard.PrintData();
           

            Console.ReadKey();
        }
    }
}

