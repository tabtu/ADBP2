<%@ Control Language="C#" AutoEventWireup="true" CodeFile="U_requirement.ascx.cs" Inherits="Control_U_requirement" %>
<strong>Rank Level:</strong>
<asp:DropDownList ID="DropDownList_req" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList_req_SelectedIndexChanged">
</asp:DropDownList>
<br />
<br />
<strong>Requirement: </strong> <br />
<asp:Repeater ID="Repeater_req" runat="server">
    <HeaderTemplate>
        <table>
            <tr>
                <td>Course Name</td>
                <td>Description</td>
            </tr>
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <td><%#Eval("StrCourseName") %></td>
            <td><%#Eval("Description") %></td>
        </tr>
    </ItemTemplate>
    <FooterTemplate>
        </table>
    </FooterTemplate>
</asp:Repeater>