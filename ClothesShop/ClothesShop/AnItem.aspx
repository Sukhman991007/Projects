<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnItem.aspx.cs" Inherits="clothes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
         body 
        {
            background-image: url('style/background.png')
        }
        #form1 {
            height: 421px;
        }
        .auto-style1 {
            z-index: 1;
            left: 57px;
            top: 521px;
            position: absolute;
            color:red;
            width: 1129px;
            right: 153px;
        }
        .auto-style2 {
            z-index: 1;
            left: 435px;
            top: 435px;
            position: absolute;
            color:orange
        }
        .auto-style5 {
            position: absolute;
            top: 54px;
            left: 372px;
            z-index: 1;
            right: 800px;
        }
        .auto-style6 {
            position: absolute;
            top: 275px;
            left: 88px;
            z-index: 1;
            width: 45px;
        }
        .auto-style7 {
            position: absolute;
            top: 436px;
            left: 202px;
            z-index: 1;
            width: 40px;
            color: forestgreen
        }
        .auto-style8 {
            position: absolute;
            top: 274px;
            left: 140px;
            z-index: 1;
            width: 76px;
        }
        .auto-style9 {
            z-index: 1;
            left: 144px;
            top: 337px;
            position: absolute;
        }
        .auto-style10 {
            z-index: 1;
            left: 22px;
            top: 174px;
            position: absolute;
        }
        .auto-style11 {
            z-index: 1;
            left: 140px;
            top: 172px;
            position: absolute;
            width: 105px;
        }
        .auto-style12 {
            position: absolute;
            top: 53px;
            left: 523px;
            z-index: 1;
        }
        .auto-style13 {
            z-index: 1;
            left: 20px;
            top: 223px;
            position: absolute;
        }
        .auto-style14 {
            z-index: 1;
            left: 19px;
            top: 117px;
            position: absolute;
        }
        .auto-style15 {
            z-index: 1;
            left: 22px;
            top: 62px;
            position: absolute;
        }
        .auto-style16 {
            z-index: 1;
            left: 141px;
            top: 222px;
            position: absolute;
            width: 105px;
        }
        .auto-style18 {
            position: absolute;
            top: 64px;
            left: 142px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label4" runat="server" CssClass="auto-style6" Text="Size:" ForeColor="#0000CC" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label1" runat="server" Text="Date added:" CssClass="auto-style10" ForeColor="#0000CC" Font-Bold="True"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
        <asp:TextBox ID="txtDepartment" runat="server" style="z-index: 1; left: 141px; top: 115px; position: absolute; width: 105px" ForeColor="#0000CC" Font-Bold="True"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDescription" runat="server" Text="Description:" CssClass="auto-style15" ForeColor="#0000CC" Font-Bold="True"></asp:Label>
            <asp:Label ID="lblType" runat="server" Text="Department:" CssClass="auto-style14" ForeColor="#0000CC" Font-Bold="True"></asp:Label>
            <asp:TextBox ID="txtAvailability" runat="server" CssClass="auto-style16" ForeColor="#0000CC" Font-Bold="True"></asp:TextBox>
            <asp:TextBox ID="txtDateAdded" runat="server" CssClass="auto-style11" ForeColor="#0000CC" Font-Bold="True"></asp:TextBox>
            <asp:Label ID="lblAvailability" runat="server" Text="Availability:" CssClass="auto-style13" ForeColor="#0000CC" Font-Bold="True"></asp:Label>
            <asp:DropDownList ID="dplFabricNumber" runat="server" CssClass="auto-style12" ForeColor="Lime" Font-Bold="True">
            </asp:DropDownList>
        </p>
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" CssClass="auto-style2" Font-Bold="True" />
        <asp:Label ID="Label3" runat="server" CssClass="auto-style5" Text="Fabric Number:" ForeColor="Lime" Font-Bold="True"></asp:Label>
            <asp:CheckBox ID="ckbType" runat="server" Text="New" CssClass="auto-style9" ForeColor="#CA0065" Font-Bold="True" />
        <p>
            <asp:TextBox ID="txtDescription" runat="server" CssClass="auto-style18" ForeColor="#0000CC" Font-Bold="True"></asp:TextBox>
        </p>
        <asp:Button ID="btnOk" runat="server" CssClass="auto-style7" OnClick="btnOk_Click" Text="Ok" Font-Bold="True" />
        <asp:TextBox ID="txtSize" runat="server" CssClass="auto-style8" ForeColor="#0000CC" Font-Bold="True"></asp:TextBox>
        <p>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style1" Font-Bold="True"></asp:Label>
        </p>
    </form>
</body>
</html>
