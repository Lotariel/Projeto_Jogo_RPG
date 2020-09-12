<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projeto_Jogo_RPG_WEB.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<link href="CSS/Estilo.css" rel="stylesheet" />
    <title></title>
	<style type="text/css">
		#frmTelaLogin {
			width: 226px;
		}
	</style>
</head>
<body>
    <form id="frmTelaLogin" runat="server" align="center">
        <fieldset id="quadroDeLogin">
			<legend align="center">Área de login</legend>
			<asp:Label ID="lblLogin" runat="server" Text="Login"></asp:Label> <br />
			<asp:TextBox ID="txtLogin" runat="server"></asp:TextBox> <br /> <br />
			<asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label> <br />
            <asp:TextBox ID="txtSenha" runat="server" Width="118px"></asp:TextBox> <br /> <br />
			<asp:Button ID="btnLogar" runat="server" Text="Entrar" />
			<br />
			<br />
        </fieldset>
    </form>
</body>
</html>
