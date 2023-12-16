<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Encuesta.aspx.cs" Inherits="ExamenFinalPrograII_Encuesta.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="labelID" runat="server" Text="Numero de encuesta"></asp:Label>
    <br />
    <br />
    <asp:Label ID="labelNom" runat="server" Text="Nombre"></asp:Label>
    <asp:TextBox ID="TextBoxNOM" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="labelEdad" runat="server" Text="Edad"></asp:Label>
    <asp:TextBox ID="TextBoxEdad" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="labelCorreo" runat="server" Text="Correo"></asp:Label>
    <asp:TextBox type="email" class="form-control" ID="TextBoxCorreo" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="labelPartido" runat="server" Text="Partido"></asp:Label>
    <asp:DropDownList ID="DDLPartido" runat="server">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>PUSC</asp:ListItem>
        <asp:ListItem>PLN</asp:ListItem>
        <asp:ListItem>PAC</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button  type="button" class="btn btn-success" ID="ButtonSalvar" runat="server" Text="Salvar Encuesta" OnClick="ButtonSalvar_Click" />
</asp:Content>
