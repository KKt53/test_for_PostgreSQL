<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="WebApplication1.test" %>

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
            <asp:Button runat="server" Text="ログインボタン" OnClientClick="Button1_Click" OnClick="Button1_Click" ID="Bt_1"></asp:Button><asp:Label runat="server" ID="Label3"></asp:Label>
            <br />
            <asp:Button runat="server" Text="会員登録" ID="Bt_2" OnClick="Bt_2_Click"></asp:Button>
            <br />
            <asp:GridView runat="server" ID="Grid1" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView_SelectedIndexChanged">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
