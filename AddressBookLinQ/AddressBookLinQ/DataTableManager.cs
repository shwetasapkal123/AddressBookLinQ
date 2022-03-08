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

            Console.WriteLine("Created Table Successfully!!!");
        }
        //Insert Values in Datatable        

    }
}
