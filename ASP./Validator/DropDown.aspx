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
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Text ="Select item" Value ="select">Select Item</asp:ListItem>
                <asp:ListItem Value="laptop">laptop</asp:ListItem>
                <asp:ListItem Value="mobile">Mobile</asp:ListItem>
                <asp:ListItem Value="headphone">headphone</asp:ListItem>
                <asp:ListItem Value="watch">watch</asp:ListItem>
                <asp:ListItem Value="tv">tv</asp:ListItem>
            </asp:DropDownList>

            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="248px" Width="346px" />



            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="44px" Text="Button" Width="145px" />



        </div>
    </form>
</body>
</html>
