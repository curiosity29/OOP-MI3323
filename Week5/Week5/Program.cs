using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using static System.Console;
namespace Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }
        Program()
        {
            OutputEncoding = System.Text.Encoding.Unicode;

            //Bài 1 và 2 - quản lý book, bookList:
            //Bai_1_2();

            //bài 3 và 4:
            Bai_3_4();
        }
        void Bai_3_4()
        {
            string command;
            AccountList accountList = new AccountList();
            //Guide
            WriteLine("Quản lý account: ");
            string[] control_list = { "add", "save", "load", "report", "exit", "sort" };
            WriteLine("command list: ");
            foreach(string control in control_list)
            {
                WriteLine(control);
            }
            //
            WriteLine("Input your command: ");
            do
            {
                command = ReadLine();
                switch(command)
                {
                    case "add": accountList.NewAccount();
                        WriteLine("done, next command:");
                        break;
                    case "save": accountList.SaveFile();
                        WriteLine("done, next command:");
                        break;
                    case "load": accountList.LoadFile();
                        WriteLine("done, next command:");
                        break;
                    case "report": accountList.Report();
                        WriteLine("done, next command:");
                        break;
                    case "sort": WriteLine("sort by 'ID' or 'name' or 'balance'?: ");
                        command = ReadLine();
                        switch(command)
                        {
                            case "ID": accountList.Sort(new IDCompare());
                                break;
                            case "name": accountList.Sort(new FirstNameCompare());
                                break;
                            case "balance": accountList.Sort(new BalanceCompare());
                                break;
                            default: WriteLine("unrecognized");
                                break;
                        }
                        WriteLine("done, next command:");
                        break;
                    default: WriteLine("unrecognized command");
                        break;
                }
            } while (command != "exit");

            WriteLine("--------exited-----------");
        }

        void Bai_1_2()
        {
            BookList bookList = new BookList();
            WriteLine("Nhập vào danh sách các cuốn sách");
            bookList.InputList();
            bookList.Sort(new NameComparer());
            WriteLine("sorted by name: ");
            bookList.ShowList();
        }
    }



}