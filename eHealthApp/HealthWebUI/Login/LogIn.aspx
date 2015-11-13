<%@ Page Title="" Language="C#" MasterPageFile="~/Login/LogInMaster.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="HealthWebUI.Login.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">   
    <div class="row">
        <div class="col-md-6">
            <asp:Panel ID="LoginPanel" runat="server" Font-Size="Medium">
                <p>
                    Username:
                    <br />
                    <asp:TextBox ID="usernameTxt" runat="server" Width="250px" />

                    <br />
                    Password:
                    <br />
                    <asp:TextBox ID="passwordTxt" runat="server" Width="250px" />

                </p>
                <asp:Button ID="btnLogin" runat="server" Text="Login" ValidationGroup="save" OnClick="btnLogin_Click" />                
            </asp:Panel>
        </div>
    </div>
</asp:Content>
