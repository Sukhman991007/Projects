using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Fabrics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
   
    }

   
    

    protected void BtnSearch_Click(object sender, EventArgs e)
    {
        DisplayProducts();
    }
    Int32 DisplayProducts()
    {
        // declare the variables
        Int32 ProductCode; //var to store the PK
        string Department; //var to store the department
        string Description; //var to store the description

        //create an instance of the clothes collection class
        clsFabricCollection FabricItemtList = new clsFabricCollection();

        Int32 RecordCount; //var to store the count of the reords
        Int32 Index = 0; //var to store the index of the loop
        RecordCount = FabricItemtList.Count; //get the count of reords from tblitem table
        lstItems.Items.Clear();
        while (Index < RecordCount)  //while there are reords to process
        {
            ProductCode = FabricItemtList.FabricProductList[Index].ProductCode; //get the pk
            Department = FabricItemtList.FabricProductList[Index].Department; //get the department
            Description = FabricItemtList.FabricProductList[Index].Description; //get the description


            //create a new entry for the list box
            ListItem newEntry = new ListItem(ProductCode + "; " + Description + ";  " + Department, ProductCode.ToString());
            lstItems.Items.Add(newEntry); //add products to the list
            Index++; //move the index to the next record
        }
        lblItemCount.Text = RecordCount + " Clothes using this fabric";
        return RecordCount; //return the count of the records found

    }


    protected void btnDisplayFabrics_Click(object sender, EventArgs e)
    {
        DisplayFabrics();
    }

    Int32 DisplayFabrics()
    {
        // declare the variables
        Int16 FabricNumber; //var to store the PK
        string Origin; //var to store the origin
        string Name; //var to store the name
        string Composition; // var to store the composition
        string Quality; //var to store the quality
        string RealQuality; // var to store the real quality to get from the quality
        //create an instance of the clothes collection class
        clsFabricCollection FabricList = new clsFabricCollection();

        Int32 Index = Convert.ToInt32(txtFabricNumber.Text); //var to store the index of the value to display    
        
        FabricNumber = FabricList.FabricList[Index-1].FabricNo; //get the pk
        Origin = FabricList.FabricList[Index-1].Origin; //get the origin
        Name = FabricList.FabricList[Index-1].Name; //get the name
        Composition = FabricList.FabricList[Index-1].Composition; //get the composition
        Quality = Convert.ToString(FabricList.FabricList[Index - 1].Quality); //get the quality
        if (Convert.ToString(FabricList.FabricList[Index - 1].Quality) == "false")
        {
            RealQuality = "basic"; // change the value to disaply from false to basic
        }
        else 
        {
            RealQuality = "premium"; //change the value to display from true to premium
        }
        lstFabrics.Items.Clear(); //clear the list box everytime a new fabric is displaied

        //create  new entries for the list box
        ListItem newEntry01 = new ListItem("Fabric name: " + Name , FabricNumber.ToString()); 
        ListItem newEntry02 = new ListItem("Country of Origin: "+ Origin);
        ListItem newEntry03 = new ListItem("Fabric composition: " + Composition);
        ListItem NewEntry04 = new ListItem("Quality: " + RealQuality);
        lstFabrics.Items.Add(newEntry01); //add name to the list
        lstFabrics.Items.Add(newEntry02); //add origin to the list
        lstFabrics.Items.Add(newEntry03); //add composition to the list
        lstFabrics.Items.Add(NewEntry04); //add quality to the list

        return FabricNumber; //retunr the primary key
        
        

    }
}