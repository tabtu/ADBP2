<%@ Control Language="C#" AutoEventWireup="true" CodeFile="U_fee.ascx.cs" Inherits="Control_AddFee" %>

<table>
    <tr>
        <td>
            <strong>Student: 
        </strong> 
        </td>
        <td>
            <asp:DropDownList ID="DropDownList_stu" runat="server"></asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <strong>Pay For: 
        </strong> 
        </td>
        <td>
            <asp:DropDownList ID="DropDownList_pf" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <strong>Fee: 
        </strong> 
        </td>
        <td>
            <asp:TextBox ID="TextBox_fee" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td></td>
        <td>

            <asp:Button ID="Button_submit" runat="server" OnClick="Button_submit_Click" Text="Submit" />

        </td>
    </tr>
</table>