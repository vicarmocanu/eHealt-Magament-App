<%@ Page Title="" Language="C#" MasterPageFile="~/Management/HomeManagement.Master" AutoEventWireup="true" CodeBehind="UpdateTask.aspx.cs" Inherits="HealthWebUI.Management.Tasks.UpdateTask" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row">

        <div class="col-md-7">

            <asp:Panel ID="UpdatePanel" runat="server" Font-Size="Medium" Font-Name="Arial">
                <p>
                    TaskName: 
                    <br />
                    <asp:Label id="boundTxtTaskName" runat="server" Width="250px" />
                    <br />
                    Status:
                    <br />
                    <asp:TextBox ID="txtStatus" runat="server" Width="250px" />
                    <br />
                    Description:
                    <br />
                    <asp:TextBox ID="txtDescription" runat="server" Width="250px" />
                    <br />
                    <asp:Button ID="updateBtn" runat="server" Text="Update Task" ValidationGroup="save" OnClick="updateBtn_Click" />
                    &nbsp;
                    <asp:Button ID="cancelAll" runat="server" Text="Cancel/Return" OnClick="cancelAll_Click" />
                </p>
            </asp:Panel>
        </div>
    </div>
</asp:Content>
