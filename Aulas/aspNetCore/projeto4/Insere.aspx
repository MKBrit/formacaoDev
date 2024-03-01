<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insere.aspx.cs" Inherits="projeto4.Insere" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_nome" runat="server" Text="Nome:"></asp:Label>&nbsp;
            <asp:Textbox ID="txt_nome" runat="server"></asp:Textbox>
            <br /> <br />
            <asp:Label ID="lbl_npag" runat="server" Text="Nº de Páginas:"></asp:Label>&nbsp;
            <asp:Textbox ID="txt_npag" runat="server"></asp:Textbox>
            <br /> <br />
            <asp:Label ID="lbl_tam" runat="server" Text="Tamanho:"></asp:Label>&nbsp;
            <asp:Textbox ID="txt_tam" runat="server"></asp:Textbox>
            <br /> <br />
            <asp:Button ID="btn_insere" runat="server" Text="Inserir" OnClick="btn_insere_Click" />

        </div>
    </form>
</body>
</html>
