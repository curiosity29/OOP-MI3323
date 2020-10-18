using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Console;
namespace Week5
{
    [Serializable]
    public class AccountList
    {
        private ArrayList accountList = new ArrayList();
        public void NewAccount()
        {
            accountList.Add(new Account());
        }
        public void SaveFile()
        {
            WriteLine("Nhập tên file để lưu:");
            string fileName = ReadLine();
            //StreamWriter file = new StreamWriter(fileName);

            //foreach (Account account in accountList)
            //{
            //    file.WriteLine("Account ID: " + account.AccountID);
            //    file.WriteLine("First name: " + account.FirstName);
            //    file.WriteLine("Last name: " + account.LastName);
            //    file.WriteLine("Balance: " + account.Balance);
            //}

            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFomartter = new BinaryFormatter();
            binaryFomartter.Serialize(fileStream, accountList);
            fileStream.Close();
        }
        public void LoadFile()
        {
            WriteLine("Nhập tên file để đọc:");
            string fileName = ReadLine();
            FileStream fileStream;
            try
            {
                fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            }
            catch(FileNotFoundException)
            {
                WriteLine("File not found");
                return;
            }
            BinaryFormatter binaryFomartter = new BinaryFormatter();
            this.accountList = (ArrayList) binaryFomartter.Deserialize(fileStream);
        }
        public void Report()
        {
            foreach (Account account in accountList)
            {
                account.Show();
                WriteLine("--------------------------");
            }
        }
        public void Remove(Account account)
        {
            accountList.Remove(account);
        }
        public void Sort(IComparer comparer)
        {
            accountList.Sort(comparer);
        }
        public void AccountIDSearch(Account account, IComparer comparer)
        {
            accountList.BinarySearch(account, comparer);
        }
    }
}
