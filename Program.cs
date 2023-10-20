using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Sharp_Class5
{
    public class CreditCard
    {
        private long _number;
        private string _owner_name;
        private string _expiration_time;
        private int _pin;
        private double _credit_limit;
        private double _balance;

        public CreditCard(int number, string owner_name, string expiration_time, int pin, double credit_limit, double balance)
        {
            _number = number;
            _owner_name = owner_name;
            _expiration_time = expiration_time;
            _pin = pin;
            _credit_limit = credit_limit;
            _balance = balance;
        }

        public void ChangePin(int pin_new)
        {
            if (_pin == pin_new)
            {
                Console.WriteLine("Password can`t be changed");
            }
            else
            {
                _pin = pin_new;
                Console.WriteLine($"Password succesfully changed: ${_pin}");
            }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Balance updated: ${_balance}");
            }
            else
            {
                Console.WriteLine("Balance can`t be updated");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"Balance updated: ${_balance}");
            }
            else
            {
                Console.WriteLine("Not enough money");
            }
        }

        public void StartCredit(double amount)
        {
            if (amount <= _credit_limit && amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Credit started, balance updated: ${_balance}");
            }
            else 
            {
                Console.WriteLine("Credit can`t be started");
            }
        }

        public void CheckCreditLimit()
        {
            if (_balance > _credit_limit)
            {
                Console.WriteLine($"U reach credit limit: ${_balance}");
            }
            else
            {
                Console.WriteLine($"Remaining to credit limit: ${_credit_limit - _balance}");
            }
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard card = new CreditCard(123123123, "qwe", "123", 1234, 12313.232, 0);

            card.Deposit(2000);
            card.StartCredit(1000);
            card.ChangePin(3124);
            card.CheckCreditLimit();
            card.Withdraw(1000);
        }
    }
}
