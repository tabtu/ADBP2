<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReportFee.aspx.cs" Inherits="ReportFee" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>


<%@ Register src="Control/U_report_fee.ascx" tagname="U_report_fee" tagprefix="uc1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <uc1:U_report_fee ID="U_report_fee1" runat="server" />

    </div>
    </form>
</body>
</html>
