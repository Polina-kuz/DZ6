using System;
using System.Collections.Generic;
using System.Text;
using Tumakov.Enums;

namespace Tumakov.Structs
{
    class Bank
    {
        private string number;
        private decimal balance;
        private AccountType type;
        public string Number
        {
            get {  return number; }
            set { number = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set {  balance = value; }
        }
        public AccountType Type
        {
            get { return type; }
            set { type  = value; }
        }
        public Bank(string nnumber, decimal bbalance, AccountType ttype)
        {
            Number = nnumber;
            Balance = bbalance;
            Type = ttype;
        }
        public void PrintAccount()
        {
            Console.WriteLine($"Номер счета: {number}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счета: {type}");
        }
    }
}
