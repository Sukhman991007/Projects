<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FabricsOnClothes.aspx.cs" Inherits="Fabrics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
         body 
        {
            background-image: url('style/background.png')
        }
        .auto-style1 {
            position: absolute;
            top: 35px;
            left: 99px;
            z-index: 1;
            width: 333px;
            height: 240px;
        }
        .auto-style3 {
            position: absolute;
            top: 352px;
            left: 224px;
            z-index: 1;
            right: 932px;
            height: 35px;
        }
        .auto-style4 {
            position: absolute;
            top: 351px;
            left: 402px;
            z-index: 1;
            width: 62px;
        }
        .auto-style6 {
            position: absolute;
            top: 35px;
            left: 492px;
            z-index: 1;
            height: 240px;
            width: 333px;
        }
        .auto-style8 {
            position: absolute;
            top: 350px;
            left: 554px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 431px;
            left: 604px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 431px;
            left: 401px;
            z-index: 1;
            right: 759px;
        }
        .auto-style13 {
            position: absolute;
            top: 489px;
            left: 477px;
            z-index: 1;
            width: 527px;
        }
        .auto-style14 {
            position: absolute;
            top: 430px;
            left: 785px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 434px;
            left: 107px;
            z-index: 1;
            width: 236px;
        }
        .auto-style16 {
            position: absolute;
            top: 252px;
            left: 497px;
            z-index: 2;
            width: 137px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstFabrics" runat="server" CssClass="auto-style1" ForeColor="#0000CC" Font-Bold="True"></asp:ListBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblValue" runat="server" CssClass="auto-style16" ForeColor="Blue" Font-Bold="True"></asp:Label>
            <asp:ListBox ID="lstItems" runat="server" CssClass="auto-style6" ForeColor="#0000CC" Font-Bold="True"></asp:ListBox>
        </p>
        <p>
            <asp:DropDownList ID="dplFabrics" runat="server" CssClass="auto-style4" AutoPostBack="True" ForeColor="#0000CC" Font-Bold="True">
            </asp:DropDownList>
            <asp:Label ID="txtSearchProductCode" runat="server" CssClass="auto-style3" Text="Fabric number:" ForeColor="#0000CC" Font-Bold="True"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="BtnSearch" runat="server" CssClass="auto-style8" OnClick="BtnSearch_Click" Text="Search products" ForeColor="#0000CC" Font-Bold="True" />
        <asp:Button ID="btnAdd" runat="server" CssClass="auto-style12" OnClick="btnAdd_Click" Text="Add Fabric" ForeColor="#390091" Font-Bold="True" />
        <asp:Button ID="btnEdit" runat="server" CssClass="auto-style11" OnClick="btnEdit_Click" Text="Edit fabric" ForeColor="#005C80" Font-Bold="True" />
        <asp:Label ID="lblError" runat="server" CssClass="auto-style13" ForeColor="Red" Font-Bold="True"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" CssClass="auto-style14" OnClick="btnDelete_Click" Text="Delete" ForeColor="Maroon" Font-Bold="True" />
        <asp:Button ID="btnReturnToHomeScreen" runat="server" CssClass="auto-style15" OnClick="btnReturnToHomeScreen_Click" Text="Return to home screen" ForeColor="Lime" Font-Bold="True" />
    </form>
</body>
</html>
