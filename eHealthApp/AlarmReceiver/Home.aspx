<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AlarmReceiver.Home" %>

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
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="Alarm attendant home page." />
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
        
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <asp:Timer ID="Timer1" runat="server" Interval="15000" OnTick="Timer1_Tick" Enabled="true"/>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" />
            </Triggers>

            <ContentTemplate>
                <asp:Label ID="PublishedAlarm" runat="server"></asp:Label>
            </ContentTemplate>

        </asp:UpdatePanel>
        <br />
        <br />

        <asp:Label runat="server" ID="TestLabel"></asp:Label>
        

        <asp:Button runat="server" ID="attendBtn" OnClick="attendBtn_Click" />
        <br />
        <asp:Label runat="server" ID="SecretLabel" Visible="false"></asp:Label>

        Page loaded at <asp:Label ID="PageTime" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
