<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="LasVegasMagicalShow.index1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container mt-0">
        <div class="row">
            <div class="col-4 offset-4">

                <h2>Register</h2>

                <asp:Label ID="Label_selectRole" runat="server" Text="Select Role"></asp:Label>

                <asp:DropDownList ID="DropDownList_Role" runat="server" AutoPostBack="true" CssClass="btn btn-light dropdown-toggle" OnSelectedIndexChanged="DropDownList_Role_SelectedIndexChanged">
                    <asp:ListItem Text="Select Role" Value="1" />
                    <asp:ListItem Text="Staff" Value="2" />
                    <asp:ListItem Text="Magician" Value="3" />
                </asp:DropDownList>

                <div runat="server" id="regStaff">
                    <asp:Label ID="Label_sRegName" runat="server" Text="Name"></asp:Label>
                    <asp:TextBox ID="TextBox_sRegName" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="Label_sRegPass" runat="server" Text="Password"></asp:Label>
                    <asp:TextBox ID="TextBox_sRegPass" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="Label_sRegSalary" runat="server" Text="Salary ($)"></asp:Label>
                    <asp:TextBox ID="TextBox_sRegSalary" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Button ID="Button_sCreate" runat="server" Text="Register Staff" OnClick="Button_sCreate_Click" CssClass="btn btn-secondary"></asp:Button>

                    <asp:Label ID="Label_sInfo" runat="server" Text=""></asp:Label>
                </div>

                <div runat="server" id="regMagician">
                    <asp:Label ID="Label_mRegName" runat="server" Text="Name"></asp:Label>
                    <asp:TextBox ID="TextBox_mRegName" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="Label_mRegPass" runat="server" Text="Password"></asp:Label>
                    <asp:TextBox ID="TextBox_mRegPass" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Label ID="Label_mRegTricks" runat="server" Text="Single favorite trick"></asp:Label>
                    <asp:TextBox ID="TextBox_mRegTricks" runat="server" CssClass="form-control"></asp:TextBox>

                    <asp:Button ID="Button_mCreate" runat="server" Text="Register Magician" CssClass="btn btn-secondary" OnClick="Button_mCreate_Click"></asp:Button>

                    <asp:Label ID="Label_mInfo" runat="server" Text=""></asp:Label>
                </div>

            </div>
        </div>
    </div>

</asp:Content>
