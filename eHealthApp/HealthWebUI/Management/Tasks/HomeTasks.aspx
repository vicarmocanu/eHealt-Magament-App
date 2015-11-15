<%@ Page Title="" Language="C#" MasterPageFile="~/Management/HomeManagement.Master" AutoEventWireup="true" CodeBehind="HomeTasks.aspx.cs" Inherits="HealthWebUI.Management.Tasks.HomeTasks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">

        <div class="col-md-7">
            <asp:Repeater ID="TaskRepeater" runat="server" OnItemCommand="TaskRepeater_ItemCommand" >

                <ItemTemplate>
                    
                    <div>
                        <b>Task Name:</b>
                        <br />
                        <asp:Label ID="taskNameLabel" runat="server" Text='<%# Eval("TaskName") %>'></asp:Label>
                        <br />
                        <b>Status</b>
                        <asp:Label ID="taskStatusLabel" runat="server" Text='<%# Eval("Status") %>'></asp:Label>
                        <br />
                        <b>Description</b>
                        <asp:Label ID="taskDescription" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                        <br />
                        <asp:Button ID="updateTask" Text="Update Task" runat="server" CommandName="updateTask" CommandArgument='<%# Eval("TaskName") %>' />
                        <asp:Button ID="deleteTask" Text="Delete Task" runat="server" CommandName="deleteTask" CommandArgument='<%# Eval("TaskName") %>' />

                    </div>

                </ItemTemplate>

            </asp:Repeater>
        </div>

    </div>

    <br />
    <div class ="row">
        <div class="col-md-2">

            <asp:Button ID="createButton" Text="Add new task" runat="server" OnClick="createButton_Click" />

        </div>
    </div>
</asp:Content>