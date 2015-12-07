<%@ Page Title="" Language="C#" MasterPageFile="~/Management/HomeManagement.Master" AutoEventWireup="true" CodeBehind="InsertUser.aspx.cs" Inherits="HealthWebUI.Management.User.InsertUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        
        <div class="col-md-7">            
            <asp:Panel runat="server" ID="AddUserPanel" DefaultButton="btnAddUser" Font-Size="Medium" Font-Name="Arial">
                <b>First Name:</b>
                <asp:TextBox runat="server" ID="txtFirstName" Width="250px"></asp:TextBox>
                <br />
                <b>Last Name:</b>
                <asp:TextBox runat="server" ID="txtLastName" Width="250px"></asp:TextBox>
                <br />
                <b>Username:</b>
                <asp:TextBox runat="server" ID="txtUsername" Width="250px"></asp:TextBox>
                <br />
                <b>Password:</b>
                <asp:TextBox runat="server" ID="txtPassword" Width="250px"></asp:TextBox>
                <br />
                <b>Type:</b>
                <asp:TextBox runat="server" ID="txtType" Width="250px"></asp:TextBox>
                <br />
                <asp:Button runat="server" ID="btnAddUser" Text="Create" OnClick="btnAddUser_OnClick" ValidationGroup="save" />
                &nbsp;
                <asp:Button runat="server" ID="btnCancelAll" Text="Cancel/Return" OnClick="btnCancelAll_Click" />
            </asp:Panel>
        </div>

    </div>
     
</asp:Content>