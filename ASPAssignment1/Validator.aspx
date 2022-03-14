<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="ASPAssignment1.Initiator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <center>
            <table>
        <tr><td><asp:Label ID="Label1" runat="server" Text="Name"></asp:Label></td>
        <td><asp:TextBox ID="Name" runat="server" OnTextChanged="Name_TextChanged"/></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="Name"></asp:RequiredFieldValidator></td>
        </tr>
       <tr><td> <asp:Label ID="Label2" runat="server" Text="Family Name"></asp:Label></td>
        
        <td><asp:TextBox ID="Family_Name" runat="server"/></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Family_Name" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
        <td><asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="Name" ErrorMessage="Differs From Name" ForeColor="Red" Operator="NotEqual" ControlToValidate="Family_Name"></asp:CompareValidator>
        </td></tr>
        <tr><td><asp:Label ID="Label3" runat="server" Text="Address"></asp:Label></td>
        
        <td><asp:TextBox ID="Address" runat="server"/></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ErrorMessage="*" ForeColor="Red" ControlToValidate="Address">*</asp:RequiredFieldValidator></td>
        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Address" ErrorMessage="atleast 2 charecters" ForeColor="Red" ValidationExpression="^[a-zA-Z-\s\{2,}]+$"></asp:RegularExpressionValidator>
        </td></tr>
       <tr><td> <asp:Label ID="Label4" runat="server" Text="City"></asp:Label></td>
       
        <td><asp:TextBox ID="City" runat="server"/></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="City" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="City" ErrorMessage="atleast 2 chars" ForeColor="Red" ValidationExpression="^[a-zA-Z-\s{2,}]+$"></asp:RegularExpressionValidator>
        </td></tr>
        <tr><td><asp:Label ID="Label5" runat="server" Text="Zip Code"></asp:Label></td>
        
       <td> <asp:TextBox ID="Zip_Code" runat="server"/></td>
       <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="Zip_Code" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="Zip_Code" ErrorMessage="(xxxxxx)" ForeColor="Red" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
        </td></tr>
        <tr><td><asp:Label ID="Label6" runat="server" Text="Phone"></asp:Label></td>
      
        <td><asp:TextBox ID="Phone" runat="server"/></td>
       <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="Phone" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
       <td> <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="Phone" ErrorMessage="(xx-xxxxxxxx/xxx-xxxxxxx)" ForeColor="Red" ValidationExpression="^(?:\d{3}-\d{7}-|\d{2}-\d{8})$"></asp:RegularExpressionValidator>
        </td></tr>
        <tr><td><asp:Label ID="Label7" runat="server" Text="E-mail"></asp:Label></td>
        
        <td><asp:TextBox ID="email_address" runat="server"/></td>
        <td><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="email_address" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator></td>
        <td><asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="email_address" ErrorMessage="example@example.com" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
        </tr><tr><td></td>
        <td ><asp:Button ID="Button1" runat="server" Text="Check" OnClick="Button1_Click" /></td></tr>
       <tr> <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="true" ShowSummary="true" ForeColor="Red" displaymode="List"/></tr>
    </table>
                </form>
</body>
</html>
