<%@ Page Language="C#" AutoEventWireup="true" CodeFile="employee.aspx.cs" Inherits="Emplyee" %>

<%@ Register src="Control/U_showpet.ascx" tagname="U_showpet" tagprefix="uc1" %>
<%@ Register src="Control/U_service.ascx" tagname="U_service" tagprefix="uc2" %>
<%@ Register src="Control/U_showmsg.ascx" tagname="U_showmsg" tagprefix="uc3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
        <table>
            <tr>
                <td align="center">

            <img src="ztimages/web_01.jpg" width="" height="" border="0" usemap="#Map"/></td>
            </tr>
            <tr>
                <td>
                    <table>
            <tr>
                <td>
                    <asp:Repeater ID="Repeater_usrlist" runat="server">
                        <HeaderTemplate>
                            <table class="contenttable">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr class="listcontent">
                                <td><asp:LinkButton ID="show_usr" CommandName='<%#Eval("username")%>' OnCommand="show_usr" runat="server" style="white-space: nowrap; text-decoration:none; " Width="100%" ForeColor="#1ea0b9"><%#Eval("Name") %></asp:LinkButton></td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                            </table>
                        </FooterTemplate>
                    </asp:Repeater>
                </td>
                <td>
                    <table>
                        <tr>
                            <td>
                                <asp:DropDownList ID="DropDownList_pet" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList_pet_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
            <tr>
                <td>
                    <table>
                        <tr>
                            <td><uc1:U_showpet ID="U_showpet1" runat="server" /></td>
                            <td>
                                <uc2:U_service ID="U_service1" runat="server" />
                                <asp:Button ID="Button_submit" runat="server" OnClick="Button_submit_Click" Text="Submit" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>

                    <uc3:U_showmsg ID="U_showmsg1" runat="server" />

                </td>
            </tr>
        </table>
                </td>
            </tr>
        </table>
                </td>
            </tr>
        </table>
        </center>
        
    </div>
    </form>
    <footer>
        <center>
            Copyright ©2016 MAC UWindsor
        </center>
    </footer>
</body>
</html>
