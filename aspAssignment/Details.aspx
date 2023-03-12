<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Validator.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>



            Insert your Deatils :<br />
            <br />
            Name :
            <asp:TextBox ID="name" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="name"></asp:RequiredFieldValidator>
            <br />
            <br />
            Family name : <asp:TextBox ID="famname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="famname"></asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="differs from name" ControlToCompare="name" ControlToValidate="famname" Operator="NotEqual" ForeColor="Red"></asp:CompareValidator>
            <br />
            <br />
            Address :<asp:TextBox ID="address" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="address"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="at least 2 char" ValidationExpression="^.*[a-zA-Z]{2,}.*$" ControlToValidate="address" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
&nbsp;<br />
            City :
            <asp:TextBox ID="city" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="city"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="at least 2 char" ValidationExpression="^.*[a-zA-Z]{2,}.*$" ControlToValidate="city" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
            <br />
            Zip Code :
            <asp:TextBox ID="code" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="code"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="(xxxxx)" ControlToValidate="code" ValidationExpression="\d{5}(-\d{4})?" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
            <br />
            Phone :<asp:TextBox ID="phone" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="phone"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="(xx-xxxxxxx / xxx-xxxxxxx)" ControlToValidate="phone" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
            <br />
            E-Mail :<asp:TextBox ID="email" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="email"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="example@example.com" ControlToValidate="email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            <asp:Button ID="btn" runat="server" Height="35px" Text="Check" Width="166px" />
            


        </div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </form>
</body>
</html>
