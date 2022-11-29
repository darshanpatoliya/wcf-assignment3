<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div align="center" style="background-color: aqua">
        <asp:Label ID="Label4" runat="server" Text="Tenant's Data"></asp:Label>
    </div>

    <br />
    <br />
    <br />

    <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />

    <asp:Label ID="Label2" runat="server" Text="Rent"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />

    <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />

    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
    <asp:Button ID="Button2" runat="server" Text="Search" OnClick="Button2_Click" />
    <br />

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"></asp:GridView>

    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
</asp:Content>
