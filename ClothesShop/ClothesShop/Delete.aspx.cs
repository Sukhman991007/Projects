using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        //copy the data from the query string to the textbox txtProductCode
        Int32 Numbers = Convert.ToInt32(Request.QueryString["ProductCode"]);
        Int32 ValueToDelete;
        if (Numbers > 100)
        {
            lblQuestion.Text = "Do you want delete the following item?";
            ValueToDelete = Convert.ToInt32(Request.QueryString["ProductCode"]);

        }
        else
        {

            lblQuestion.Text = "Do you want to delete the following Fabric?";
            ValueToDelete = Convert.ToInt32(Request.QueryString["FabricNo"]);
        }


    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //copy the data from the query string to the variable
        Int32 Numbers = Convert.ToInt32(Request.QueryString["ProductCode"]);
        Int32 ValueToDelete;
        if (Numbers > 100)
        {
            ValueToDelete = Convert.ToInt32(Request.QueryString["ProductCode"]);

        }
        else
        {

            ValueToDelete = Convert.ToInt32(Request.QueryString["FabricNo"]);
        }
        if (ValueToDelete > 100)
        {

            //create an instance of the class clsClothesCollection called myClothesShop
            clsClothesCollection myItem = new clsClothesCollection();
            //declare a variable to store the item number to delete
            Int32 ProductNo;
            //decalre a boolean variable to record the success of the delete operation
            Boolean Found;
            //copy the data from the interface to the RAM converting the data in to Int32
            ProductNo = Convert.ToInt32(ValueToDelete);
            //invoce the delete method of the object passing it the data entered by the user
            Found = myItem.ThisItems.Find(ProductNo);
            //use the assignment operator to copy the data rom the interface to the RAM converting the data type in to an int
            if (Found)
            {
                myItem.Delete();
                lblError.Text = "You deleted record number" + ProductNo;

            }
            else //display error message
            {
                //display a meesage concateing the text and data in the variable
                lblError.Text = "There was a problem deleting the record.";
            }
        }
        else
        {
            //create an instance of the class clsClothesCollection called myClothesShop
            clsFabricCollection myFabric = new clsFabricCollection();
            //declare a variable to store the item number to delete
            Int16 FabricNo;
            //decalre a boolean variable to record the success of the delete operation
            Boolean Found;
            //copy the data from the interface to the RAM converting the data in to Int32
            FabricNo = Convert.ToInt16(ValueToDelete);
            //invoce the delete method of the object passing it the data entered by the user
            Found = myFabric.ThisFabrics.Find(FabricNo);
            //use the assignment operator to copy the data rom the interface to the RAM converting the data type in to an int
            if (Found)
            {
                myFabric.Delete();
                lblError.Text = "You deleted fabric number " + FabricNo;

            }
            else //display error message
            {
                //display a meesage concateing the text and data in the variable
                lblError.Text = "There was a problem deleting the fabric.";
            }
        }
    }
    protected void btnNo_Click(object sender, EventArgs e)
    {
        Int32 Numbers = Convert.ToInt32(Request.QueryString["ProductCode"]);
        if (Numbers > 100)
        {
            //This lire redirects to the default page
            Response.Redirect("Default.aspx");

        }
        else
        {
            Response.Redirect("FabricsOnClothes.aspx");
        }
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {

        Response.Redirect("Default.aspx");
    }
    
    


    
    

}