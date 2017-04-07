<%@ Control Language="C#" AutoEventWireup="true" CodeFile="U_fee.ascx.cs" Inherits="Control_AddFee" %>

<table>
    <tr>
        <td>
            Student: 
        </td>
        <td>
            <asp:DropDownList ID="DropDownList_stu" runat="server"></asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            Pay For: 
        </td>
        <td>
            <asp:DropDownList ID="DropDownList_pf" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            Fee: 
        </td>
        <td>
            <asp:TextBox ID="TextBox_fee" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>