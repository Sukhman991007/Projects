using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for FabricCollection
/// </summary>
public class clsFabricCollection
{
    //private data members
    //create a null instance of the class clsDataConnection with class level scope
    clsDataConnection dBConnection;
    //private data member for the current fabrics
    clsFabricNumbers mThisFabrics = new clsFabricNumbers();

    public clsFabricNumbers ThisFabrics
    {
        get
        {
            return mThisFabrics;
        }
        set
        {
            mThisFabrics = value;
        }
    }
    clsDataConnection DataBaseConnection = new clsDataConnection();
    public clsFabricCollection()
    {
        //execute the select fabric
        DataBaseConnection.Execute("sproc_tblFabric_selectFabric");
    }
    public Int32 CountFabrics
    {
        get
        {
            //retunr the count of the data from the database
            return DataBaseConnection.Count;
        }
    }
    //this read only function exposes the query results collection
    public List<clsFabricNumbers> AllFabrics
    {
        get
        {
            //create and= instance of a lsit called mAllFabics
            List<clsFabricNumbers> mAllFabrics = new List<clsFabricNumbers>();
            //var to store the index of the loop
            Int32 Index = 0;
            while (Index < DataBaseConnection.Count)
            {
                clsFabricNumbers NewFabric = new clsFabricNumbers();
                //get the values number from the database
                NewFabric.FabricNo = Convert.ToInt16(DataBaseConnection.DataTable.Rows[Index]["FabricNo"]);
                NewFabric.Name = Convert.ToString(DataBaseConnection.DataTable.Rows[Index]["Name"]);
                //add fabrics to the list
                mAllFabrics.Add(NewFabric);
                //increment the index
                Index++;
            }
            //return the query result form the database
            return mAllFabrics;
        }
    }
    public List<clsFabricNumbers> FabricList
    {
        
        get
        {
            //create an array list of type clsFabricList
            List<clsFabricNumbers> mFabricNumbers = new List<clsFabricNumbers>();
            //var to store thecount of the records
            Int32 RecordCount;
            //var to store the index of the loop
            Int32 Index = 0;
            //create a connection to the database
            clsDataConnection dBConnection = new clsDataConnection();
            //send a descpription filter to the query
            dBConnection.AddParameter("@Name", "");
            //execute the query
            dBConnection.Execute("sproc_tblFabric_filterByFabricName");
            //get the count of the records
            RecordCount = dBConnection.Count;
            //keep looping unitll all record have been processed 
            while (Index < RecordCount)
            {
                //create a blank item page
                clsFabricNumbers NewFabricNumbers = new clsFabricNumbers();
                //copy the data from the table to the RAM
                NewFabricNumbers.FabricNo = Convert.ToInt16(dBConnection.DataTable.Rows[Index]["FabricNo"]);
                NewFabricNumbers.Origin = Convert.ToString(dBConnection.DataTable.Rows[Index]["Origin"]);
                NewFabricNumbers.Quality = Convert.ToBoolean(dBConnection.DataTable.Rows[Index]["Quality"]);
                NewFabricNumbers.Composition = Convert.ToString(dBConnection.DataTable.Rows[Index]["Composition"]);
                NewFabricNumbers.Name = Convert.ToString(dBConnection.DataTable.Rows[Index]["Name"]);

                //add the blank page to the array list
                mFabricNumbers.Add(NewFabricNumbers);
                //increse th index
                Index++;
            }
            return mFabricNumbers;
        }

    }


    public List<clsFabricNumbers> FabricProductList
    {
        get
        {
            //create an array list of type clsProductcode
            List<clsFabricNumbers> mProductCodes = new List<clsFabricNumbers>();
            //var to store thecount of the records
            Int32 RecordCount;
            //var to store the index of the loop
            Int32 Index = 0;
           /* //create a connection to the database
            clsDataConnection dBConnection01 = new clsDataConnection();
            //send a descpription filter to the query
            dBConnection01.AddParameter("@FabricNo", "");
            //execute the query
            dBConnection01.Execute("sproc_tblFabric_findItemsWhereFabricIsUsed"); */
            //get the count of the records
            RecordCount = DataBaseConnection.Count;
            //keep looping unitll all record have been processed 
            while (Index < RecordCount)
            {
                //create a blank item page
                clsFabricNumbers ProductCodes = new clsFabricNumbers();
                //copy the data from the table to the RAM
                ProductCodes.ProductCode = Convert.ToInt32(DataBaseConnection.DataTable.Rows[Index]["ProductCode"]);
                ProductCodes.Description = Convert.ToString(DataBaseConnection.DataTable.Rows[Index]["Description"]);
                ProductCodes.Department = Convert.ToString(DataBaseConnection.DataTable.Rows[Index]["Department"]);

                //add the blank page to the array list
                mProductCodes.Add(ProductCodes);
                //increse th index
                Index++;
            }
            return mProductCodes;
        }

    }
    public void FilterByFabric(string FabricNo)
    {
        DataBaseConnection = new clsDataConnection();
        //add parameter
        DataBaseConnection.AddParameter("@FabricNo",FabricNo );
        //execute the query
        DataBaseConnection.Execute("sproc_tblFabric_findItemsWhereFabricIsUsed");
    }
    public Int32 Count
    //public read only property for the count of records found
    {
        get
        {
          
            //return the count of records
            return DataBaseConnection.Count;
        }
    }
    //function to add a new fabric to the database
    public Int32 Insert()
    {
        Int32 PrimaryKey;
        clsDataConnection NewFabric = new clsDataConnection();

        NewFabric.AddParameter("@Origin", ThisFabrics.Origin);
        NewFabric.AddParameter("@Quality", ThisFabrics.Quality);
        NewFabric.AddParameter("@Composition", ThisFabrics.Composition);
        NewFabric.AddParameter("@Name", ThisFabrics.Name);

        PrimaryKey = NewFabric.Execute("sproc_tblfabric_Insert");

        return PrimaryKey;

    }
    public Int32 Update()
    {
        clsDataConnection ExistingFabric = new clsDataConnection();

        ExistingFabric.AddParameter("@FabricNo", ThisFabrics.FabricNo);
        ExistingFabric.AddParameter("@Origin", ThisFabrics.Origin);
        ExistingFabric.AddParameter("@Quality", ThisFabrics.Quality);
        ExistingFabric.AddParameter("@Composition", ThisFabrics.Composition);
        ExistingFabric.AddParameter("@Name", ThisFabrics.Name);

        return ExistingFabric.Execute("sproc_tblfabric_update");
    }

    public Boolean Delete()
    {
        try //try to delete the record
        {
            //this public function provides the functionality for the delete method

            //create an instance of the  data connection class called MyDatabase
            clsDataConnection MyFabricNo = new clsDataConnection();
            //add the item parameter passed to this function to the list of parameters to use int th database
            MyFabricNo.AddParameter("@FabricNo", ThisFabrics.FabricNo);
            //execute the stored procedure in the database
            MyFabricNo.Execute("sproc_fabricNo_Delete");

            return true;
        }


        catch
        {
            return false;
        }
    }

}