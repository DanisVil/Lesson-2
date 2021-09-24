using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Manual
{

    public struct BankAccountInfo
    {
        public uint number;
        public enum BankAccountType { Current = 1, Saving = 2 };
        public BankAccountType value;
        public double balance;

        public void PrintInfo()
        {
            Console.WriteLine("Номер счёта = {0}, тип = {1}, баланс = {2}", number, value, balance);
        }
    }

    public struct Employee
    {
        public string name;
        public enum University { KPFU, KAI, KCHTI };
        public University education;

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task3.1");
            BankAccountInfo.BankAccountType my_bank_account;
            my_bank_account = BankAccountInfo.BankAccountType.Current;
            Console.WriteLine(my_bank_account);

            Console.WriteLine("task3.2");
            BankAccountInfo my_bank_account_info;
            my_bank_account_info.number = 0;
            my_bank_account_info.value = BankAccountInfo.BankAccountType.Current;
            my_bank_account_info.balance = -99999999999999999;
            my_bank_account_info.PrintInfo();

            Console.WriteLine("hometask3.1");
            Employee slave;
            slave.name = "Спартак";
            slave.education = Employee.University.KPFU;
            Console.WriteLine("Имя работника - {0}, образование - {1}", slave.name, slave.education);

            Console.ReadKey();
        }
    }
}
