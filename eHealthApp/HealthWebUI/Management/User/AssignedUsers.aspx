<%@ Page Title="" Language="C#" MasterPageFile="~/Management/HomeManagement.Master" AutoEventWireup="true" CodeBehind="AssignedUsers.aspx.cs" Inherits="HealthWebUI.Management.User.TaskAttendant" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">       

        <div class="col-md-7">
            <h1><asp:Label ID="boundTxtTaskName" runat="server"></asp:Label></h1>

            <br />

            <asp:Repeater ID="UserRepeater" runat="server" OnItemCommand="UserRepeater_ItemCommand">
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
                        <b>Role:</b>
                        <asp:Label ID="roleLabel" runat="server" Text='<%# Eval("Role") %>'></asp:Label>
                        <br />
                        <asp:Button ID="deleteAssignedUser" Text="Remove assigned user" runat="server" CommandName="deleteAssignedUser" CommandArgument='<%# Eval("UserName") %>' />
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>

    </div>

    <br />

    <div class ="row">

        <div class="col-md-2">

            <asp:Button ID="addAttendant" Text="Add new attendant" runat="server" OnClick="addAttendant_Click" />

        </div>

    </div>

</asp:Content>
