using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                BankAccount<int> acc1 = new BankAccount<int>();
                acc1.SetInfo(1000001, 100, "Клиент 1") ; 
                acc1.GetInfo();

                BankAccount<string> acc2 = new BankAccount<string>();
                acc2.SetInfo("1000002", 200, "Клиент 2");
                acc2.GetInfo();

                BankAccount<string> acc3 = new BankAccount<string>();
                acc2.SetInfo("10000003", 300, "Клиент 3");
                acc2.GetInfo();

                Console.ReadKey();
            }
        }

        class BankAccount<T>
        {
            private T AccountNumber;
            private double AccountBalance;
            private string Hm;

            public T AccNumber
            {
                set
                {
                    AccountNumber = value;
                }
                get
                {
                    return AccountNumber;
                }
            }

            public double Balance
            {
                set
                {
                    AccountBalance = value;
                }
                get
                {
                    return AccountBalance;
                }
            }

            public string Name
            {
                set
                {
                    Hm = value;
                }
                get
                {
                    return Hm;
                }
            }

            public void SetInfo(T value, double balance, string Name)
            {
                AccountNumber = value;
                AccountBalance = balance;
                Hm = Name;
            }
            public void GetInfo()
            {
                Console.WriteLine("Счет № {0}: ", AccNumber);
                Console.WriteLine("Принадлежит : {0}", Name);
                Console.WriteLine("Баланс: {0} руб.", Balance);
                Console.WriteLine();
            }
        }
    }
}


