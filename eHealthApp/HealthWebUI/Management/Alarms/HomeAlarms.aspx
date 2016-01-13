<%@ Page Title="" Language="C#" MasterPageFile="~/Management/HomeManagement.Master" AutoEventWireup="true" CodeBehind="HomeAlarms.aspx.cs" Inherits="HealthWebUI.Management.Alarms.HomeAlarms" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">

        <div class="col-md-7">

            <asp:Repeater ID="AlarmRepeater" runat="server" OnItemCommand="AlarmRepeater_ItemCommand" >
                <ItemTemplate>                    
                    <div>
                        <b>Name:</b>
                        <br />
                        <asp:Label ID="alarmNameLabel" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                        <br />
                        <b>Type:</b>
                        <asp:Label ID="alarmTypeLabel" runat="server" Text='<%# Eval("Type") %>'></asp:Label>
                        <br />
                        <b>Time:</b>
                        <asp:Label ID="alarmTimeLabel" runat="server" Text='<%# Eval("Time") %>'></asp:Label>
                        <br />
                        <b>Location: </b>
                        <asp:Label ID="alarmLocationLabel" runat="server" Text='<%# Eval("Location") %>'></asp:Label>
                        <br />
                        <b>Status: </b>
                        <asp:Label ID="alarmStatusLabel" runat="server" Text='<%# Eval("Status") %>'></asp:Label>
                        <br />

                        <asp:Button ID="updateAlarm" Text="Update Alarm" runat="server" CommandName="updateAlarm" CommandArgument='<%# Eval("Name") %>' />
                        &nbsp;
                        <asp:Button ID="deleteAlarm" Text="Delete Alarm" runat="server" CommandName="deleteAlarm" CommandArgument='<%# Eval("Name") %>' />
                        &nbsp;
                        <asp:Button ID="getAttendatns" Text="Get attendatns" runat="server" CommandName="getAttendants" CommandArgumen='<%# Eval("Name") %>' />
                    </div>
                </ItemTemplate>
            </asp:Repeater>

        </div>

    </div>

</asp:Content>
