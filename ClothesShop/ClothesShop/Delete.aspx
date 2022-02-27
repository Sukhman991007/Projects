<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Default2" %>

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
            z-index: 1;
            top: 195px;
            position: absolute;
            height: 26px;
            bottom: 467px;
            width: 150px;
            right: 1068px;
            left: 121px;
            color:orange;
        }
        .auto-style2
        {
            color:forestgreen;
        }
        .auto-style3 {
            position: absolute;
            top: 105px;
            left: 33px;
            z-index: 1;
            width: 434px;
            color:red;
        }
        .auto-style4 {
            z-index: 1;
            top: 254px;
            position: absolute;
            height: 22px;
            bottom: 412px;
            width: 1033px;
            right: 293px;
            left: 13px;
            color: orange;
        }
        </style>
</head>
<body style="height: 471px; width: 515px">
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" CssClass="auto-style4" Font-Bold="True"></asp:Label>
        </p>
        <div>
            <asp:Label ID="lblQuestion" runat="server" CssClass="auto-style3" Font-Bold="True"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 37px; top: 195px; position: absolute; height: 26px; width: 45px;" Text="Yes" OnClick="btnYes_Click" CssClass="auto-style2" Font-Bold="True"/>
        <p>
        <asp:Button ID="btnNo0" runat="server" Text="No/Return back" OnClick="btnNo_Click" CssClass="auto-style1" Font-Bold="True" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
