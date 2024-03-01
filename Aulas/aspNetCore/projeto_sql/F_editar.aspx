<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="F_editar.aspx.cs" Inherits="projeto_sql.F_editar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
</body>
</html>
<asp:FormView runat="server" AllowPaging="True" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1" GridLines="Horizontal">
    <EditItemTemplate>
        nome:
        <asp:TextBox ID="nomeTextBox" runat="server" Text='<%# Bind("nome") %>' />
        <br />
        login:
        <asp:TextBox ID="loginTextBox" runat="server" Text='<%# Bind("login") %>' />
        <br />
        pass:
        <asp:TextBox ID="passTextBox" runat="server" Text='<%# Bind("pass") %>' />
        <br />
        email:
        <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Bind("email") %>' />
        <br />
        <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
        &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
    </EditItemTemplate>
    <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
    <InsertItemTemplate>
        nome:
        <asp:TextBox ID="nomeTextBox" runat="server" Text='<%# Bind("nome") %>' />
        <br />
        login:
        <asp:TextBox ID="loginTextBox" runat="server" Text='<%# Bind("login") %>' />
        <br />
        pass:
        <asp:TextBox ID="passTextBox" runat="server" Text='<%# Bind("pass") %>' />
        <br />
        email:
        <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Bind("email") %>' />
        <br />
        <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
        &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
    </InsertItemTemplate>
    <ItemTemplate>
        nome:
        <asp:Label ID="nomeLabel" runat="server" Text='<%# Bind("nome") %>' />
        <br />
        login:
        <asp:Label ID="loginLabel" runat="server" Text='<%# Bind("login") %>' />
        <br />
        pass:
        <asp:Label ID="passLabel" runat="server" Text='<%# Bind("pass") %>' />
        <br />
        email:
        <asp:Label ID="emailLabel" runat="server" Text='<%# Bind("email") %>' />
        <br />

    </ItemTemplate>
    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
    </asp:FormView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Table]" InsertCommand="INSERT INTO [Table] (nome, login, pass, email) VALUES (,,,)" SelectCommand="SELECT nome, login, pass, email FROM [Table]" UpdateCommand="UPDATE [Table] SET nome =, login =, email =, pass ="></asp:SqlDataSource>
    </form>

