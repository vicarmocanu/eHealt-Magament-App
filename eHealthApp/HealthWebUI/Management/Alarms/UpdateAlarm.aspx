<%@ Page Title="" Language="C#" MasterPageFile="~/Management/HomeManagement.Master" AutoEventWireup="true" CodeBehind="UpdateAlarm.aspx.cs" Inherits="HealthWebUI.Management.Alarms.UpdateAlarm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">

        <div class="col-md-7">
            <h1>
                Alarm name:
                <asp:Label ID="bountTxtAlarmName" runat="server"></asp:Label>
            </h1>

            <br />

            <asp:Panel ID="UpdatePanel" runat="server" Font-Size="Medium" Font-Name="Arial" DefaultButton="updateBtn">
                <p>
                    Type:
                    <br />
                    <asp:Label ID="txtType" runat="server" Width="250px" />
                    <br />
                    Location:
                    <br />
                    <asp:Label ID="txtLocation" runat="server" Width="250px" />
                    <br />
                    Status:
                    <br />
                    <asp:Label ID="txtStatus" runat="server" Width="250px" />
                    <br />
                    <asp:Button ID="updateBtn" runat="server" Text="Update Alarm" ValidationGroup="save" OnClick="updateBtn_Click" />
                    &nbsp;
                    <asp:Button ID="cancelAll" runat="server" Text="Cancel/Return" OnClick="cancelAll_Click" />
                </p>
            </asp:Panel>
        </div>

    </div>

</asp:Content>
