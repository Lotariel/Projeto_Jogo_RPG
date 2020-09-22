<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Status.aspx.cs" Inherits="Projeto_Jogo_RPG_WEB.Status" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <table style="font-family: Arial, Helvetica, sans-serif; font-size:10px; text-align: center; margin-left:20%; margin-right:20%; margin-top:15px;" border="1" width="60%">
    <thead>
        <tr style="background-color:White;">
            <td style="font-size: 10px; font-family: Arial, Helvetica, sans-serif; font-weight: bold;" class="auto-style11" colspan="2">ATRIBUTOS</td>
        </tr>
    </thead>

    <tr style="background-color:White;">
        <td>Força: </td>
        <td rowspan="6"><asp:Button ID="Button1" runat="server" Text="Button" /></td>
    </tr>
    <tr style="background-color:White;">
        <td>Magia: </td>
    </tr>
    <tr style="background-color:White;">
        <td>Foco: </td>
    </tr>
    <tr style="background-color:White;">
        <td>Vitalidade: </td>
    </tr>
    <tr style="background-color:White;">
        <td>Aura: </td>
    </tr>
    <tr style="background-color:White;">
        <td>Velocidade: </td>
    </tr>

</table>

</asp:Content>
