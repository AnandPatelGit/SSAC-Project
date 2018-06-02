<%@ Page Title="" Language="C#" MasterPageFile="~/MainMasterPage.Master" AutoEventWireup="true" CodeBehind="ElectronicsDepartmentSSAC.aspx.cs" Inherits="SSAC_Project.ElectronicsDepartmentSSAC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <asp:Label ID="lblTblHdr" Text="Electronics" runat="server" Font-Bold="true" Font-Names="Verdana" Font-Size="Larger"/>
    <table>
        <tr class="Scrollgrid">
            <td> <asp:ImageButton  runat="server" ID="imgBtnElectronics1" ImageUrl="~/Images/Electronics1iPhone7.jpeg" Height="200px" OnClick="imgBtnElectronics1_Click" /><br/>
                <asp:Label runat="server" Text="Apple iPhone 7  Starting from Price $ " Font-Italic="True" Font-Names="Candara"/><asp:Label Id="lblPrice1" runat="server" Text="800" Font-Italic="True" Font-Names="Candara"/>
                <br />
                <asp:ImageButton ID="ImageButton1" ToolTip="Add to Cart" ImageUrl="~/Images/itemcart.png" runat="server" Text="Add to Cart" Height="30px" Width="30px" OnClick="ImageButton1_Click"/>
            </td>
             <td> <asp:ImageButton  runat="server" ID="imgBtnElectronics2" ImageUrl="~/Images/Electronics2MacBookPro.jpg" Height="200px" OnClick="imgBtnElectronics2_Click"/><br/>
                <asp:Label runat="server" Text="Apple Mac Book Pro Early 2016 Starting from Price $ " Font-Italic="True" Font-Names="Candara"/><asp:Label Id="lblPrice2" runat="server" Text="1500" Font-Italic="True" Font-Names="Candara"/>
                 <br />
                <asp:ImageButton ID="ImageButton2" ToolTip="Add to Cart" ImageUrl="~/Images/itemcart.png" runat="server"  Height="30px" Width="30px" OnClick="ImageButton2_Click"/>
            </td>
             <td> <asp:ImageButton  runat="server" ID="imgBtnElectronics3" ImageUrl="~/Images/Electronics3SonyTV.jpg" Height="200px" OnClick="imgBtnElectronics3_Click" /><br/>
                <asp:Label runat="server" Text="Sony Bravia 4K Starting from Price $ " Font-Italic="True" Font-Names="Candara"/><asp:Label runat="server" Id="lblPrice3" Text="1000" Font-Italic="True" Font-Names="Candara"/><br />
                <asp:ImageButton ID="ImageButton3" ToolTip="Add to Cart" ImageUrl="~/Images/itemcart.png" runat="server"  Height="30px" Width="30px" OnClick="ImageButton3_Click"/>
            
             </td>
             <td> <asp:ImageButton  runat="server" ID="imgBtnElectronics4" ImageUrl="~/Images/Electronics4Beats.jpg" height="300px" OnClick="imgBtnElectronics4_Click"/><br/>
                 <asp:Label runat="server" Text="Beats by Dr. Dre Headphones Starting from Price $" Font-Italic="True" Font-Names="Candara"/><asp:Label runat="server" Id="lblPrice4" Text="300" Font-Italic="True" Font-Names="Candara"/><br />
                <asp:ImageButton ID="ImageButton4" ToolTip="Add to Cart" ImageUrl="~/Images/itemcart.png" runat="server"  Height="30px" Width="30px"/>
             </td>
        </tr>
      <tr class="Scrollgrid">
            <td> <asp:ImageButton  runat="server" ID="imgBtnElectronics5" ImageUrl="~/Images/Electronics5SonyPS4.jpg" height="200px" OnClick="imgBtnElectronics5_Click" /><br/>
                <asp:Label runat="server" Text="Sony Play Station 4 Starting from Price $ " Font-Italic="True" Font-Names="Candara"/><asp:Label runat="server" Id="lblPrice5" Text="900" Font-Italic="True" Font-Names="Candara"/><br />
                <asp:ImageButton ID="ImageButton5" ToolTip="Add to Cart" ImageUrl="~/Images/itemcart.png" runat="server"  Height="30px" Width="30px"/></td>
             <td> <asp:ImageButton  runat="server" ID="imgBtnElectronics6" ImageUrl="~/Images/Electronics6PhilipsSoundBar.jpeg" height="200px" OnClick="imgBtnElectronics6_Click"/><br/>
                <asp:Label runat="server" Text="Philips Sound Bar  Starting from Price $ " Font-Italic="True" Font-Names="Candara"/><asp:Label runat="server" Id="lblPrice6" Text="800" Font-Italic="True" Font-Names="Candara"/><br />
                <asp:ImageButton ID="ImageButton6" ToolTip="Add to Cart" ImageUrl="~/Images/itemcart.png" runat="server"  Height="30px" Width="30px"/></td>
             <td> <asp:ImageButton  runat="server" ID="imgBtnElectronics7" ImageUrl="~/Images/Electronics7iMac.jpg" height="200px" OnClick="imgBtnElectronics7_Click"/><br/>
                <asp:Label runat="server" Text="Apple iMac Early 2016  Starting from Price $ " Font-Italic="True" Font-Names="Candara"/><asp:Label runat="server" Id="lblPrice7" Text="2000" Font-Italic="True" Font-Names="Candara"/><br />
                <asp:ImageButton ID="ImageButton7" ToolTip="Add to Cart" ImageUrl="~/Images/itemcart.png" runat="server"  Height="30px" Width="30px"/></td>
             <td> <asp:ImageButton  runat="server" ID="imgBtnElectronics8" ImageUrl="~/Images/Electronics8iWatch.jpeg" height="200px" OnClick="imgBtnElectronics8_Click"/><br/>
                <asp:Label runat="server" Text="Apple iWatch Series 2 Starting from Price $ " Font-Italic="True" Font-Names="Candara"/><asp:Label runat="server" Id="lblPrice8" Text="500" Font-Italic="True" Font-Names="Candara"/><br />
                <asp:ImageButton ID="ImageButton8" ToolTip="Add to Cart" ImageUrl="~/Images/itemcart.png" runat="server"  Height="30px" Width="30px"/></td>
        </tr>
    </table>
</asp:Content>
