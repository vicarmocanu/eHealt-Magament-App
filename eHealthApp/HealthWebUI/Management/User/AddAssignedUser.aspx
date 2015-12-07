<%@ Page Title="" Language="C#" MasterPageFile="~/Management/HomeManagement.Master" AutoEventWireup="true" CodeBehind="AddAssignedUser.aspx.cs" Inherits="HealthWebUI.Management.User.AddAssignedUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        
        <div class="col-md-7">
            <h1>
                Task name:
                <asp:Label runat="server" ID="bountTxtTaskName"></asp:Label>
            </h1>

            <br />
            
            <asp:Panel runat="server" ID="addAssignedUserPanel" DefaultButton="btnAddAssignedUser" Font-Size="Medium" >
                <b>UserName:</b>
                <asp:TextBox runat="server" ID="txtUserName"></asp:TextBox>
                <br />
                <asp:Button runat="server" ID="btnAddAssignedUser" Text="Assign user" OnClick="btnAddAssignedUser_Click" ValidationGroup="save" />
                &nbsp;
                <asp:Button runat="server" ID="btnCancelAll" Text="Cancel" OnClick="btnCancelAll_Click" />
            </asp:Panel>
        </div>

    </div> 

</asp:Content>
