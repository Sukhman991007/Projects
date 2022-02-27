using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AFabric : System.Web.UI.Page
{
    Int16 FabricNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //copy the data from the query string to the local variable ProductCode
        FabricNo = Convert.ToInt16(Request.QueryString["FabricNo"]);

        if (FabricNo != -1)
        {
            if (IsPostBack != true)
            {
                //disaply the data for the product code
                DisplayFabrics(Convert.ToInt16(FabricNo));
            }
        }
        
        
    }
    void DisplayFabrics(Int16 FabricNo)
    {
        //create an instance of the clothesCollection class
        clsFabricNumbers myFabrics = new clsFabricNumbers();
        //find the fabric you want to display
        myFabrics.Find(FabricNo);
        //display the name
        txtName.Text = myFabrics.Name;
        //dispaly the origin
        txtOrigin.Text = myFabrics.Origin;
        
        //display the quality
        if (myFabrics.Quality == true)
        {
            rdbBasic.Checked = true;
            
            
        }
        else
        {
            
            rdbPremium.Checked = true;
            
        }
        //disaply the composition
        txtComposition.Text = myFabrics.Composition;
        
    }
    protected void btnCancell_Click(object sender, EventArgs e)
    {
        Response.Redirect("FabricsOnClothes.aspx");
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //var to store any error messages
        string ErrMsg;
        clsFabricCollection myFabrics = new clsFabricCollection();
        ErrMsg = myFabrics.ThisFabrics.Valid(txtComposition.Text, txtName.Text, txtOrigin.Text);
        lblError.Text = ErrMsg;
        if (ErrMsg == "")
        {
            if (FabricNo == -1)
            {

                //set the property of each field in the table
                myFabrics.ThisFabrics.Name = txtName.Text;
                myFabrics.ThisFabrics.Origin = txtOrigin.Text;
                myFabrics.ThisFabrics.Quality = Convert.ToBoolean(rdbPremium.Checked);
                myFabrics.ThisFabrics.Composition = txtComposition.Text;
                //invoke the add method 
                myFabrics.Insert();


            }
            else
            {
                //set the property of each field in the table
                myFabrics.ThisFabrics.FabricNo = FabricNo;
                myFabrics.ThisFabrics.Name = txtName.Text;
                myFabrics.ThisFabrics.Origin = txtOrigin.Text;
                myFabrics.ThisFabrics.Quality = Convert.ToBoolean(rdbPremium.Checked);
                myFabrics.ThisFabrics.Composition = txtComposition.Text;
                //update the record   
                myFabrics.Update();
            }

            //redirect to main page when all is done
            Response.Redirect("FabricsOnClothes.aspx");
        }
    }
}