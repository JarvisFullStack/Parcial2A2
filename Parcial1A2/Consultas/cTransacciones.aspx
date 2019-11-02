<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="cTransacciones.aspx.cs" Inherits="Parcial1A2.Consultas.cTransacciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
<div class="panel panel-primary">
        <div class="panel-heading">Consulta de Categorias</div>
        <div class="panel-body">
    
            <div class="row">
                <div class="col-md-2">
                    <asp:DropDownList ID="BuscarPorDropDownList" runat="server" CssClass="form-control input-sm" >
                        <asp:ListItem>Código Cliente</asp:ListItem>
                        <asp:ListItem>Monto</asp:ListItem>                        
                    </asp:DropDownList>
                </div>
                <div class="col-md-6">
                    <asp:TextBox ID="FiltroTextBox" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                </div>
                <div class="col-md-4">
                     <asp:Button ID="BuscarButton" runat="server" CausesValidation="false" UseSubmitBehavior="false" Class="btn btn-success input-sm" Text="Buscar" OnClick="BuscarButton_Click" />                                       
                </div>
            </div>


            <div class="col-md-12">
                <asp:GridView ID="DatosGridView"
                    runat="server"
                    class="table table-condensed table-bordered table-responsive"
                    CellPadding="4" ForeColor="#333333" GridLines="None">

                    <AlternatingRowStyle BackColor="White" />
                    <Columns>                       
                    </Columns>
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#EFF3FB" />
                </asp:GridView>
            </div>

			<asp:Button ID="VerReporte" runat="server" CausesValidation="false" UseSubmitBehavior="false" Class="btn btn-success input-sm" Text="Ver Reporte" OnClick="VerReporteButton_Click" />                                       
        </div>
    </div>

</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>
