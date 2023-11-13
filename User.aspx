<%@ Page Language="VB" AutoEventWireup="false" CodeFile="User.aspx.vb" Inherits="User"
        MasterPageFile="~/Site.master" %>

<asp:Content ID="Content4" ContentPlaceHolderID="HeadContent" runat="Server">
        <title>Menu</title>
        <link rel="stylesheet" href="css/menu.css" type="text/css" />
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="MainContent" runat="Server">
        <center>
                <div id="bg-top">
                        <div id="wrapper">
                                <div id="container">
                                        <div class="top">
                                        </div>
                                        <div class="center">
                                                <div id="login" align="center" style="font-size: 12px">
                                                        <table width="800" border="0" cellspacing="0" cellpadding="0">
                                                                <tr>
                                                                        <td colspan="10" align="center">
                                                                                <table width="400" border="0" cellspacing="0" cellpadding="0">
                                                                                        <tr>
                                                                                                <td align="left" width="130">
                                                                                                        ชื่อ:
                                                                                                </td>
                                                                                                <td align="left">
                                                                                                        <asp:TextBox ID="txtName" runat="server" Width="200"></asp:TextBox>
                                                                                                </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                                <td align="left">
                                                                                                        นามสกุล :
                                                                                                </td>
                                                                                                <td align="left">
                                                                                                        <asp:TextBox ID="txtLastName" runat="server" Width="200"></asp:TextBox>
                                                                                                </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                                <td align="left">
                                                                                                        ตำแหน่ง
                                                                                                </td>
                                                                                                <td align="left">
                                                                                                        <asp:TextBox ID="txtPositon" runat="server" Width="200"></asp:TextBox>
                                                                                                </td>
                                                                                        </tr>
                                                                                        <tr height="30">
                                                                                                <td align="center" colspan="2">
                                                                                                        ข้อมูลการใช้ระบบ
                                                                                                </td>
                                                                                        </tr>
                                                                                        <tr height="25">
                                                                                                <td align="left" width="120">
                                                                                                        ชื่อการใช้งาน:
                                                                                                </td>
                                                                                                <td align="left">
                                                                                                        <asp:TextBox ID="txtLogInName" runat="server" Width="200"></asp:TextBox>
                                                                                                </td>
                                                                                        </tr>
                                                                                        <tr height="25">
                                                                                                <td align="left">
                                                                                                        รหัสการใช้งาน
                                                                                                </td>
                                                                                                <td align="left">
                                                                                                        <asp:TextBox ID="txtPassword" runat="server" Width="200" TextMode="Password"></asp:TextBox>
                                                                                                </td>
                                                                                        </tr>
                                                                                        <tr height="25">
                                                                                                <td align="left">
                                                                                                        ยืนยันรหัสการใช้งาน
                                                                                                </td>
                                                                                                <td align="left">
                                                                                                        <asp:TextBox ID="txtConfirmPassword" runat="server" Width="200" TextMode="Password"></asp:TextBox>
                                                                                                </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                                <td>
                                                                                                        ระดับการใช้งาน
                                                                                                </td>
                                                                                                <td align="left">
                                                                                                        <asp:DropDownList ID="cmbLevel" runat="server" Width="200">
                                                                                                                <asp:ListItem Selected="True" Text="<----------เลือก----------->" Value="-1"></asp:ListItem>
                                                                                                                <asp:ListItem Text="Admin" Value="1"></asp:ListItem>
                                                                                                                <asp:ListItem Text="User " Value="10"></asp:ListItem>
                                                                                                                <asp:ListItem Text="Viewer" Value="20"></asp:ListItem>
                                                                                                        </asp:DropDownList>
                                                                                                </td>
                                                                                        </tr>
                                                                                        <tr height="5">
                                                                                        </tr>
                                                                                        <tr>
                                                                                                <td align="center" colspan="2">
                                                                                                        <table width="400" border="0" cellspacing="0" cellpadding="0">
                                                                                                                <tr align="center">
                                                                                                                        <td>
                                                                                                                                <asp:Button ID="btnCreate" runat="server" Text="Create User" Width="120" />
                                                                                                                        </td>
                                                                                                                        <td>
                                                                                                                                <asp:Button ID="btnDelete" runat="server" Text="Delete User" />
                                                                                                                        </td>
                                                                                                                        <td>
                                                                                                                                <asp:Button ID="btnNew" runat="server" Text="New " Width="120" />
                                                                                                                        </td>
                                                                                                                </tr>
                                                                                                        </table>
                                                                                                </td>
                                                                                        </tr>
                                                                                </table>
                                                                        </td>
                                                                </tr>
                                                                <tr height="10">
                                                                </tr>
                                                                <tr>
                                                                        <td colspan="10">
                                                                                <asp:GridView ID='grdUser' runat="server" AutoGenerateColumns="False" RowStyle-Height="25"
                                                                                        HeaderStyle-Height="30">
                                                                                        <Columns>
                                                                                                <asp:BoundField DataField="LOGIN_NAME" HeaderText="LOGIN_NAME" Visible="False" ItemStyle-Width="0">
                                                                                                        <ItemStyle Width="0px"></ItemStyle>
                                                                                                </asp:BoundField>
                                                                                                <asp:BoundField DataField="NAME" HeaderText="ชื่อ" ItemStyle-Width="120">
                                                                                                        <ItemStyle Width="120px"></ItemStyle>
                                                                                                </asp:BoundField>
                                                                                                <asp:BoundField DataField="LAST_NAME" HeaderText="นามสกุล" ItemStyle-Width="200">
                                                                                                        <ItemStyle Width="200px"></ItemStyle>
                                                                                                </asp:BoundField>
                                                                                                <asp:BoundField DataField="POSITION" HeaderText="ตำแหน่ง" ItemStyle-Width="200">
                                                                                                        <ItemStyle Width="200px"></ItemStyle>
                                                                                                </asp:BoundField>
                                                                                                <asp:BoundField DataField="USER_LEVEL_STR" HeaderText="ระดับการใช้งาน" ItemStyle-Width="120">
                                                                                                        <ItemStyle Width="120px"></ItemStyle>
                                                                                                </asp:BoundField>
                                                                                                <asp:TemplateField>
                                                                                                        <ItemTemplate>
                                                                                                                <asp:LinkButton ID="btnEdit" Text="แก้ไข" CommandArgument='<%#eval("LOGIN_NAME") %>'
                                                                                                                        runat="server"></asp:LinkButton>
                                                                                                        </ItemTemplate>
                                                                                                </asp:TemplateField>
                                                                                        </Columns>
                                                                                </asp:GridView>
                                                                        </td>
                                                                </tr>
                                                        </table>
                                                </div>
                                        </div>
                                </div>
                        </div>
                        <!-- wrapper-->
                </div>
        </center>
