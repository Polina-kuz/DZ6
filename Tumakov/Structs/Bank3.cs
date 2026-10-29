using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using Tumakov.Enums;

namespace Tumakov.Structs
{
    public class Bank3
    {
        private static long numberr = 1000000;
        private string number;
        private decimal balance;
        private AccountType type;
        public decimal Balance
        {
            get { return balance; }
            set {  balance = value; }
        }
        public AccountType Type
        {
            get { return type; }
            set { type = value; }
        }
        public Bank3(decimal balancee, AccountType typee)
        {
            number = GenerateNumber();
            Balance = balancee;
            Type = typee;
        }
        private string GenerateNumber()
        {
            return numberr++.ToString();
        }
        public void PrintBank3()
        {
            Console.WriteLine($"Номер счета: {number}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счета: {type}");
        }
        public void Deposit(decimal amount)
        {
            balance -= amount;
            Console.WriteLine($"{amount} зачислено на счет");
        }
        public bool Withdrawal(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"{amount} снято со счета");
                return true;
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
                return false;
            }
        }
    }
}
