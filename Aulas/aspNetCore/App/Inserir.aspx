<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inserir.aspx.cs" Inherits="tecnobispo.Inserir" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_matricula" runat="server" Text="Matricula"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_matricula" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lbl_proprietario" runat="server" Text="Proprietario"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_proprietario" runat="server"></asp:TextBox>
            <br /><br />  
            
            <asp:Label ID="lbl_marca" runat="server" Text="Marca"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_marca" runat="server"></asp:TextBox>
            <br /><br />       
            
            <asp:Label ID="lbl_modelo" runat="server" Text="Modelo"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_modelo" runat="server"></asp:TextBox>
            <br /><br />
                        
            <asp:Label ID="lbl_cilindrada" runat="server" Text="Cilindrada"></asp:Label>&nbsp;
            <asp:TextBox ID="txt_cilindrada" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Button ID="btn1" runat="server" Text="Inserir" OnClick="btn1_Click" />&nbsp;
            <asp:Button ID="btn_voltar" runat="server" Text="Voltar" OnClick="btn_voltar_Click" />

        </div>
    </form>
</body>
</html>
