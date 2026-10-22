<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExemploWebForm.aspx.cs" Inherits="ExemploAppWeb.ExemploWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 161px">
    <form id="form1" runat="server">
        <h1>Exemplo Web Form</h1>

        
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Clique aqui" />
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>

        
    </form>
</body>
</html>
