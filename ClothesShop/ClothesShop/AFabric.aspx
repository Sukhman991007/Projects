<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AFabric.aspx.cs" Inherits="AFabric" %>

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
            top: 171px;
            left: 197px;
            z-index: 1;
            
        }
        .auto-style2 {
            position: absolute;
            top: 397px;
            left: -41px;
            bottom: 256px;
            z-index: 1;
            width: 802px;
            color: red;
        }
        .auto-style3 {
            position: absolute;
            top: 224px;
            left: 158px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 311px;
            left: 369px;
            z-index: 1;
            right: 661px;
            color: orange;
        }
        .auto-style6 {
            position: absolute;
            top: 119px;
            left: 202px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 312px;
            left: 256px;
            z-index: 1;
            color:forestgreen;
            right: 824px;
        }
        .auto-style8 {
            position: absolute;
            top: 56px;
            left: 276px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 115px;
            left: 276px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 223px;
            left: 277px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 55px;
            left: 204px;
            z-index: 1;
            bottom: 518px;
        }
        .auto-style14 {
            position: absolute;
            top: 170px;
            left: 288px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 170px;
            left: 392px;
            z-index: 1;
        }
                
        .style02
        {
            color:forestgreen;
        }
        .auto-style16 {
            margin-left: 80px;
        }
        .auto-style17 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style17">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" CssClass="auto-style6" Text="Origin:" ForeColor="#0000CC" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style13" Text="Name:" ForeColor="#0000CC" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label3" runat="server" CssClass="auto-style3" Text="Composition:" ForeColor="#0000CC" Font-Bold="True"></asp:Label>
        <asp:Label ID="Label5" runat="server" CssClass="auto-style1" Text="Quality:" ForeColor="#0000CC" Font-Bold="True"></asp:Label>
        <asp:TextBox ID="txtOrigin" runat="server" CssClass="auto-style9" ForeColor="#0000CC" Font-Bold="True"></asp:TextBox>
        <asp:TextBox ID="txtComposition" runat="server" CssClass="auto-style11" ForeColor="#0000CC" Font-Bold="True"></asp:TextBox>
        <div class="auto-style16">
            <asp:TextBox ID="txtName" runat="server" CssClass="auto-style8" ForeColor="#0000CC" Font-Bold="True"></asp:TextBox>
        </div>
        <asp:Button ID="btnCancell" runat="server" CssClass="auto-style4" Text="Cancel" OnClick="btnCancell_Click" Font-Bold="True" />
        <asp:Button ID="btnOk" runat="server" CssClass="auto-style7" Text="Ok" OnClick="btnOk_Click" CssClas="style02" Font-Bold="True"/>
        <asp:Label ID="lblError" runat="server" CssClass="auto-style2" Font-Bold="True"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:RadioButton ID="rdbBasic" runat="server" CssClass="auto-style14" Text="Basic" GroupName="FabricType" ForeColor="#CA0065"/>
        <asp:RadioButton ID="rdbPremium" runat="server" CssClass="auto-style15" Text="Premium" GroupName="FabricType" ForeColor="#D26900"/>
        </div>
    </form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
