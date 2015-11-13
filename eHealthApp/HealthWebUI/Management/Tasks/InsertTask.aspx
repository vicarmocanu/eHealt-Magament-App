<%@ Page Title="" Language="C#" MasterPageFile="~/Management/HomeManagement.Master" AutoEventWireup="true" CodeBehind="InsertTask.aspx.cs" Inherits="HealthWebUI.Management.Tasks.InsertTask" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        
        <div class="col-md-7">
            
            <asp:Panel runat="server" ID="AddTaskPanel" DefaultButton="btnAddTask" Font-Size="Medium" >
                <b>Task Name:</b>
                <asp:TextBox runat="server" ID="txtTaskName"></asp:TextBox>
                <br />
                <b>Status:</b>
                <asp:TextBox runat="server" ID="txtStatus"></asp:TextBox>
                <br />
                <b>Description:</b>
                <asp:TextBox runat="server" ID="txtDescription"></asp:TextBox>
                <br />
                <asp:Button runat="server" ID="btnAddTask" Text="Create" OnClick="btnAddTask_OnClick" ValidationGroup="save" />
            </asp:Panel>
        </div>
    </div> 
</asp:Content>
