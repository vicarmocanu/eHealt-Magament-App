<%@ Page Title="" Language="C#" MasterPageFile="~/Management/HomeManagement.Master" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="HealthWebUI.Management.User.UserHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">

        <div class="col-md-7">
            <asp:Repeater ID="UserRepeater" runat="server" OnItemCommand="UserRepeater_ItemCommand" >

                <ItemTemplate>

                    <div>
                        <b>First name:</b>
                        <asp:Label ID="fNameLabel" runat="server" Text='<%# Eval("FirstName") %>'></asp:Label>
                        <br />
                        <b>Last name:</b>
                        <asp:Label ID="lNameLabel" runat="server" Text='<%# Eval("LastName") %>'></asp:Label>
                        <br />
                        <b>Username:</b>
                        <asp:Label ID="usernameLabel" runat="server" Text='<%# Eval("UserName") %>'></asp:Label>
                        <br />
                         <b>Password:</b>
                        <asp:Label ID="passwordLabel" runat="server" Text='<%# Eval("Password") %>'></asp:Label>
                        <br />
                        <b>Role:</b>
                        <asp:Label ID="roleLabel" runat="server" Text='<%# Eval("Role") %>'></asp:Label>
                        <br />
                        
                        <asp:Button ID="updateUser" Text="Update User" runat="server" CommandName="updateUser" CommandArgument='<%# Eval("UserName") %>' />
                        <asp:Button ID="deleteUser" Text="Delete User" runat="server" CommandName="deleteUser" CommandArgument='<%# Eval("UserName") %>' />


                    </div>

                </ItemTemplate>

            </asp:Repeater>
        </div>

    </div>

    <br />
    <div class ="row">
        <div class="col-md-2">

            <asp:Button ID="createButton" Text="Add new user" runat="server" OnClick="createButton_Click" />

        </div>
    </div>
</asp:Content>
