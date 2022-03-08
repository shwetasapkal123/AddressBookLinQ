using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WEL-COME to LinQ of AddressBook");
            bool flag = true;
            DataTableManager dataTableManager = new DataTableManager();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1.Create Data Table\t2.Add values in table\t3.exit");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    dataTableManager.CreateDataTable();
                    Console.WriteLine("Created Table Successfully!!!");
                    break;
                case 2:
                    dataTableManager.AddValues();
                    Console.WriteLine("Values Added Succesfully!!!!");
                    break;
                case 3:
                    flag = false;
                    break;
            }
            Console.ReadLine();
        }
    }
}
