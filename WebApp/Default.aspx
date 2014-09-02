<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET Web Forms</h1>
        <p class="lead">This project demonstrates how to call console app in ASP.NET Web Forms</p>
        
        <asp:TextBox ID="aValue" runat="server"></asp:TextBox>
        <asp:DropDownList ID="actionList" runat="server">
            <asp:ListItem Text="+" Value="add" />
            <asp:ListItem Text="-" Value="subtract" />
            <asp:ListItem Text="*" Value="multiply" />
            <asp:ListItem Text="/" Value="divide" />
        </asp:DropDownList>
        <asp:TextBox ID="bValue" runat="server"></asp:TextBox>
        <asp:Label ID="result" runat="server"></asp:Label>
        <asp:Button runat="server" OnClick="CallConsole_Click" Text="Call console calculator" CssClass="btn btn-primary btn-lg" />
    </div>
    <div class="panel panel-primary">
      <div class="panel-heading">Output:</div>
      <div class="panel-body">
        <asp:Label ID="labelConsoleOutput" runat="server"></asp:Label>
      </div>
</div>
</asp:Content>