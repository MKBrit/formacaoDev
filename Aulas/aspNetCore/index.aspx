<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="seilaquantasando.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TecnoBispo lda</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <img width="200" src="download.jpeg" /><br /><br />
            <asp:Button ID="btn_inserir" runat="server" text="Inserir" OnClick="btn_inserir_Click" />&nbsp;
            <asp:Button ID="btn_listar" runat="server" text="Listar" OnClick="btn_listar_Click" />&nbsp;
            <asp:Button ID="btn_editar" runat="server" text="Editar" OnClick="btn_editar_Click" />;
        </div>
    </form>
</body>
</html>
