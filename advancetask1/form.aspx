<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="form.aspx.cs" Inherits="advancetask1.form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            ASP.NET WEB CONTROL DEMO<br />
            <br />
            <asp:Label ID="lblfullname" runat="server" Text="Full Name: "></asp:Label>
            <asp:TextBox ID="txtbox" runat="server"></asp:TextBox> <br /><br />
            <asp:Label ID="lblGender" runat="server" Text="Gender: "></asp:Label>
           
            <asp:RadioButton ID="RadioButton1" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Male" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
            <br />
            <asp:Label ID="lblhobbies" runat="server" Text="Hobbies:"></asp:Label>
           
        &nbsp;<asp:CheckBox ID="CheckBox1" runat="server" Text="Cricket" />
&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Reading" />
&nbsp;
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Cooking" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show data" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
           
        </div>
    </form>
</body>
</html>
