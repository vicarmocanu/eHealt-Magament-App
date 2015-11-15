<%@ Page Title="" Language="C#" MasterPageFile="~/Management/HomeManagement.Master" AutoEventWireup="true" CodeBehind="UpdateUser.aspx.cs" Inherits="HealthWebUI.Management.User.UpdateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">

        <div class="col-md-7">

            <asp:Panel ID="UpdatePanel" runat="server" Font-Size="Medium" Font-Name="Arial">

                <p>

                    FirstName 
                    <br />
                    <asp:TextBox id="txtFName" runat="server" Width="250px" />

                    <br />

                    LastName
                    <br />
                    <asp:TextBox ID="txtLName" runat="server" Width="250px" />
           
                    <br />

                    UserName
                    <br />
                    <asp:Label ID="boundTxtUserName" runat="server" Width="250px" />
              
                    <br />

                    Password
                    <br />
                    <asp:TextBox ID="txtPassword" runat="server" Width="250px" />
                    
                    <br />

                    Role
                    <br />
                    <asp:TextBox ID="txtRole" runat="server" Width="250px" />
                    
                    <br />

                    <asp:Button ID="updateBtn" runat="server" Text="Update Session" ValidationGroup="save" OnClick="updateBtn_Click" />
                    &nbsp;
                    <asp:Button ID="cancelUser" runat="server" Text="Cancel session" OnClick="cancelUser_Click" />
                    &nbsp;
                    <asp:Button ID="cancelAll" runat="server" Text="Cancel/Return" OnClick="cancelAll_Click" />


                </p>

            </asp:Panel>

        </div>

    </div>
</asp:Content>
