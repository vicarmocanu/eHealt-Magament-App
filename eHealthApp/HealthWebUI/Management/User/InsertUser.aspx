<%@ Page Title="" Language="C#" MasterPageFile="~/Management/HomeManagement.Master" AutoEventWireup="true" CodeBehind="InsertUser.aspx.cs" Inherits="HealthWebUI.Management.User.InsertUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        
        <div class="col-md-7">
            
            <asp:Panel runat="server" ID="AddUserPanel" DefaultButton="btnAddUser" Font-Size="Medium" >

                <b>First Name:</b>
                <asp:TextBox runat="server" ID="txtFirstName"></asp:TextBox>

                <br />

                <b>Last Name:</b>
                <asp:TextBox runat="server" ID="txtLastName"></asp:TextBox>

                <br />

                <b>Username:</b>
                <asp:TextBox runat="server" ID="txtUsername"></asp:TextBox>

                <br />

                <b>Password:</b>
                <asp:TextBox runat="server" ID="txtPassword"></asp:TextBox>

                <br />

                <b>Type:</b>
                <asp:TextBox runat="server" ID="txtType"></asp:TextBox>

                <br />

                <asp:Button runat="server" ID="btnAddUser" Text="Create" OnClick="btnAddUser_OnClick" ValidationGroup="save" />

            </asp:Panel>

        </div>

    </div> 
</asp:Content>
