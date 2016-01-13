<%@ Page Title="" Language="C#" MasterPageFile="~/Management/HomeManagement.Master" AutoEventWireup="true" CodeBehind="HomeSubTask.aspx.cs" Inherits="HealthWebUI.Management.Tasks.SubTasks.HomeSubTask" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">

        <div class="col-md-7">
            <h1>
                Task name:
                <asp:Label ID="boundTxtTaskName" runat="server"></asp:Label>
            </h1>

            <br />

            <asp:Repeater ID="SubTaskRepeater" runat="server" OnItemCommand="SubTaskRepeater_ItemCommand">
                <ItemTemplate>
                    <div>
                        <b>Description:</b>
                        <br />
                        <asp:Label ID="subTaskDescription" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                        <br />
                        <b>Status:</b>
                        <br />
                        <asp:Label ID="subTaskStatus" runat="server" Text='<%# Eval("Status") %>'></asp:Label>
                        <br />
                        <asp:Button ID="updateSubTask" Text="Update SubTask" runat="server" CommandName="updateSubTask" CommandArgument='<%# Eval("Id") %>' />
                        &nbsp;
                        <asp:Button ID="deleteSubTask" Text="Delete SubTask" runat="server" CommandName="deleteSubTask" CommandArgument='<%# Eval("Id") %>' />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>

    </div>

    <br />

    <div class ="row">
        <div class="col-md-2">

            <asp:Button ID="createButton" Text="Add new SubTask" runat="server" OnClick="createButton_Click" />
            &nbsp;
            <asp:Button ID="returnToTasks" Text="Cancel/Return" runat="server" OnClick="returnToTasks_Click" />

        </div>
    </div>

</asp:Content>
