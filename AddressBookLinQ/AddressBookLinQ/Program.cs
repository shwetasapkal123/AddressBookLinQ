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
            Console.WriteLine("1.Create Data Table\t2.Add values in table\t3.Display Values\t4.Edit Contact\t5.Delete person details\t6.Retrieve data using city or state\t7.Count based on city or state\t8.Sort based on name\t9.Add Contact Type column\t10.exit");
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
                    dataTableManager.Display();
                    break;
                case 4:
                    dataTableManager.EditDataTable("Swapnil","FirstName","Shweta");
                        break;
                case 5:
                    dataTableManager.DeleteRowInDataTable("Swagata");
                    break;
                case 6:
                    dataTableManager.RetrieveBasedOnCityorState("Pune", "Maharashtra");
                    break;
                case 7:
                    string res=dataTableManager.RetrieveCountBasedOnCityorState();
                    Console.WriteLine(res);
                    break;
                case 8:
                    string r1=dataTableManager.SortBasedOnCity("Pune");
                    Console.WriteLine(r1);
                    break;
                case 9:
                   string r2= dataTableManager.RetrieveCountBasedOnType();
                    Console.WriteLine(r2);
                    break;
                case 10:
                    flag = false;
                    break;
            }
            Console.ReadLine();
        }
    }
}
