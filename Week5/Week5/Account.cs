using System;
using System.Collections;
using System.Text;
using System.IO;
using static System.Console;
namespace Week5
{
    [Serializable]
    public class Account
    {
        private long _account_ID;
        private string _first_name;
        private string _last_name;
        private long _balance;
        public long AccountID
        {
            get => _account_ID;
            set => _account_ID = value;
        }
        public string FirstName
        {
            get => _first_name;
            set => _first_name = value;
        }
        public string LastName
        {
            get => _last_name;
            set => _last_name = value;
        }
        public long Balance
        {
            get => _balance;
            set => _balance = value;
        }

        //method
        public Account()
        {
            this.FillInfo();
        }
        public void FillInfo()
        {
            WriteLine("Account ID: ");
            _account_ID = int.Parse(ReadLine());
            WriteLine("First name: ");
            _first_name = ReadLine();
            WriteLine("Last name: ");
            _last_name = ReadLine();
            WriteLine("Balance: ");
            _balance = long.Parse(ReadLine());
        }
        public void Query()
        {
            WriteLine("Account Information:");
            WriteLine("Account ID: " + _account_ID);
            WriteLine("First name: " + _first_name);
            WriteLine("Last name: " + _last_name);
            WriteLine("Balance: " + _balance);
        }
        public void Show()
        {
            WriteLine("Account ID: " + _account_ID);
            WriteLine("First name: " + _first_name);
            WriteLine("Last name: " + _last_name);
            WriteLine("Balance: " + _balance);
        }
    }
    class IDCompare : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Account)x).AccountID.CompareTo(((Account)y).AccountID);
        }
    }
    class FirstNameCompare : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Account)x).FirstName.CompareTo(((Account)y).FirstName);
        }
    }
    class BalanceCompare : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Account)x).Balance.CompareTo(((Account)y).Balance);
        }
    }
}