</asp:Content>
<%--
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title></title>
</head>
<body>
        <center>
                <form id="form1" runat="server">
                <div id="login" align="center" style="font-size: 12px">
                        <table width="800" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                        <td colspan="10" align="center">
                                                <table width="400" border="0" cellspacing="0" cellpadding="0">
                                                        <tr>
                                                                <td align="left" width="130">
                                                                        ชื่อ:
                                                                </td>
                                                                <td align="left">
                                                                        <asp:TextBox ID="txtName" runat="server" Width="200"></asp:TextBox>
                                                                </td>
                                                        </tr>
                                                        <tr>
                                                                <td align="left">
                                                                        นามสกุล :
                                                                </td>
                                                                <td align="left">
                                                                        <asp:TextBox ID="txtLastName" runat="server" Width="200"></asp:TextBox>
                                                                </td>
                                                        </tr>
                                                        <tr>
                                                                <td align="left">
                                                                        ตำแหน่ง
                                                                </td>
                                                                <td align="left">
                                                                        <asp:TextBox ID="txtPositon" runat="server" Width="200"></asp:TextBox>
                                                                </td>
                                                        </tr>
                                                        <tr height="30">
                                                                <td align="center" colspan="2">
                                                                        ข้อมูลการใช้ระบบ
                                                                </td>
                                                        </tr>
                                                        <tr height="25">
                                                                <td align="left" width="120">
                                                                        ชื่อการใช้งาน:
                                                                </td>
                                                                <td align="left">
                                                                        <asp:TextBox ID="txtLogInName" runat="server" Width="200"></asp:TextBox>
                                                                </td>
                                                        </tr>
                                                        <tr height="25">
                                                                <td align="left">
                                                                        รหัสการใช้งาน
                                                                </td>
                                                                <td align="left">
                                                                        <asp:TextBox ID="txtPassword" runat="server" Width="200" TextMode="Password"></asp:TextBox>
                                                                </td>
                                                        </tr>
                                                        <tr height="25">
                                                                <td align="left">
                                                                        ยืนยันรหัสการใช้งาน
                                                                </td>
                                                                <td align="left">
                                                                        <asp:TextBox ID="txtConfirmPassword" runat="server" Width="200" TextMode="Password"></asp:TextBox>
                                                                </td>
                                                        </tr>
                                                        <tr>
                                                                <td>
                                                                        ระดับการใช้งาน
                                                                </td>
                                                                <td align="left">
                                                                        <asp:DropDownList ID="cmbLevel" runat="server" Width="200">
                                                                                <asp:ListItem Selected="True" Text="<----------เลือก----------->" Value="-1"></asp:ListItem>
                                                                                <asp:ListItem Text="Admin" Value="1"></asp:ListItem>
                                                                                <asp:ListItem Text="User " Value="10"></asp:ListItem>
                                                                                <asp:ListItem Text="Viewer" Value="20"></asp:ListItem>
                                                                        </asp:DropDownList>
                                                                </td>
                                                        </tr>
                                                        <tr>
                                                                <td align="center" colspan="2">
                                                                        <table width="400" border="0" cellspacing="0" cellpadding="0">
                                                                                <tr align=center >
                                                                                        <td>
                                                                                                <asp:Button ID="btnCreate" runat="server" Text="Create User" Width =120 />
                                                                                        </td>
                                                                                        <td> <asp:Button ID="btnDelete" runat="server" Text="Delete User" /></td>
                                                                                        <td> <asp:Button ID="btnNew" runat="server" Text="New " Width=120 /></td>
                                                                                </tr>
                                                                        </table>
                                                                </td>
                                                        </tr>
                                                </table>
                                        </td>
                                </tr>
                                <tr>
                                        <td colspan="10">
                                                <asp:GridView ID='grdUser' runat="server" AutoGenerateColumns="False">
                                                        <Columns>
                                                                <asp:BoundField DataField="LOGIN_NAME" HeaderText="LOGIN_NAME" Visible="False" ItemStyle-Width="0">
                                                                        <ItemStyle Width="0px"></ItemStyle>
                                                                </asp:BoundField>
                                                                <asp:BoundField DataField="NAME" HeaderText="ชื่อ" ItemStyle-Width="120">
                                                                        <ItemStyle Width="120px"></ItemStyle>
                                                                </asp:BoundField>
                                                                <asp:BoundField DataField="LAST_NAME" HeaderText="นามสกุล" ItemStyle-Width="200">
                                                                        <ItemStyle Width="200px"></ItemStyle>
                                                                </asp:BoundField>
                                                                <asp:BoundField DataField="POSITION" HeaderText="ตำแหน่ง" ItemStyle-Width="200">
                                                                        <ItemStyle Width="200px"></ItemStyle>
                                                                </asp:BoundField>
                                                                <asp:BoundField DataField="USER_LEVEL_STR" HeaderText="ระดับการใช้งาน" ItemStyle-Width="120">
                                                                        <ItemStyle Width="120px"></ItemStyle>
                                                                </asp:BoundField>
                                                                <asp:TemplateField>
                                                                        <ItemTemplate>
                                                                                <asp:LinkButton ID="btnEdit" Text="แก้ไข" CommandArgument='<%#eval("LOGIN_NAME") %>'
                                                                                        runat="server"></asp:LinkButton>
                                                                        </ItemTemplate>
                                                                </asp:TemplateField>
                                                        </Columns>
                                                </asp:GridView>
                                        </td>
                                </tr>
                        </table>
                </div>
                </form>
        </center>
</body>
</html>--%>
