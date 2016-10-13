<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Security_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="row jumbotron">
        <h1>Site Administration</h1>
    </div>

    <div class="row">
        <div class="col-md-12">
            <%--Nav tabs--%>
            <ul class="nav nav-tabs">
                <li class="active"><a href="#users" data-toggle="tab">Users</a></li>
                <li class="active"><a href="#roles" data-toggle="tab">Security Roles</a></li>
                <li class="active"><a href="#unregistered" data-toggle="tab">UnregisteredUsers</a></li>
            </ul>

            <div class="tab-content">
                <div class="tab-pane fade in active" id="users"></div>
                <div class="tab-pane fade" id="roles"></div>
                <div class="tab-pane fade" id="unregisteres"></div>
            </div>


        </div>
    </div>
</asp:Content>

