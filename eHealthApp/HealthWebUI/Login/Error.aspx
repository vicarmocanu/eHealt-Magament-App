<%@ Page Title="" Language="C#" MasterPageFile="~/Login/LogInMaster.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="HealthWebUI.Login.Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">

        <div class="col-md-6">

            <asp:Panel ID="errorMessagePanel" runat="server" Font-Size="Medium">

                <p> Your username/password might be incorrect. Please type in again your correct username/password.</p>
                OR GRAB A COFFE 
                <asp:Button ID="returnButton" runat="server" Text="Return" OnClick="returnButton_Click" />

            </asp:Panel>

        </div>

    </div>

</asp:Content>
