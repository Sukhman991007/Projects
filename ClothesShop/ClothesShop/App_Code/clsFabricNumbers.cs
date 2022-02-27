using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsFabricNumbers
/// </summary>
public class clsFabricNumbers
{
    public clsFabricNumbers()
    {
        //
        // TODO: Add constructor logic here
        //

    }
    
    //FabricNo private member variable
    private Int16 mFabricNo;
    //FabricNo public property
    public Int16 FabricNo
    {
        get
        {
            //this line of code sends dat out of the property
            return mFabricNo;
        }
        set
        {
            //this line of code allows data into the property
            mFabricNo = value;
        }
    }

    //Origin private member variable
    private String mOrigin;
    //FabricNo public property
    public string Origin
    {
        get
        {
            //this line of code sends dat out of the property
            return mOrigin;
        }
        set
        {
            //this line of code allows data into the property
            mOrigin = value;
        }
    }

    //Quality private member variable
    private Boolean mQuality;
    //FabricNo public property
    public Boolean Quality
    {
        get
        {
            //this line of code sends dat out of the property
            return mQuality;
        }
        set
        {
            //this line of code allows data into the property
            mQuality = value;
        }
    }

    //Composition private member variable
    private String mComposition;
    //FabricNo public property
    public string Composition
    {
        get
        {
            //this line of code sends dat out of the property
            return mComposition;
        }
        set
        {
            //this line of code allows data into the property
            mComposition = value;
        }
    }

    //Description private member variable
    private String mName;
    //FabricNo public property
    public string Name
    {
        get
        {
            //this line of code sends dat out of the property
            return mName;
        }
        set
        {
            //this line of code allows data into the property
            mName = value;
        }
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
    //data member for data connection
    private clsDataConnection dBConnection = new clsDataConnection();
    public Boolean Find(Int16 FabricNo)
    {

        //add the product code as a parameter
        dBConnection.AddParameter("FabricNo", FabricNo);
        //execute the query
        dBConnection.Execute("sproc_tblFabric_FilterByFabricNo");
        if (dBConnection.Count == 1)
        {
            

            mFabricNo = Convert.ToInt16(dBConnection.DataTable.Rows[0]["FabricNo"]);
            mOrigin = Convert.ToString(dBConnection.DataTable.Rows[0]["Origin"]);
            mComposition = Convert.ToString(dBConnection.DataTable.Rows[0]["Composition"]);
            mName = Convert.ToString(dBConnection.DataTable.Rows[0]["Name"]);
            try
            {
                mQuality = Convert.ToBoolean(dBConnection.DataTable.Rows[0]["Quality"]);
            }
            catch
            {
                mQuality = true;
            }
            return true;
        }
        else
        {
            return false;
        }
    }

    public string Valid(string Origin,
                        string Name,
                        string Composition
                        )
     //this function accepts 3 parameters
     //the function returns a string containing any error message
     //if no errors found then a blank string is returned
    {
        //var to store the error message
        string ErrMsg = "";

        //check the min length of the origin
        if (Origin.Length == 0)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Origin is blank. ";
        }
        //check the max length of the origin
        if (Origin.Length > 15)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Composition must be less than 15 characters. ";
        }
        //check the min length of the composition
        if (Composition.Length == 0)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Composition is blank. ";
        }
        //check the max length of the composition
        if (Composition.Length > 50)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Composition must be less than 50 characters. ";
        }
        //check the min length of the name
        if (Composition.Length == 0)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Name is blank. ";
        }
        //check the max length of the Name
        if (Composition.Length > 30)
        {
            //set the error messsage
            ErrMsg = ErrMsg + "Name must be less than 30 characters. ";
        }
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
}