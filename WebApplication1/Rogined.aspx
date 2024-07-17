<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rogined.aspx.cs" Inherits="WebApplication1.Rogined" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button runat="server" Text="削除" ID="Dlt_Blt" OnClientClick="return confirm('今ログインしているアカウントを削除します、本当に削除しますか？');" OnClick="Dlt_Blt_Click"></asp:Button><asp:Button runat="server" Text="戻る" ID="Btn_Rtn" OnClick="Btn__Click"></asp:Button>
            <br />
            <asp:GridView runat="server" ID="Grid1" AutoGenerateSelectButton="True">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
