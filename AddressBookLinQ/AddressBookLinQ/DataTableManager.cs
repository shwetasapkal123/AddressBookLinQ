using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinQ
{
    public class DataTableManager
    {
       public static DataTable dataTable;
        public void CreateDataTable()
        {
            dataTable = new DataTable("AddressBookSystemLinQ");
            DataColumn dataColumn;
            //Creating addressBookId column
            dataColumn=new DataColumn();
            dataColumn.DataType=typeof(int);
            dataColumn.ColumnName="ID";
            dataColumn.Caption = "Address Book Id";
            dataColumn.AutoIncrement = true;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = true;
            // Add column to the DataColumnCollection.  
            dataTable.Columns.Add(dataColumn);

            // Create First Name column.    
            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(String);
            dataColumn.ColumnName = "FirstName";
            dataColumn.Caption = "First Name";
            dataColumn.AutoIncrement = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            /// Add column to the DataColumnCollection.  
            dataTable.Columns.Add(dataColumn);

            // Create Last Name column.    
            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(String);
            dataColumn.ColumnName = "LastName";
            dataColumn.Caption = "Last Name";
            dataColumn.AutoIncrement = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            /// Add column to the DataColumnCollection.  
            dataTable.Columns.Add(dataColumn);

            // Create Address column.    
            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(String);
            dataColumn.ColumnName = "Address";
            dataColumn.Caption = "Address";
            dataColumn.AutoIncrement = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            /// Add column to the DataColumnCollection.  
            dataTable.Columns.Add(dataColumn);

            // Create city column.    
            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(String);
            dataColumn.ColumnName = "City";
            dataColumn.Caption = "City";
            dataColumn.AutoIncrement = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            /// Add column to the DataColumnCollection.  
            dataTable.Columns.Add(dataColumn);

            // Create State column.    
            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(String);
            dataColumn.ColumnName = "State";
            dataColumn.Caption = "State";
            dataColumn.AutoIncrement = false;
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            /// Add column to the DataColumnCollection.  
            dataTable.Columns.Add(dataColumn);

            // Create Email column.    
            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(String);
            dataColumn.ColumnName = "Email";
            dataColumn.Caption = "Email";
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            // Add column to the DataColumnCollection.    
            dataTable.Columns.Add(dataColumn);

            // Create PhoneNumber column.    
            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(Int64);
            dataColumn.ColumnName = "PhoneNumber";
            dataColumn.Caption = "PhoneNumber";
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            // Add column to the DataColumnCollection.    
            dataTable.Columns.Add(dataColumn);

            // Create zip column.    
            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(Int64);
            dataColumn.ColumnName = "Zip";
            dataColumn.Caption = "Zip";
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            // Add column to the DataColumnCollection.    
            dataTable.Columns.Add(dataColumn);

            //create contact type
            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(string);
            dataColumn.ColumnName = "ContactType";
            dataColumn.Caption = "ContactType";
            //Adding column to the DataColumnCollection.  
            dataTable.Columns.Add(dataColumn);
        }
        //Insert Values in Datatable        
        public int AddValues()
        {
            CreateDataTable();
            //Create Object for DataTable
            DataManager contactDataManager = new DataManager();
            //Insert Values into Table
            contactDataManager.FirstName = "Snehal";
            contactDataManager.LastName = "Jagtap";
            contactDataManager.PhoneNumber = 9842905050;
            contactDataManager.Email = "snehal@gmail.com";
            contactDataManager.Address = "Chinchwad";
            contactDataManager.City = "Pune";
            contactDataManager.State = "Maharashtra";
            contactDataManager.zip = 600072;
            contactDataManager.ContactType = "Family";
            InsertintoDataTable(contactDataManager);

            //Insert Values into Table
            contactDataManager.FirstName = "Swagata";
            contactDataManager.LastName = "Sawant";
            contactDataManager.PhoneNumber = 7742905050;
            contactDataManager.Email = "swagata@gmail.com";
            contactDataManager.Address = "Marathahalli";
            contactDataManager.City = "Benglore";
            contactDataManager.State = "Karnataka";
            contactDataManager.zip = 123001;
            contactDataManager.ContactType = "Friend";
            InsertintoDataTable(contactDataManager);

            contactDataManager.FirstName = "Swapnil";
            contactDataManager.LastName = "Sapkal";
            contactDataManager.PhoneNumber = 7742905050;
            contactDataManager.Email = "swapnil@gmail.com";
            contactDataManager.Address = "pimpri";
            contactDataManager.City = "Pune";
            contactDataManager.State = "Maharashtra";
            contactDataManager.zip = 123001;
            contactDataManager.ContactType = "Family";
            InsertintoDataTable(contactDataManager);
            
            // UC11-Adding person to both ContactType
            contactDataManager.FirstName = "Swapnil";
            contactDataManager.LastName = "Sapkal";
            contactDataManager.PhoneNumber = 7742905050;
            contactDataManager.Email = "swapnil@gmail.com";
            contactDataManager.Address = "pimpri";
            contactDataManager.City = "Pune";
            contactDataManager.State = "Maharashtra";
            contactDataManager.zip = 123001;
            contactDataManager.ContactType = "Friends";
            InsertintoDataTable(contactDataManager);
            return dataTable.Rows.Count;
        }
        //Insert values in Data Table
        public void InsertintoDataTable(DataManager contactDataManager)
        {
            DataRow dtRow = dataTable.NewRow();
            dtRow["FirstName"] = contactDataManager.FirstName;
            dtRow["LastName"] = contactDataManager.LastName;
            dtRow["Address"] = contactDataManager.Address;
            dtRow["City"] = contactDataManager.City;
            dtRow["State"] = contactDataManager.State;
            dtRow["Zip"] = contactDataManager.zip;
            dtRow["PhoneNumber"] = contactDataManager.PhoneNumber;
            dtRow["Email"] = contactDataManager.Email;
            dtRow["ContactType"] = contactDataManager.ContactType;
            dataTable.Rows.Add(dtRow);
        }
        //Display all Values in DataRow
        public void Display()
        {
            foreach (DataRow dtRows in dataTable.Rows)
            {
                Console.WriteLine("{0} \n {1} \n {2} \n {3} \n {4} \n {5} \n {6} \n {7}\n {8}\n", dtRows["FirstName"], dtRows["LastName"], dtRows["Address"], dtRows["City"], dtRows["State"], dtRows["Zip"], dtRows["PhoneNumber"], dtRows["Email"],dtRows["ContactType"]);
            }
        }
        public int EditDataTable(string FirstName, string ColumnName,string ColumnValue)
        {
            AddValues();
            var modifiedList = (from ContactList in dataTable.AsEnumerable() where ContactList.Field<string>("FirstName") == FirstName select ContactList).FirstOrDefault();
            if (modifiedList != null)
            {
                modifiedList[ColumnName] = ColumnValue;
                Display();
                return 1;
            }
            else return 0;
        }

        //UC-5-Delete a person from DataTable based on Name
        public int DeleteRowInDataTable(string FirstName)
        {
            AddValues();
            var modifiedList = (from ContactList in dataTable.AsEnumerable() where ContactList.Field<string>("FirstName") == FirstName select ContactList).FirstOrDefault();
            if (modifiedList != null)
            {
                modifiedList.Delete();
                Console.WriteLine("--- After Deletion ---");
                Display();
                return 1;
            }
            else return 0;
        }
        //UC6-Retrieve values from DataTable based on City or State
        public string RetrieveBasedOnCityorState(string City, string State)
        {
            AddValues();
            string nameList = "";
            var modifiedList = (from ContactList in dataTable.AsEnumerable() where (ContactList.Field<string>("State") == State || ContactList.Field<string>("City") == City) select ContactList);
            foreach (var dtRows in modifiedList)
            {
                nameList += dtRows["FirstName"] + " ";
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6} \t {7} \t {8}\n", dtRows["ID"], dtRows["FirstName"], dtRows["LastName"], dtRows["Address"], dtRows["City"], dtRows["State"], dtRows["Zip"], dtRows["PhoneNumber"], dtRows["Email"]);
            }
            return nameList;
        }
        //UC7-Retrieve Count values from DataTable based on City or State
        public string RetrieveCountBasedOnCityorState()
        {
            AddValues();
            string result = "";
            var modifiedList = (from ContactList in dataTable.AsEnumerable().GroupBy(r => new { Col1 = r["City"], Col2 = r["State"] }) select ContactList);
            Console.WriteLine("Äfter count");
            foreach (var j in modifiedList)
            {
                result += j.Count() + " ";
                Console.WriteLine("Count Key" + j.Key);
                foreach (var dtRows in j)
                {
                    Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6} \t {7} \t {8}\n", dtRows["ID"], dtRows["FirstName"], dtRows["LastName"], dtRows["Address"], dtRows["City"], dtRows["State"], dtRows["Zip"], dtRows["PhoneNumber"], dtRows["Email"]);
                }
            }
            return result;
        }
        //Sort based on City
        public string SortBasedOnCity(string City)
        {
            AddValues();
            string result = "";
            var modifiedList = (from ContactList in dataTable.AsEnumerable() orderby ContactList.Field<string>("FirstName") where ContactList.Field<string>("City") == City select ContactList);
            Console.WriteLine("After sorting");
            foreach (var dtRows in modifiedList)
            {
                result += dtRows["FirstName"] + " ";
                Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6} \t {7} \t {8}\n", dtRows["ID"], dtRows["FirstName"], dtRows["LastName"], dtRows["Address"], dtRows["City"], dtRows["State"], dtRows["Zip"], dtRows["PhoneNumber"], dtRows["Email"]);

            }
            return result;
        }
        //Uc10-Retrieve count based on contact type
        public string RetrieveCountBasedOnType()
        {
            AddValues();
            string result = "";
            var modifiedList = (from ContactList in dataTable.AsEnumerable().GroupBy(r => new { Col1 = r["ContactType"] }) select ContactList);
            Console.WriteLine("Äfter count");
            foreach (var j in modifiedList)
            {
                result += j.Count() + " ";
                Console.WriteLine("Count Key" + j.Key);
                foreach (var dtRows in j)
                {
                    Console.WriteLine("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6} \t {7} \t {8} \t {9}\n", dtRows["ID"], dtRows["FirstName"], dtRows["LastName"], dtRows["Address"], dtRows["City"], dtRows["State"], dtRows["Zip"], dtRows["PhoneNumber"], dtRows["Email"], dtRows["ContactType"]);
                }
            }
            return result;
        }
    }
}
