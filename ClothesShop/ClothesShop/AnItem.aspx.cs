using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class clothes : System.Web.UI.Page
{
    Int32 ProductCode;
    protected void Page_load(object sender, EventArgs e)
    {
       
        //copy the data from the query string to the local variable ProductCode
        ProductCode = Convert.ToInt32(Request.QueryString["ProductCode"]);



        if (IsPostBack != true)
        {
            //update the content of the drop down list
            DisplayFabrics();
            if (ProductCode != -1)
            {
                //disaply the data for the product code
                displayItems(Convert.ToInt32(ProductCode));
                
            }
        }
        

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //This lire redirects to the default page
        Response.Redirect("Default.aspx");
    }
    void displayItems(int ProductCode)
    {
        //create an instance of the clothesCollection class
        clsProductCodes myClotheShop = new clsProductCodes();
        //find the item you want to display
        myClotheShop.Find(ProductCode);
        //display the description
        txtDescription.Text = myClotheShop.Description;
        //dispaly the department
        txtDepartment.Text = myClotheShop.Department;
        //display the date when added
        txtDateAdded.Text = myClotheShop.DateWhenAdded.ToString("dd/MM/yyyy");
        //disaply the date when available
        txtAvailability.Text = myClotheShop.Availability.ToString("dd/MM/yyyy");
        //display the type
        ckbType.Checked = myClotheShop.Type;
        //diaply the size
        txtSize.Text = myClotheShop.Size.ToString();
        //display the fabric number
        dplFabricNumber.SelectedValue = Convert.ToString(myClotheShop.FabricCode);
        

    }



    

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //var to store any error messages
        string ErrMsg;


        //create an instance of the class clsClothesCollection called myClothesShop
        clsClothesCollection myClothesShop = new clsClothesCollection();
        ErrMsg = myClothesShop.ThisItems.Valid(txtDescription.Text, txtDateAdded.Text, txtAvailability.Text, txtDepartment.Text, txtSize.Text, Convert.ToString(dplFabricNumber.SelectedIndex));
        lblError.Text = ErrMsg;
        if (ErrMsg == "")
        {

            if (ProductCode == -1)
            {

                //set the property of each field in the table
                myClothesShop.ThisItems.Description = txtDescription.Text;
                myClothesShop.ThisItems.Type = Convert.ToBoolean(ckbType.Checked);
                myClothesShop.ThisItems.DateWhenAdded = Convert.ToDateTime(txtDateAdded.Text);
                myClothesShop.ThisItems.Availability = Convert.ToDateTime(txtAvailability.Text);
                myClothesShop.ThisItems.Department = txtDepartment.Text;
                myClothesShop.ThisItems.Size = Convert.ToInt16(txtSize.Text);
                myClothesShop.ThisItems.FabricCode = Convert.ToInt16(dplFabricNumber.SelectedValue);
                //invoke the add method 
                myClothesShop.Insert();




            }
            else
            {
                //set the property of each field in the table
                myClothesShop.ThisItems.ProductCode = ProductCode;
                myClothesShop.ThisItems.Description = txtDescription.Text;
                myClothesShop.ThisItems.Type = Convert.ToBoolean(ckbType.Checked);
                myClothesShop.ThisItems.DateWhenAdded = Convert.ToDateTime(txtDateAdded.Text);
                myClothesShop.ThisItems.Availability = Convert.ToDateTime(txtAvailability.Text);
                myClothesShop.ThisItems.Department = txtDepartment.Text;
                myClothesShop.ThisItems.Size = Convert.ToInt16(txtSize.Text);
                myClothesShop.ThisItems.FabricCode = Convert.ToInt16(dplFabricNumber.SelectedValue);
                //update the record   
                myClothesShop.Update();
            }

            //redirect to main page when all is done
            Response.Redirect("default.aspx");
        }
    }

    Int32 DisplayFabrics()
    {
        clsFabricCollection Fabrics = new clsFabricCollection();
        //var to store the fabric number primary key
        string FabricNo;
        //var to store the name of the fabric
        string Name;
        //var to store the index of the loop
        Int32 Index = 0;
        while (Index < Fabrics.CountFabrics)
        {
            //get the values for the database
            FabricNo = Convert.ToString(Fabrics.AllFabrics[Index].FabricNo);
            Name = Convert.ToString(Fabrics.AllFabrics[Index].Name);
            ListItem NewFabric = new ListItem(Name, FabricNo);
            dplFabricNumber.Items.Add(NewFabric);

            Index++;
        }
        return Fabrics.CountFabrics;

    }
}