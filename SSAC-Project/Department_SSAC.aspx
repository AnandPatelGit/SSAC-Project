<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="Department_SSAC.aspx.cs" Inherits="SSAC_Project.Department_SSAC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="Scrollgrid">
    <table>
        <tr>
            <td>
                <asp:ImageButton  runat="server" ID="imgBtnClothes" ImageUrl="~/Images/clothes.jpg" CssClass="submit" height="200px" weight="200px" OnClick="imgBtnClothes_Click"/><br/>
                <asp:Label runat="server" Text="Choose from our collection of clothes" Font-Italic="True" Font-Names="Candara"/>
            </td>
            <td>
                <asp:ImageButton  runat="server" ID="imgBtnBooks" ImageUrl="~/Images/Books.jpg" CssClass="submit" height="200px" weight="200px" OnClick="imgBtnBooks_Click"/>
                <asp:Label runat="server" Text="Choose from our collection of Books" Font-Italic="True" Font-Names="Candara"/>
            </td>
            <td>
                <asp:ImageButton  runat="server" ID="imgBtnHome" ImageUrl="~/Images/Electronics.jpg" CssClass="submit" height="200px" weight="200px" OnClick="imgBtnElectronics_Click"/>
                <asp:Label runat="server" Text="Choose from our collection of Electronics" Font-Italic="True" Font-Names="Candara"/>
            </td>
            <td>
                <asp:ImageButton  runat="server" ID="imgBtnElectronics" ImageUrl="~/Images/Furniture.jpg" CssClass="submit" height="200px" weight="200px" OnClick="imgBtnHome_Click"/>
                <asp:Label runat="server" Text="Choose from our collection of Home Accessories" Font-Italic="True" Font-Names="Candara"/>
            </td>
        </tr>
    </table>
    </div>
</asp:Content>