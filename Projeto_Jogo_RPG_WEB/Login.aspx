<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projeto_Jogo_RPG_WEB.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<link href="CSS/Estilo.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body>
	<!--Tag para formar um quadro em volta do formulário de login-->
	<div id="fieldQuadro">
		<fieldset id="quadroDeLogin" >
			<!--Tag para legenda do quadro de login-->
			<legend align="center">Área de login</legend>
			<!--Formulário de login-->
			<form id="frmTelaLogin" runat="server" align="center">
				<!--Label identificando à que se refere o textbox-->
				<asp:Label ID="lblLogin" runat="server" Text="Login"></asp:Label> <br />
				<!--TextBox destinado à entrada do login de usuário-->
				<asp:TextBox ID="txtLogin" runat="server"></asp:TextBox> <br /> <br />

				<!--
				<asp:Label ID="lblSenha" runat="server" Text="Senha"></asp:Label> <br />
			    <asp:TextBox ID="txtSenha" runat="server" Width="118px"></asp:TextBox> <br /> <br />
				-->

				<!--Botão para iniciar a validação de login e inicializar a apresentação da ficha de personagem-->
				<asp:Button ID="btnLogar" runat="server" Text="Entrar" OnClick="btnLogar_Click" />
				<br /> <br />

				<!--Label que indica se a conexão foi feita com sucesso ou não-->
				<asp:Label ID="lblConexao" runat="server" Text=" "></asp:Label>
			</form>
		</fieldset>
	</div>
</body>
</html>
