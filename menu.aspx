
<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="~/Site.master" CodeFile="Menu.aspx.vb"
        EnableViewState="true" EnableSessionState="True" Inherits="Menu" %>
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
                                        <table width="971" height="283" border="0" align="center" cellpadding="0" cellspacing="0"
                                                background="images/login/bg-gray.png">
                                                <tr>
                                                        <td align="center">
                                                                <table width="976" height="168" border="0" align="center" cellpadding="0" cellspacing="0">
                                                                        <tr>
                                                                                <td width="242" align="center" valign="top">
                                                                                        <a href="#">
                                                                                                <asp:ImageButton   runat=server   ImageUrl ="images/login/user.png" 
                                                                                                width="132" height="164" border="0" ID="btnUser" /></a>
                                                                                </td>
                                                                                <td width="243" align="center" valign="top">
                                                                                        <a href="#">
                                                                                                <asp:ImageButton  runat=server   ImageUrl="images/login/alert.png" 
                                                                                                width="140" height="156" border="0" ID="btnAlert" /></a>
                                                                                </td>
                                                                                <td width="243" align="center" valign="top">
                                                                                        <a href="#">
                                                                                                <asp:ImageButton  runat=server   ImageUrl="images/login/report.png" 
                                                                                                width="132" height="155" border="0" ID="btnReport"/></a>
                                                                                </td>
                                                                                <td width="243" align="center" valign="top">
                                                                                        <a href="#">
                                                                                                <asp:ImageButton  runat=server   ImageUrl="images/login/weather.png" 
                                                                                                width="171" height="168" border="0" ID="BtnResource"/></a>
                                                                                </td>
                                                                        </tr>
                                                                </table>
                                                        </td>
                                                </tr>
                                        </table>
                                </div>
                        </div>
                </div>
                <!-- wrapper-->
        </div>
        
        </center>
        </asp:Content>


