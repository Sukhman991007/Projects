<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Fabrics.aspx.cs" Inherits="Fabrics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
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
            top: 346px;
            left: 177px;
            z-index: 1;
            right: 733px;
            height: 35px;
        }
        .auto-style4 {
            position: absolute;
            top: 346px;
            left: 379px;
            z-index: 1;
            width: 154px;
        }
        .auto-style5 {
            position: absolute;
            top: 440px;
            left: 355px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 35px;
            left: 492px;
            z-index: 1;
            height: 240px;
            width: 333px;
        }
        .auto-style7 {
            position: absolute;
            top: 290px;
            left: 149px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 339px;
            left: 586px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 284px;
            left: 607px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 387px;
            left: 377px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstFabrics" runat="server" CssClass="auto-style1"></asp:ListBox>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:ListBox ID="lstItems" runat="server" CssClass="auto-style6"></asp:ListBox>
        </p>
        <p>
            <asp:Label ID="txtSearchProductCode" runat="server" CssClass="auto-style3" Text="Fabric number:"></asp:Label>
            <asp:DropDownList ID="dplFabrics" runat="server" CssClass="auto-style4">
            </asp:DropDownList>
            <asp:Button ID="btnDisplayFabrics" runat="server" CssClass="auto-style7"  Text="Disaply fabric information" OnClick="btnDisplayFabrics_Click" />
            <asp:Label ID="lblItemCount" runat="server" CssClass="auto-style9"></asp:Label>
        </p>
        <p>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style5" OnClick="Button1_Click" Text="Return to home page" />
        </p>
        <asp:Button ID="BtnSearch" runat="server" CssClass="auto-style8" OnClick="BtnSearch_Click" Text="Search products" />
        <asp:TextBox ID="txtFabricNumber" runat="server" CssClass="auto-style10"></asp:TextBox>
    </form>
</body>
</html>
