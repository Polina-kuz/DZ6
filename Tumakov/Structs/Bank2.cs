using System;
using System.Collections.Generic;
using System.Text;
using Tumakov.Enums;

namespace Tumakov.Structs
{
    internal class Bank2
    {
        private static long number = 10000000;
        private string numberr;
        private decimal balance;
        private AccountType type;
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public AccountType Type
        {
            get { return type; }
            set { type = value; }
        }
        public Bank2(decimal balancee, AccountType typee)
        {
            numberr = GenerateNumber();
            Balance = balancee;
            Type = typee;
        }
        private string GenerateNumber()
        {
            return (number++).ToString();
        }
        public void PrintBank2()
        {
            Console.WriteLine($"Номер счета: {number}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счета: {type}");
        }
    }
}
