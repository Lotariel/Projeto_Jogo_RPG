<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Batalha.aspx.cs" Inherits="Projeto_Jogo_RPG_WEB.Batalha" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style11 {
        height: 30px;
    }
    .auto-style12 {
        width: 100%;
        height: 372px;
    }
    .auto-style13 {
        height: 17px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style12">
    <tr>
        <td class="auto-style4" style="text-align: center; vertical-align: top; border-style: solid; border-width: thin">
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style11">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:Button ID="btn_reduzirHP" runat="server" Text="ReduzirHP" />
                        <asp:Button ID="btn_reduzirMP" runat="server" Text="ReduzirMP" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btn_iniciativa" runat="server" Text="Iniciativa" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </td>
        <td class="auto-style4" style="text-align: center; vertical-align: top; border-style: solid; border-width: thin">
            <br />
            <asp:TextBox ID="txt_textogeral" runat="server" BackColor="#CCFFFF" Height="121px" TextMode="MultiLine" Width="229px"></asp:TextBox>
            <br />
        </td>
        <td class="auto-style4" style="text-align: center; vertical-align: top; border-style: solid; border-width: thin">&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style4" style="text-align: center; vertical-align: top; border-style: solid; border-width: thin">
            <asp:Label ID="Label22" runat="server" Font-Size="XX-Large" Text="ATAQUES"></asp:Label>
            <br />
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btn_atacar" runat="server" Text="Atacar" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
        </td>
        <td class="auto-style4" style="text-align: center; vertical-align: top; border-style: solid; border-width: thin">
            <asp:Label ID="Label23" runat="server" Font-Size="XX-Large" Text="HABILIDADES"></asp:Label>
            <br />
            <table style="width:100%;">
                <tr>
                    <td>
                        <asp:Button ID="btn_corteduplo" runat="server" Text="Corte Duplo" />
                        <asp:Button ID="btn_tiroprecisao" runat="server" Text="Tiro de Precisão" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
        </td>
        <td class="auto-style4" style="text-align: center; vertical-align: top; border-style: solid; border-width: thin">
            <asp:Label ID="Label24" runat="server" Font-Size="XX-Large" Text="MAGIAS"></asp:Label>
            <br />
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btn_bolafogo" runat="server" Text="Bola de Fogo" />
                        <asp:Button ID="btn_espinhogelo" runat="server" Text="Espinho de Gelo" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
        </td>
    </tr>
    <tr>
        <td class="auto-style4" style="text-align: center; vertical-align: top; border-style: solid; border-width: thin">
            <asp:Label ID="Label25" runat="server" Font-Size="XX-Large" Text="DEFESAS"></asp:Label>
            <br />
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btn_esquivar" runat="server" Text="Esquivar" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
        </td>
        <td class="auto-style4" style="text-align: center; vertical-align: top; border-style: solid; border-width: thin">
            <asp:Label ID="Label26" runat="server" Font-Size="XX-Large" Text="PERICIAS"></asp:Label>
            <br />
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btn_analise" runat="server" Text="Análise" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <br />
        </td>
        <td class="auto-style4" style="text-align: center; vertical-align: top; border-style: solid; border-width: thin">
            <asp:Label ID="Label27" runat="server" Font-Size="XX-Large" Text="ITENS"></asp:Label>
            <br />
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13"></td>
                    <td class="auto-style13"></td>
                    <td class="auto-style13"></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Poção Pequena" />
&nbsp;X
                        <asp:Label ID="LBL_quantidade_pocao_pequena" runat="server" Text="0"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Elixir Pequeno" />
&nbsp;X
                        <asp:Label ID="LBL_QUANTIDADE_ELIXIR_PEQUENO" runat="server" Text="0"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </td>
    </tr>
</table>
</asp:Content>
