<%@ Page Title="" Language="C#" MasterPageFile="~/Management/HomeManagement.Master" AutoEventWireup="true" CodeBehind="AlarmAttendants.aspx.cs" Inherits="HealthWebUI.Management.User.AlarmAttendants" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">       

        <div class="col-md-7">
            <h1><asp:Label ID="boundTxtAlarmName" runat="server"></asp:Label></h1>

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
                        <asp:Button ID="deleteAssignedUser" Text="Remove assigned user" runat="server" CommandName="deleteAttendant" CommandArgument='<%# Eval("UserName") %>' />
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>

    </div>

</asp:Content>
