<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2.aspx.cs" Inherits="ASPAssignment1._2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 246px;
            height: 185px;
        }
    </style>
</head>
<body>
    <center>
    <form id="form1" runat="server">
        
        <p>
            <asp:Image ID="Image1" runat="server" ClientIDMode="AutoID" CssClass="auto-style1" GenerateEmptyAlternateText="True" Height="250px" ImageUrl="~/hero1.jpg" ValidateRequestMode="Enabled" Width="200px" />
        </p>
        <asp:DropDownList ID="Hero" runat="server" ForeColor="#6699FF" Height="20px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="Hero">Hero</asp:ListItem>
            <asp:ListItem Value="Splender">Hero Splender</asp:ListItem>
            <asp:ListItem Value="Ismart">Hero Ismart</asp:ListItem>
            <asp:ListItem Value="Pleasure">Hero Pleasure</asp:ListItem>
            <asp:ListItem Value="Passion">Hero Passion</asp:ListItem>
            <asp:ListItem Value="Glamour">Hero Glamour</asp:ListItem>
        </asp:DropDownList>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Check Price" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Price Of Vehicle"></asp:Label>
        </p>
        
    </form>
</body>
</html>
