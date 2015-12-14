<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AlarmPublisher.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }

        input[type="submit"]
        {
            width: 100px;
            height: 100px;
            background-color: red;

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Welcome
        <asp:LoginName ID="LoginName" runat="server" Font-Bold="true" />
        <br />
        <br />
        <asp:LoginStatus ID="LoginStatus" runat="server" />
        <br />
        <br />

        <asp:Button ID="panicButton"  runat="server" OnClick="panicButton_Click" Font-Bold="true" Text="PANIC!" />
    </div>
    </form>
</body>
</html>
