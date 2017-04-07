<%@ Control Language="C#" AutoEventWireup="true" CodeFile="U_showmsg.ascx.cs" Inherits="Control_U_showmsg" %>

<asp:Repeater ID="Repeater_nodelist" runat="server">
                                    <HeaderTemplate>
                                        <table border="1" rules="all"  width="558px">
                                            <tr>
                                                <td>DateTime</td>
                                                <td>Description</td>
                                            </tr>
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <tr class="listcontent">
                                            <td><%#Eval("Date") %></td>
                                            <td><%#Eval("Description")%></td>
                                        </tr>
                                    </ItemTemplate>
                                    <FooterTemplate>
                                        </table>
                                    </FooterTemplate>
                                </asp:Repeater>