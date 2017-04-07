<%@ Control Language="C#" AutoEventWireup="true" CodeFile="U_pet.ascx.cs" Inherits="Control_U_pet" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<table>
    <tr>
        <td>
            <table>
    <tr>
        <td>
            Owener: 
        </td>
        <td>
            
            <asp:Label ID="Label_owener" runat="server"></asp:Label>
            <asp:Label ID="Label_id" runat="server" Visible="False"></asp:Label>
            
        </td>
    </tr>
    <tr>
        <td>
            Name: 
        </td>
        <td>
            <asp:TextBox ID="TextBox_name" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Birthday:
        </td>
        <td>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
            <asp:TextBox ID="TextBox_birth" runat="server"></asp:TextBox>
            <ajaxToolkit:CalendarExtender ID="TextBox_birth_CalendarExtender" runat="server" BehaviorID="TextBox1_CalendarExtender" TargetControlID="TextBox_birth">
            </ajaxToolkit:CalendarExtender>
                            </ContentTemplate>
                    </asp:UpdatePanel>
                    
        </td>
    </tr>
    <tr>
        <td>
            Gender: 
        </td>
        <td>
            
            <asp:DropDownList ID="DropDownList_gender" runat="server">
                <asp:ListItem Selected="True" Value="2">Please select</asp:ListItem>
                <asp:ListItem Value="1">Male</asp:ListItem>
                <asp:ListItem Value="0">Female</asp:ListItem>
            </asp:DropDownList>
            
        </td>
    </tr>
    <tr>
        <td>
            Species: 
        </td>
        <td>
            
            <asp:DropDownList ID="DropDownList_species" runat="server">
            </asp:DropDownList>
            
        </td>
    </tr>
    <tr>
        <td>
            Photo:
        </td>
        <td>
            <asp:Label ID="Label_image0" runat="server" Visible="False"></asp:Label>
            <asp:FileUpload ID="FileUpload_image0" runat="server" />
            <br />
            <asp:Button ID="Upload" runat="server" Text="Button_upload" OnClick="Upload_Click" />
        </td>
    </tr>
</table>
        </td>
        <td>

            <asp:Image ID="Image_0" runat="server" />

        </td>
    </tr>
</table>