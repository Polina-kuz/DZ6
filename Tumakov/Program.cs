using Tumakov.Enums;
using Tumakov.Structs;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
        private static void Task1()
        {
            Console.WriteLine("Упражнение 7.1");
            Bank bankAccount = new Bank("12345", 50000, AccountType.savings);
            bankAccount.PrintAccount();
        }
        private static void Task2()
        {
            Console.WriteLine("7.2");
            Bank2 bankAccount2 = new Bank2(10000, AccountType.savings);
            bankAccount2.PrintBank2();
        }
        private static void Task3()
        {
            Console.WriteLine("7.3");
            Bank3 bankAccount3 = new Bank3(10000, AccountType.current);
            bankAccount3.PrintBank3();
            bankAccount3.Deposit(5000);
            bankAccount3.PrintBank3();
            bankAccount3.Withdrawal(3000);
            bankAccount3.PrintBank3();
            bankAccount3.Withdrawal(15000);
            bankAccount3.PrintBank3();
        }
        private static void Task4()
        {
            Console.WriteLine("Домашнее задание 7.1");
            Building building = new Building(40,7,100,2);
            building.PrintBuilding();
        }
    }
}
