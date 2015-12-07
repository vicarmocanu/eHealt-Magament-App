<%@ Page Title="" Language="C#" MasterPageFile="~/Management/HomeManagement.Master" AutoEventWireup="true" CodeBehind="InsertSubTask.aspx.cs" Inherits="HealthWebUI.Management.Tasks.SubTasks.InsertSubTask" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        
        <div class="col-md-7">
            <h1>Insertion of a new Sub Task</h1>
            <h1>
                Task name:
                <asp:Label runat="server" ID="boundTxtTaskName"></asp:Label>
            </h1>

            <br />

            <asp:Panel runat="server" ID="AddSubTaskPanel" Font-Name="Arial" Font-Size="Medium" DefaultButton="btnAddSubTask">                
                <b>Description:</b>
                <asp:TextBox runat="server" ID="txtDescription"></asp:TextBox>
                <br />
                <b>Status:</b>
                <asp:TextBox runat="server" ID="txtStatus"></asp:TextBox>
                <br />
                <asp:Button runat="server" ID="btnAddSubTask" Text="Create" OnClick="btnAddSubTask_Click" ValidationGroup="save" />
                &nbsp;
                <asp:Button runat="server" ID="btnCancelAll" Text="Cancel" OnClick="btnCancelAll_Click" />
            </asp:Panel>
        </div>

    </div>

</asp:Content>
