<%@ Control Language="C#" AutoEventWireup="true" CodeFile="U_report_fee.ascx.cs" Inherits="Control_U_report" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

                <strong>Start Date:</strong>

                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
<strong>End Date:</strong>
                <ajaxToolkit:CalendarExtender ID="TextBox1_CalendarExtender" runat="server" BehaviorID="TextBox1_CalendarExtender" TargetControlID="TextBox1" />
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="TextBox2_CalendarExtender" runat="server" BehaviorID="TextBox2_CalendarExtender" TargetControlID="TextBox2" />
        <asp:Button ID="Button_d" runat="server" Text="Date" OnClick="Button_submit_Click" />
                <br />
                <br />
                <strong>Student:</strong>
                <asp:DropDownList ID="DropDownList_stu" runat="server" AutoPostBack="True">
        </asp:DropDownList>
                <asp:Button ID="Button_s" runat="server" OnClick="Button_s_Click" Text="Student" />
                <br />
                <br />
        <strong>Fee Type:</strong>
        <asp:DropDownList ID="DropDownList_pf" runat="server" AutoPostBack="True">
        </asp:DropDownList>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="PayFor" />
                <br />
                <br />

                <asp:Button ID="Button_all" runat="server" OnClick="Button_all_Click" Text="All Condition" />
                <br />
                <br />
                <br />
                <strong>
                <asp:Label ID="Label_result" runat="server"></asp:Label>
                </strong>
                <br />


<asp:Repeater ID="Repeater1" runat="server">
    <HeaderTemplate>
        <table>
            <tr>
                <td>Payment ID</td>
                <td>Student</td>
                <td>Pay For</td>
                <td>Fee</td>
                <td>Date</td>
            </tr>
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <td><%#Eval("Id") %></td>
            <td><%#Eval("StrStuName") %></td>
            <td><%#Eval("StrPayFor") %></td>
            <td><%#Eval("Fee") %></td>
            <td><%#Eval("Paydt") %></td>
        </tr>
    </ItemTemplate>
    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>