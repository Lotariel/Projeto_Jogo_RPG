<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Batalha.aspx.cs" Inherits="Projeto_Jogo_RPG_WEB.Batalha" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table style="font-family: Arial, Helvetica, sans-serif; font-size:10px; text-align: center;margin-left:35%; margin-right:35%; border-color:#f0f2fe; margin-top:15px;" border="0" width="30%">
    
    <tr style="background-color:#f0f2fe;">
        <td><asp:Button ID="Button1" runat="server" Text="Atacar" /></td>
        <td><asp:Button ID="Button2" runat="server" Text="Habilidades" /></td>
        <td><asp:Button ID="Button3" runat="server" Text="Magias" /></td>
    </tr>
</table>
<br />
<table style="font-family: Arial, Helvetica, sans-serif; font-size:10px; text-align: center;margin-left:35%; margin-right:35%; border-color:#f0f2fe" border="0" width="30%">    
    <tr style="background-color:#f0f2fe;">
        <td><asp:Button ID="Button4" runat="server" Text="Defender" /></td>
        <td><asp:Button ID="Button5" runat="server" Text="Usar Itens" /></td>
    </tr>
</table>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
    </style>
</asp:Content>
