<%@ Control Language="C#" AutoEventWireup="true" CodeFile="U_rank.ascx.cs" Inherits="Control_U_rank" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

                <style type="text/css">
                    .auto-style1 {
                        height: 23px;
                    }
                </style>

                <table>
                    <tr>
                        <td class="auto-style1"><strong>Date: </strong> </td>
                        <td class="auto-style1"><asp:TextBox ID="TextBox_dt" runat="server"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="TextBox_dt_CalendarExtender" runat="server" BehaviorID="TextBox1_CalendarExtender" TargetControlID="TextBox_dt" />
                </td>
                    </tr>
                    <tr>
                        <td><strong>Level: </strong> </td>
                        <td><asp:DropDownList ID="DropDownList_level" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList_level_SelectedIndexChanged">
                </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td><strong>Course: </strong> </td>
                        <td><asp:DropDownList ID="DropDownList_cos" runat="server">
                </asp:DropDownList></td>
                    </tr>
                    <tr>
                        <td><strong>Student: </strong> </td>
                        <td><asp:DropDownList ID="DropDownList_stu" runat="server" AutoPostBack="True">
                </asp:DropDownList></td>
                    </tr>
                </table>
                
                <br />
                <asp:Button ID="Button_submit" runat="server" OnClick="Button_submit_Click" Text="Submit" />
