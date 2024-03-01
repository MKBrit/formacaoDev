<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="F_alterar.aspx.cs" Inherits="projeto_sql.F_alterar" %>

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
<asp:FormView runat="server" DataKeyNames="Id" DataSourceID="SqlDataSource1" OnPageIndexChanging="Unnamed1_PageIndexChanging">
    <EditItemTemplate>
        Id:
        <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
        <br />
        nome:
        <asp:TextBox ID="nomeTextBox" runat="server" Text='<%# Bind("nome") %>' />
        <br />
        login:
        <asp:TextBox ID="loginTextBox" runat="server" Text='<%# Bind("login") %>' />
        <br />
        email:
        <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Bind("email") %>' />
        <br />
        <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
        &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
    </EditItemTemplate>
    <InsertItemTemplate>
        nome:
        <asp:TextBox ID="nomeTextBox" runat="server" Text='<%# Bind("nome") %>' />
        <br />
        login:
        <asp:TextBox ID="loginTextBox" runat="server" Text='<%# Bind("login") %>' />
        <br />
        email:
        <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Bind("email") %>' />
        <br />
        <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
        &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
    </InsertItemTemplate>
    <ItemTemplate>
        Id:
        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
        <br />
        nome:
        <asp:Label ID="nomeLabel" runat="server" Text='<%# Bind("nome") %>' />
        <br />
        login:
        <asp:Label ID="loginLabel" runat="server" Text='<%# Bind("login") %>' />
        <br />
        email:
        <asp:Label ID="emailLabel" runat="server" Text='<%# Bind("email") %>' />
        <br />

        <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />
        &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="Delete" />
        &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
    </ItemTemplate>
    </asp:FormView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [Table] WHERE [Id] = @original_Id AND (([nome] = @original_nome) OR ([nome] IS NULL AND @original_nome IS NULL)) AND (([login] = @original_login) OR ([login] IS NULL AND @original_login IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL))" InsertCommand="INSERT INTO [Table] ([nome], [login], [email]) VALUES (@nome, @login, @email)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [Id], [nome], [login], [email] FROM [Table]" UpdateCommand="UPDATE [Table] SET [nome] = @nome, [login] = @login, [email] = @email WHERE [Id] = @original_Id AND (([nome] = @original_nome) OR ([nome] IS NULL AND @original_nome IS NULL)) AND (([login] = @original_login) OR ([login] IS NULL AND @original_login IS NULL)) AND (([email] = @original_email) OR ([email] IS NULL AND @original_email IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="original_Id" Type="Int32" />
            <asp:Parameter Name="original_nome" Type="String" />
            <asp:Parameter Name="original_login" Type="String" />
            <asp:Parameter Name="original_email" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="nome" Type="String" />
            <asp:Parameter Name="login" Type="String" />
            <asp:Parameter Name="email" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="nome" Type="String" />
            <asp:Parameter Name="login" Type="String" />
            <asp:Parameter Name="email" Type="String" />
            <asp:Parameter Name="original_Id" Type="Int32" />
            <asp:Parameter Name="original_nome" Type="String" />
            <asp:Parameter Name="original_login" Type="String" />
            <asp:Parameter Name="original_email" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
    </form>

