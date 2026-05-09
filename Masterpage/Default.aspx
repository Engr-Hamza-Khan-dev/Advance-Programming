<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Masterpage.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    This is Default</p>
    <p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="* The textbox should not be empty" SetFocusOnError="True"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="*The Password should be 8 character" MaximumValue="9" MinimumValue="2" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="* Input should be email format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    <br />
    <br />
    <asp:Label ID="lblname" runat="server" Text="Name :"></asp:Label>
    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblID" runat="server" Text="ID :"></asp:Label>
    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lbldegree" runat="server" Text="Degree :"></asp:Label>
    <asp:TextBox ID="txtdegree" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" Text="Submit" />
    <br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    <br />
    <br />
</asp:Content>
