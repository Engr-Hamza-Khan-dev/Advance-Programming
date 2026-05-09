<%@ Page Title="Add Student" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeFile="AddStudent.aspx.cs" Inherits="AddStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="title-bar">Add Student</div>

    <asp:Label Text="Student Name:" runat="server" />
    <br />
    <asp:TextBox ID="txtName" runat="server" Width="250px"></asp:TextBox>

    <br /><br />

    <asp:Button ID="btnAdd" runat="server" Text="Add Student" OnClick="btnAdd_Click" />

    <br /><br />

    <asp:GridView ID="GridView1" runat="server" Width="100%" />

</asp:Content>