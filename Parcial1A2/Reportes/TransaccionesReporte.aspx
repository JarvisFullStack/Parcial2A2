﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransaccionesReporte.aspx.cs" Inherits="Parcial1A2.Reportes.TransaccionesReporte" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
		<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
			
        	<rsweb:ReportViewer ID="reportViewer1" runat="server">
			</rsweb:ReportViewer>
			
        </div>
    </form>
</body>
</html>
