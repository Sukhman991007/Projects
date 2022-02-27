<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ClothesShop</title>
    <style type="text/css">
        body 
        {
            background-image: url('style/background.png')
        }
        #lstClothes {
            height: 142px;
            width: 209px;
        }
        .auto-style1 {
            position: absolute;
            top: 325px;
            left: 276px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            top: 502px;
            left: 359px;
            z-index: 1;
            width: 75px;
        }
        .auto-style3 {
            z-index: 1;
            left: 255px;
            top: 379px;
            position: absolute;
            height: 35px;
        }
        .auto-style4 {
            z-index: 1;
            left: 28px;
            top: 323px;
            position: absolute;
        }
        .auto-style5 {
            z-index: 1;
            left: 34px;
            top: 501px;
            position: absolute;
        }
        .auto-style6 {
            z-index: 1;
            left: 136px;
            top: 503px;
            position: absolute;
        }
        .auto-style7 {
            z-index: 1;
            left: 224px;
            top: 503px;
            position: absolute;
        }
        .auto-style8 {
            z-index: 1;
            left: 21px;
            top: 284px;
            position: absolute;
            color:darkcyan;
        }
        .auto-style9 {
            z-index: 1;
            left: 24px;
            top: 443px;
            position: absolute;
            width: 600px;
        }
        .auto-style10 {
            position: absolute;
            top: 220px;
            left: 37px;
            z-index: 1;
            width: 353px;
        }
        .auto-style11 {
            z-index: 1;
            left: 29px;
            position: absolute;
            top: 14px;
            width: 352px;
            height: 181px;
        }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p style="margin-top: 0px">
            <asp:Button ID="btnDisplayAll" runat="server" Text="Display All" OnClick="btnDisplayAll_Click" CssClass="auto-style3" ForeColor="#0000CC" Font-Bold="True" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelte_Click" CssClass="auto-style7" ForeColor="Maroon" Font-Bold="True" />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" CssClass="auto-style5" ForeColor="#390091" Font-Bold="True" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" CssClass="auto-style6" ForeColor="#005C80" Font-Bold="True" />
            <asp:Button ID="btnApply" runat="server" CssClass="auto-style1" Text="Apply" OnClick="btnApply_Click" ForeColor="#0000CC" Font-Bold="True" />
            <asp:Label ID="lblItemCount" runat="server" CssClass="auto-style10" ForeColor="Blue" Font-Bold="True"></asp:Label>
        </p>
        <asp:Label ID="Label1" runat="server" style="margin-bottom: 3px" Text="Please Enter your style" CssClass="auto-style8" Font-Bold="True"></asp:Label>
        <asp:TextBox ID="txtProductCode" runat="server" CssClass="auto-style4" ForeColor="#0000CC" Font-Bold="True"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" CssClass="auto-style9" ForeColor="Red" Font-Bold="True"></asp:Label>
        </p>
        <asp:ListBox ID="lstItems" runat="server" CssClass="auto-style11" ForeColor="#0000CC" Font-Bold="True" Font-Overline="False"></asp:ListBox>
        <asp:Button ID="btnFabrics" runat="server" CssClass="auto-style2" OnClick="btnFabrics_Click" Text="Fabrics" ForeColor="Lime" Font-Bold="True" />
    </form>
</body>
</html>
