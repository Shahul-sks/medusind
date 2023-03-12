<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDown.aspx.cs" Inherits="Validator.DropDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            Question2 : DropDown List<br />
            <br />
            <asp:DropDownList ID="Listed" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Listed_SelectedIndexChanged1">
           
                <asp:ListItem Value="laptop">laptop</asp:ListItem>
                <asp:ListItem Value="mobile">Mobile</asp:ListItem>
                <asp:ListItem Value="headphone">headphone</asp:ListItem>
                <asp:ListItem Value="watch">watch</asp:ListItem>
            </asp:DropDownList>



            <br />
            <br />
            <asp:Image ID="img" runat="server" Height="248px" Width="234px" />



            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="44px" Text="BUY " Width="145px" OnClick="Button1_Click" ForeColor="Green" />



        </div>
        <p>
            <asp:Label ID="price" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
