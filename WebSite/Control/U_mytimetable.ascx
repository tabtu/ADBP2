<%@ Control Language="C#" AutoEventWireup="true" CodeFile="U_mytimetable.ascx.cs" Inherits="Control_U_timetable" %>
<strong>Day of Week:</strong>
<asp:DropDownList ID="DropDownList_dow" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList_dow_SelectedIndexChanged">
    <asp:ListItem Value="1">Sunday</asp:ListItem>
    <asp:ListItem Value="2">Monday</asp:ListItem>
    <asp:ListItem Value="3">Tuesday</asp:ListItem>
    <asp:ListItem Value="4">Wednesday</asp:ListItem>
    <asp:ListItem Value="5">Thursday</asp:ListItem>
    <asp:ListItem Value="6">Friday</asp:ListItem>
    <asp:ListItem Value="7">Saturday</asp:ListItem>
</asp:DropDownList>

<asp:Repeater ID="Repeater_timetable" runat="server">
    <HeaderTemplate>
        <table>
            <tr>
                <td>Course Name</td>
                <td>Day of Week</td>
                <td>Course Time</td>
            </tr>
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <td><%#Eval("StrCourseName") %></td>
            <td><%#Eval("Dayofweek") %></td>
            <td><%#Eval("StrCourseTime") %></td>
        </tr>
    </ItemTemplate>
    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>