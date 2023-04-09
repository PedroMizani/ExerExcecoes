using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExeExce.Entities.Exceptions;

namespace ExeExce.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public  string Holder { get; set; }
        public  double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }




        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }





        public void Deposit(double amount)
        {
            Balance += amount;
        }



        public void Withdraw (double amount)
        {

            if (Balance == 0.0)
            {
                throw new DomainException(" The amount exceeds withdraw limit");
            }

            if (amount > WithdrawLimit)
            {
                throw new DomainException(" The amount exceeds withdraw limit");
            }

            if (amount > Balance)
            {
                throw new DomainException(" Not enough balance");
            }


            Balance -= amount;
           
        }

       
    }
}
