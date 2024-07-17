<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test_2.aspx.cs" Inherits="WebApplication1.test_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="名前:" ID="Label1"></asp:Label>
            <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="PASS:" ID="Label2"></asp:Label>
            <asp:TextBox runat="server" ID="TextBox2"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="出身地:" ID="Label3"></asp:Label>
            <asp:TextBox runat="server" ID="TextBox3"></asp:TextBox>
            <br />
            <asp:Button runat="server" Text="会員登録" OnClientClick="Button1_Click" OnClick="Button1_Click" ID="Bt_1"></asp:Button><asp:Button runat="server" Text="戻る" ID="Button2" OnClick="Button2_Click"></asp:Button>
            <br />
            <asp:Label runat="server" Text="ここは会員登録画面です" Font-Bold="True" Font-Size="X-Large" ID="Label4"></asp:Label>
        </div>
    </form>
</body>
</html>
