using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for cltProductCode
/// </summary>
public class clsProductCodes
{
    public clsProductCodes()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    

    //productCode private member variable
    private Int32 mProductCode;
    //ProductCode public property
    public Int32 ProductCode
    {
        get
        {
            //this line of code sends dat out of the property
            return mProductCode;
        }
        set
        {
            //this line of code allows data into the property
            mProductCode = value;
        }
    }
    //size private member variable
    private Int16 mSize;
    //Size public property
    public Int16 Size
    {
        get
        {
            //this line of code sends data out to the property
            return mSize;
        }
        set
        {
            //this line of code allows data in to the propery
            mSize = value;
        }
    }
    //Description prvate member variable 
    private string mDescription;
    //Description public property
    public string Description
    {
        get
        {
            //this line of code sends data out of the property
            return mDescription;
        }
        set
        {
            //this line of code allows data into the property 
            mDescription = value;
        }
    }
    //DateWhenAdded private member variable
    private DateTime mDateWhenAdded;
    //DateWhenAdded public property
    public DateTime DateWhenAdded
    {
        get
        {
            //this line of code sends data out of the property
            return mDateWhenAdded;

        }
        set
        {
            //this line of code allows data in to the property
            mDateWhenAdded = value;
        }

    }
    //DateWhenAdded private member variable
    private Boolean mType;
    //DateWhenAdded public property
    public Boolean Type
    {
        get
        {
            //this line of code sends data out of the property
            return mType;

        }
        set
        {
            //this line of code allows data in to the property
            mType = value;
        }

    }
    //DateWhenAdded private member variable
    private DateTime mAvailability;
    //DateWhenAdded public property
    public DateTime Availability
    {
        get
        {
            //this line of code sends data out of the property
            return mAvailability;

        }
        set
        {
            //this line of code allows data in to the property
            mAvailability = value;
        }

    }
    //DateWhenAdded private member variable
    private string mDepartment;
    //DateWhenAdded public property
    public string Department
    {
        get
        {
            //this line of code sends data out of the property
            return mDepartment;

        }
        set
        {
            //this line of code allows data in to the property
            mDepartment = value;
        }

    }

    //FabricNo private member variable
    private Int16 mFabricCode;
    //FabricNo public property
    public Int16 FabricCode
    {
        get
        {
            //this line of code sends data out of the property
            return mFabricCode;

        }
        set
        {
            //this line of code allows data in to the property
            mFabricCode = value;
        }

    }
    public string Valid(string Description,
                        string DateWhenAdded,
                        string Availability,
                        string Department,
                        string Size, 
                        string FabricNo
                        )
     //this function accepts 5 parameters for validation
     //the function returns a string containing any error message
     //if no errors found then a blank string is returned
    {
        
        //var to store the error message
        string ErrMsg = ""; 
        //check the fabric nubmer is selected from the list box
        if(FabricNo == Convert.ToString(-1))
        {
            //set the error message
            ErrMsg = ErrMsg + "select fabric number from the list";
        }

        //check size is not blank
        if(Size.Length == 0)
        {
            //set the error message
            ErrMsg = ErrMsg + "Size is blank.";
        }
        if(Size.Length > 2 )
        {
            ErrMsg = ErrMsg + "Size is not valid.";
        }
        //check the min length of the Description
        if (Description.Length == 0)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Description is blank. ";
        }
        //check the max length of the Description
        if (Description.Length > 30)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Description must be less than 30 characters. ";
        }


        if (Department.Length == 0)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Department is blank. ";
        }
        //check the max length for the Department
        if (Department.Length > 20)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Department must be less than 20 characters. ";
        }
       //test if the date(Datewhenadded) is valid
       try//try the operation
        {
            //var to store the date
            DateTime Temp01;
            Temp01 = Convert.ToDateTime(DateWhenAdded);
        }
        catch// if failed to report an error
        {
            ErrMsg = ErrMsg = "DateWHenAdded is not valid.";
        } 
        //test if the date(Availability) is valid
        try//try the operation
        {
            //var to store the date
            DateTime Temp;
            //assign the date to the temporary var
            Temp = Convert.ToDateTime(Availability);
            



        }
        catch//if it failed to report an error
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Availabilty is not valid. ";
        }
        //if there were no errors
        if (ErrMsg == "")
        {
            //return a blank string
            return "";
        }
        else//otherwise
        {
            //return the errors string value
            return "There were the following errors : " + ErrMsg;
        }
    }
    //data member for data connection
    private clsDataConnection dBConnection = new clsDataConnection();
    public Boolean Find(Int32 ProductCode)
    {
       
        //add the product code as a parameter
        dBConnection.AddParameter("ProductCode", ProductCode);
        //execute the query
        dBConnection.Execute("sproc_tblItem_FilterByProductCode");
        if (dBConnection.Count == 1)
        {

            mProductCode = Convert.ToInt32(dBConnection.DataTable.Rows[0]["ProductCode"]);
            mDescription = Convert.ToString(dBConnection.DataTable.Rows[0]["Description"]);
            mDateWhenAdded = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["DatewhenAdded"]);
            mAvailability = Convert.ToDateTime(dBConnection.DataTable.Rows[0]["Availability"]);
            mDepartment = Convert.ToString(dBConnection.DataTable.Rows[0]["Department"]);
            mSize = Convert.ToInt16(dBConnection.DataTable.Rows[0]["Size"]);
            mFabricCode = Convert.ToInt16(dBConnection.DataTable.Rows[0]["FabricNo"]);
            try
            {
                mType = Convert.ToBoolean(dBConnection.DataTable.Rows[0]["type"]);
            }
            catch
            {
                mType = true;
            }
            return true;
        }
        else
        {
            return false;
        }
    }
}
