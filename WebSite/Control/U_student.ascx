<%@ Control Language="C#" AutoEventWireup="true" CodeFile="U_student.ascx.cs" Inherits="Control_U_student" %>

<strong>Student:</strong>

<asp:DropDownList ID="DropDownList_stu" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList_stu_SelectedIndexChanged">
        </asp:DropDownList>
<table>
    <tr>
        <td><strong>Student Name: </strong> </td>
        <td>
            <asp:Label ID="Label_name" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td><strong>Student Birthday: </strong> </td>
        <td>
            <asp:Label ID="Label_birth" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td><strong>Join Date: </strong> </td>
        <td>
            <asp:Label ID="Label_jodate" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td><strong>Mobile Number: </strong> </td>
        <td>
            <asp:Label ID="Label_mobile" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td><strong>E-Mail: </strong> </td>
        <td>
            <asp:Label ID="Label_email" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td><strong>Address: </strong> </td>
        <td>
            <asp:Label ID="Label_addr" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <strong>Mother: 
        </strong> 
        </td>
        <td>

            <asp:Label ID="Label1" runat="server"></asp:Label>

            <br />

        </td>
    </tr>
    <tr>
        <td>
            <strong>Father: 
        </strong> 
        </td>
        <td>

            <asp:Label ID="Label2" runat="server"></asp:Label>

            <br />

        </td>
    </tr>
</table>

<br />
<strong>Rank Level:</strong>

<br />
<asp:Repeater ID="Repeater2" runat="server">
    <HeaderTemplate>
        <table>
            <tr>
                <td>Rank Name</td>
                <td>Date</td>
            </tr>
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <td><%#Eval("StrRank") %></td>
            <td><%#Eval("Date").ToString().Split(' ')[0] %></td>
        </tr>
    </ItemTemplate>
    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>


<br />
<strong>Attend Course:</strong><asp:Repeater ID="Repeater3" runat="server">
    <HeaderTemplate>
        <table>
            <tr>
                <td>Course Name</td>
                <td>Date</td>
            </tr>
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <td><%#Eval("StrCourse") %></td>
            <td><%#Eval("Date").ToString().Split(' ')[0] %></td>
        </tr>
    </ItemTemplate>
    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>



<br />

<strong>Fee:</strong>
<br />

<asp:Label ID="Label_result" runat="server"></asp:Label>
<asp:Repeater ID="Repeater1" runat="server">
    <HeaderTemplate>
        <table>
            <tr>
                <td>Payment ID</td>
                <td>Pay For</td>
                <td>Fee</td>
                <td>Date</td>
            </tr>
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <td><%#Eval("Id") %></td>
            <td><%#Eval("StrPayFor") %></td>
            <td><%#Eval("Fee") %></td>
            <td><%#Eval("Paydt").ToString().Split(' ')[0] %></td>
        </tr>
    </ItemTemplate>
    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>


                