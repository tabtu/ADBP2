﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="U_login.ascx.cs" Inherits="Control_U_login" %>

<table>

    <tr>
        <td>
            Username:
        </td>
        <td>
            <asp:TextBox ID="TextBox_usr" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Password:
        </td>
        <td>
            <asp:TextBox ID="TextBox_pwd" runat="server" TextMode="Password"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td></td>
        <td>
            <asp:Button ID="Button_login" runat="server" OnClick="Button_login_Click" Text="Login" />
        </td>
    </tr>
</table>

