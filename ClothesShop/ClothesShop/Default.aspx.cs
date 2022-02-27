using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayItems("");

        }


    }
    protected void btnDelte_Click(object sender, EventArgs e)
    {
        //var to store the primary key value
        Int32 ProductCode;
        if (lstItems.SelectedIndex != -1)
        {
            //get the priamry key value from the list box
            ProductCode = Convert.ToInt32(lstItems.SelectedValue);
            //This lire redirects to the edit page
            Response.Redirect("Delete.aspx?ProductCode=" + ProductCode);
        }
        else
        {
            //display error message
            lblError.Text = "you must select a value from the list to delete";

        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
       
        //var to store the primary key value
        Int32 ProductCode;
        if (lstItems.SelectedIndex != -1)
        {
            //get the priamry key value from the list box
            ProductCode = Convert.ToInt32(lstItems.SelectedValue);
            //This lire redirects to the edit page
            Response.Redirect("AnItem.aspx?ProductCode=" + ProductCode);
        }
        else
        {
            //display error message
            lblError.Text = "you must select a value from the list to edit";

        }
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //display all products
        DisplayItems("");
    }
    Int32 DisplayItems(string DescriptionFilter)
    {
        // declare the variables
        Int32 ProductCode; //var to store the PK
        string Department; //var to store the department
        string Description; //var to store the description
        Boolean Type; //var to store the type
        //create an instance of the clothes collection class
        clsClothesCollection  ProductList = new clsClothesCollection();
        ProductList.FilterByDescription(DescriptionFilter);
        Int32 RecordCount; //var to store the count of the reords
        Int32 Index = 0; //var to store the index of the loop
        RecordCount = ProductList.Count; //get the count of reords from tblitem table
        lstItems.Items.Clear(); //clear the list box everytime a new fabric is displaied
        while (Index < RecordCount)  //while there are reords to process
        {
            ProductCode = ProductList.ProductList[Index].ProductCode; //get the pk
            Department = ProductList.ProductList[Index].Department; //get the department
            Description = ProductList.ProductList[Index].Description; //get the description
            Type = ProductList.ProductList[Index].Type; //get the type
            string RealType;
            if (Type == false)
            {
                RealType = "New product";
            }
            else
            {
                RealType = "";
            }

            //create a new entry for the list box
            ListItem newEntry =  new ListItem(ProductCode +"; "+ Description +",  "+ RealType,  ProductCode.ToString());
            lstItems.Items.Add(newEntry); //add products to the list
            Index++; //move the index to the next record
        }
        lblItemCount.Text = RecordCount + " records in the database";
        
        return RecordCount; //return the count of the records found
        
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //redirects to the anItem page
        Response.Redirect("AnItem.aspx?ProductCode=-1"); 
    }

    protected void btnFabrics_Click(object sender, EventArgs e)
    {
        Response.Redirect("FabricsOnClothes.aspx");
        
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        DisplayItems(txtProductCode.Text);
    }
}