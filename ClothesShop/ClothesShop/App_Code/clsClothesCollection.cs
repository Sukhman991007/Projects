using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsClothesCollection
/// </summary>


public class clsClothesCollection
{
    ///this class contains code allowing us to manipulate items

    //private data members
    //create a null instance of the class clsDataConnection with class level scope
    clsDataConnection dataBaseConnection;
    //private data member for the current items
    clsProductCodes mThisItems = new clsProductCodes();



    clsDataConnection dBConnection = new clsDataConnection();
    public clsClothesCollection()
    {
        //
        // TODO: Add constructor logic here
        //

    }
    

    public clsProductCodes ThisItems
    {
        get
        {
            return mThisItems;
        }
        set
        {
            mThisItems = value;
        }
    }
    public Int32 Update()
    {

        //this public function provides the functionality for the insert method

        //create an instance of the  data connection class called MyDatabase
        clsDataConnection ExistingDBItem = new clsDataConnection();
        //add the item parameter passed to this function to the list of parameters to use int the database
        ExistingDBItem.AddParameter("@ProductCode", mThisItems.ProductCode);
        ExistingDBItem.AddParameter("@Description", mThisItems.Description);
        ExistingDBItem.AddParameter("@DateWhenAdded", mThisItems.DateWhenAdded);
        ExistingDBItem.AddParameter("@type", mThisItems.Type);
        ExistingDBItem.AddParameter("@Availability", mThisItems.Availability);
        ExistingDBItem.AddParameter("@Department", mThisItems.Department);
        ExistingDBItem.AddParameter("@Size", mThisItems.Size);
        ExistingDBItem.AddParameter("@FabricNo", mThisItems.FabricCode);

        //execute the stored procedure in the database returing the primary key
        return ExistingDBItem.Execute("sproc_tblItem_update");
    }
    public Int32 Insert()
    {

        //this public function provides the functionality for the insert method
        Int32 primaryKey;
        //create an instance of the  data connection class called MyDatabase
        clsDataConnection NewDBItem = new clsDataConnection();
        //add the item parameter passed to this function to the list of parameters to use int the database
        NewDBItem.AddParameter("@Description", mThisItems.Description);
        NewDBItem.AddParameter("@DateWhenAdded", mThisItems.DateWhenAdded);
        NewDBItem.AddParameter("@type", mThisItems.Type);
        NewDBItem.AddParameter("@Availability", mThisItems.Availability);
        NewDBItem.AddParameter("@Department", mThisItems.Department);
        NewDBItem.AddParameter("@Size", mThisItems.Size);
        NewDBItem.AddParameter("@FabricNo", mThisItems.FabricCode);

        //execute the stored procedure in the database returing the primary key
        primaryKey = NewDBItem.Execute("sproc_tblItem_Insert");
        return primaryKey;

    }
    public Boolean Delete()
    {
        try //try to delete the record
        {
            //this public function provides the functionality for the delete method

            //create an instance of the  data connection class called MyDatabase
            clsDataConnection MyProductCode = new clsDataConnection();
            //add the item parameter passed to this function to the list of parameters to use int th database
            MyProductCode.AddParameter("@ProductCode", mThisItems.ProductCode);
            //execute the stored procedure in the database
            MyProductCode.Execute("sproc_ItemNo_Delete");

            return true;
        }


        catch
        {
            return false;
        }
    }

    public List<clsProductCodes> ProductList
    {
        get
        {
            //create an array list of type clsProductcode
            List<clsProductCodes> mProductCodes = new List<clsProductCodes>();
            //var to store thecount of the records
            Int32 RecordCount;
            //var to store the index of the loop
            Int32 Index = 0;
          /* dBConnection = new clsDataConnection();
            //send a descpription filter to the query
            dBConnection.AddParameter("@Description", "");
            //execute the query
            dBConnection.Execute("sproc_tblItem_FilterByDescription"); */
            //get the count of the records
            RecordCount = dBConnection.Count;
            //keep looping unitll all record have been processed 
            while (Index < RecordCount)
            {
                //create a blank item page
                clsProductCodes NewProductCodes = new clsProductCodes();
                //copy the data from the table to the RAM
                NewProductCodes.ProductCode = Convert.ToInt32(dBConnection.DataTable.Rows[Index]["ProductCode"]);
                NewProductCodes.Description = Convert.ToString(dBConnection.DataTable.Rows[Index]["Description"]);
                NewProductCodes.DateWhenAdded = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["DatewhenAdded"]);
                NewProductCodes.Type = Convert.ToBoolean(dBConnection.DataTable.Rows[Index]["type"]);
                NewProductCodes.Availability = Convert.ToDateTime(dBConnection.DataTable.Rows[Index]["Availability"]);
                NewProductCodes.Department = Convert.ToString(dBConnection.DataTable.Rows[Index]["Department"]);
                NewProductCodes.Size = Convert.ToInt16(dBConnection.DataTable.Rows[Index]["Size"]);
                //add the blank page to the array list
                mProductCodes.Add(NewProductCodes);
                //increse the index
                Index++;
            }
            return mProductCodes;
        }

    }
    public void FilterByDescription(string Description)
    {
        //initialize the database connection
        dBConnection = new clsDataConnection();
        //send a description to the query
        dBConnection.AddParameter("@Description", Description);
        //execute the query
        dBConnection.Execute("sproc_tblItem_FilterByDescription");

    }
    public Int32 Count
    //public read only property for the count of records found
    {
        get
        {
           
            //return the count of records
            return dBConnection.Count;
        }
    }
}
   
