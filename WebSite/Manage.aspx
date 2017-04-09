<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage.aspx.cs" Inherits="Manage" %>

<%@ Register src="Control/U_Fee.ascx" tagname="U_Fee" tagprefix="uc1" %>
<%@ Register src="Control/U_mytimetable.ascx" tagname="U_mytimetable" tagprefix="uc2" %>
<%@ Register src="Control/U_rank.ascx" tagname="U_rank" tagprefix="uc3" %>
<%@ Register src="Control/U_report_fee.ascx" tagname="U_report_fee" tagprefix="uc4" %>
<%@ Register src="Control/U_requirement.ascx" tagname="U_requirement" tagprefix="uc5" %>
<%@ Register src="Control/U_student.ascx" tagname="U_student" tagprefix="uc6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Button ID="Button_report" runat="server" Text="Fee Report" OnClick="Button_report_Click" />
                </td>
                <td>
                    <asp:Button ID="Button_fee" runat="server" Text="Add Fee" OnClick="Button_fee_Click" />
                </td>
                <td>

                    <asp:Button ID="Button_atd" runat="server" Text="Add Attendance" OnClick="Button_atd_Click" />

                </td>
                <td>
                    <asp:Button ID="Button_student" runat="server" Text="Student Report" OnClick="Button_student_Click" />
                </td>
                <td>
                    <asp:Button ID="Button_timetable" runat="server" Text="Timetable" OnClick="Button_timetable_Click" />
                    
                </td>
                <td>
                    <asp:Button ID="Button_rank" runat="server" Text="Requirement" OnClick="Button_rank_Click" />
                </td>
            </tr>
        </table>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">

        </asp:UpdatePanel>
        
        <uc4:U_report_fee ID="U_report_fee1" runat="server" />
        <uc3:U_rank ID="U_rank1" runat="server" />
                        <uc1:U_Fee ID="U_Fee1" runat="server" />
                <uc2:U_mytimetable ID="U_mytimetable1" runat="server" />
            
        <uc6:U_student ID="U_student1" runat="server" />
        <uc5:U_requirement ID="U_requirement1" runat="server" />
        <br />
        
        <br />
    </div>
    </form>
</body>
</html>
