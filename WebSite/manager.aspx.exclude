<%@ Page Language="C#" AutoEventWireup="true" CodeFile="manager.aspx.cs" Inherits="InsertInfo" %>

<%@ Register src="Control/U_usr.ascx" tagname="U_usr" tagprefix="uc1" %>
<%@ Register src="Control/U_pet.ascx" tagname="U_pet" tagprefix="uc2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 400px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
        <table>
            <tr>
                <td align="center">
                    <img src="ztimages/web_01.jpg" width="" height="" border="0" usemap="#Map"/>
                </td>
            </tr>
            <tr>
                <td>
                    <table>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="Button_newusr" runat="server" Text="New User" OnClick="Button_newusr_Click" />
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
                <td class="auto-style1">
                    <table class="contenttable">
                        <tr class="listcontent2">
                            <td>
                                <uc1:U_usr ID="U_usr1" runat="server" Visible="False" />
                                <uc1:U_usr ID="U_usr2" runat="server" Visible="False" />
                                <table class="contenttable22">
                                    <tr class="listtitle22">
                                        <td colspan="3" >
                                            <asp:Button ID="Button_update" runat="server" Text="Update"  OnClick="Button_update_Click" Visible="False" />
                                            <asp:Button ID="Button_insert" runat="server" Text="Submit" OnClick="Button_insert_Click" Visible="False" />
                                        &nbsp;&nbsp;
                                            <asp:Button ID="Button_newpet" runat="server" OnClick="Button_newpet_Click" Text="New Pet Profile" Visible="False" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>

                <td class="auto-style1">
                    <asp:Repeater ID="Repeater_petlist" runat="server" Visible="False">
                        <HeaderTemplate>
                            <table class="contenttable">
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr class="listcontent">
                                <td><asp:LinkButton ID="show_pet" CommandName='<%#Eval("ID")%>' OnCommand="show_pet" runat="server" style="white-space: nowrap; text-decoration:none; " Width="100%" ForeColor="#1ea0b9"><%#Eval("Name") %></asp:LinkButton></td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                            </table>
                        </FooterTemplate>
                    </asp:Repeater>
                </td>
                <td class="auto-style1">
                    
                <table>
                    <tr>
                        <td>
                            <uc2:U_pet ID="U_pet1" runat="server" Visible="False" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button_submit_pet" runat="server" Text="Submit" OnClick="Button_submit_pet_Click" Visible="False" />
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
