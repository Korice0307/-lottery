<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        #wrapper{
            width:600px;
            margin:10px auto;
            border:1px solid #f00;
            padding:10px;
            text-align:center;
            font-size:14px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="wrapper">
            <img src="jpg/TREE.jpg" />
            <br />
            <asp:Label ID="Date" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Welcome" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="GiftShow" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="EndShow" runat="server" Text="抽獎" OnClick="EndShow_Click" />
            <br />
            <asp:Image ID="Image1" runat="server" />
        </div>
    </form>
</body>
</html>
