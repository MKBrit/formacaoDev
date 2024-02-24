<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editar2.aspx.cs" Inherits="seilaquantasando.Editar2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_id" runat="server" Text="Id"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_id" runat="server" Columns="10" ReadOnly="True"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lbl_matricula" runat="server" Text="Matricula"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_matricula" runat="server" Columns="10" ReadOnly="True"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lbl_proprietario" runat="server" Text="Proprietario"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_proprietario" runat="server" Columns="50"></asp:TextBox>
            <br /><br />  

            <asp:Label ID="lbl_marca" runat="server" Text="Marca"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_marca" runat="server" Columns="10"></asp:TextBox>
            <br /><br />       

            <asp:Label ID="lbl_modelo" runat="server" Text="Modelo"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_modelo" runat="server" Columns="10"></asp:TextBox>
            <br /><br />
            
            <asp:Label ID="lbl_cilindrada" runat="server" Text="Cilindrada"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_cilindrada" runat="server" Columns="10"></asp:TextBox>
            <br /><br />

            <asp:Button ID="btn_alterar" runat="server" Text="Alterar" OnClick="btn_alterar_Click" />
            <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" OnClick="btn_cancelar_Click" />

        </div>
    </form>
</body>
</html>
