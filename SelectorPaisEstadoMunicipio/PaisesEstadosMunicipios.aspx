<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaisesEstadosMunicipios.aspx.cs" Inherits="SelectorPaisEstadoMunicipio.PaisesEstadosMunicipios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Pais:<br />
            <asp:DropDownList ID="ddlPais" runat="server" AutoPostBack="True" Height="16px" OnSelectedIndexChanged="PaisSeleccionado">
            </asp:DropDownList>
            <br />
            Estado:<br />
            <asp:DropDownList ID="ddlEstado" runat="server" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            Municipio:<br />
            <asp:DropDownList ID="ddlMunicipio" runat="server" AutoPostBack="True" >
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
