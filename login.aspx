<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="LasVegasMagicalShow.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container mt-0">
        <div class="row">
            <div class="col-4 offset-4">

                <h2>Login</h2>

                <asp:Label ID="Label_LoginName" runat="server" Text="Name"></asp:Label>
                <asp:TextBox ID="TextBox_LoginName" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Label ID="Label_LoginPassword" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="TextBox_LoginPassword" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Button ID="Button_Login" runat="server" Text="Login" CssClass="btn btn-secondary" OnClick="Button_Login_Click" />

                <asp:Label ID="Label_ShowInfo" runat="server" Text=""></asp:Label>

            </div>
        </div>
    </div>

</asp:Content>
