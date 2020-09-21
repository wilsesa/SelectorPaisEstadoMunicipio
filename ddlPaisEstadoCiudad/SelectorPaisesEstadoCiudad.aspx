<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectorPaisesEstadoCiudad.aspx.cs" Inherits="ddlPaisEstadoCiudad.SelectorPaisesEstadoCiudad" %>

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
            <asp:DropDownList ID="dropPais" runat="server" AutoPostBack="True" OnSelectedIndexChanged="PaisSelecionado">
            </asp:DropDownList>
            <br />
            <br />
            Estado:<br />
            <asp:DropDownList ID="dropEstado" runat="server" AutoPostBack="True" OnSelectedIndexChanged="EstadoSeleccionado">
            </asp:DropDownList>
            <br />
            <br />
            Ciudad:<br />
            <asp:DropDownList ID="dropCiudad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CiudadSelecionada"  >
            </asp:DropDownList>
            <br />
            <br />
            Municipio:<br />
            <asp:DropDownList runat="server" ID ="dropMunicipio" AutoPostBack="true">
            </asp:DropDownList>

        </div>
    </form>
</body>
</html>
