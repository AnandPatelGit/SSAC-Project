<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="SSAC_Project.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <table> <tr><asp:Image ID="imgProduct" runat="server" /></tr></table>
    <table>
        <tr><td><asp:Literal runat="server" Text="Name: " /></td>
            <td><asp:Literal ID="oName" runat="server"/></td>
           
        </tr >
        <tr><td><asp:Literal runat="server" Text="Product: "></asp:Literal></td>
            <td><asp:Literal ID="oProduct" runat="server"/></td>
            <td>&nbsp;</td>
        </tr>
        <tr><td><asp:Literal runat="server" Text="Category "></asp:Literal></td>
            <td><asp:Literal ID="oCategory" runat="server"/></td>
        </tr>
        <tr><td><asp:Literal runat="server" Text="Price: "></asp:Literal></td>
            <td><asp:Literal ID="oPrice" runat="server"/></td>
        </tr>
        <tr><td><asp:Literal runat="server" Text="Quantity: "></asp:Literal></td>
            <td>
                <asp:TextBox ID="tbxQuantity" runat="server" OnTextChanged="tbxQuantity_TextChanged"></asp:TextBox>
            </td>
        </tr>
        <tr><td><asp:Literal runat="server" Text="Total: "></asp:Literal></td>
            <td><asp:Literal ID="oTotal" runat="server"/></td>
        </tr>   
        <tr><td><asp:Literal runat="server" Text="Mode of Payment: "></asp:Literal></td>
            <td><asp:DropDownList ID="Payment" runat="server" OnSelectedIndexChanged="Payment_SelectedIndexChanged">
                <asp:ListItem Selected="True">Credit</asp:ListItem>
                <asp:ListItem>Debit</asp:ListItem>
                <asp:ListItem>Cash on Delivery</asp:ListItem>
            </asp:DropDownList></td>
        </tr>
        <tr>
            <td><asp:Button Text="Check Out" ID="Check_Out" runat="server" OnClick="Check_Out_Click"/></td>
        </tr>
        </table>
</asp:Content>

