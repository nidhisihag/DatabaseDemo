<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <b>Contacts</b>


            <table>
                
                <tr>
                    <td>First Name</td>
                    <td>
                        <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Last Name</td>
                    <td>
                        <asp:TextBox ID="txtLast" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>City</td>
                    <td>
                        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnInsert" runat="server" Text="Insert" /></td>
                </tr>
            </table>
            <hr width: 300px;margin-left: auto;margin-right: auto; />
            <br  />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField HeaderText="ContactId" DataField="ContactId" ItemStyle-Width="50" />
                    <asp:BoundField HeaderText="FirstName" DataField="FirstName" ItemStyle-Width="50" />
                    <asp:BoundField HeaderText="LastName" DataField="LastName" ItemStyle-Width="50" />
                    <asp:BoundField HeaderText="City" DataField="City" ItemStyle-Width="50" />

                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
