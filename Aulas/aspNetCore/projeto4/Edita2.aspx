<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edita2.aspx.cs" Inherits="projeto4.Edita2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_id" runat="server" Text="Id:"><</asp:Label>&nbsp
            <asp:TextBox ID="txt_id" runat="server" Columns="3" ReadOnly="true"></asp:TextBox>
            <br /> <br />
            <asp:Label ID="lbl_nome" runat="server" Text="Nome:"></asp:Label>&nbsp;
            <asp:Textbox ID="txt_nome" runat="server"></asp:Textbox>
            <br /> <br />
            <asp:Label ID="lbl_npag" runat="server" Text="Nº de Páginas:"></asp:Label>&nbsp;
            <asp:Textbox ID="txt_npag" runat="server"></asp:Textbox>
            <br /> <br />
            <asp:Label ID="lbl_tam" runat="server" Text="Tamanho:"></asp:Label>&nbsp;
            <asp:Textbox ID="txt_tam" runat="server"></asp:Textbox>
            <br /> <br />
            <asp:Button ID="btn_alterar" runat="server" Text="Alterar" OnClick="btn_alterar_Click" />
            <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" />

        </div>
    </form>
</body>
</html>
