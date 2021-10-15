<%@ Page Title="" Language="C#" MasterPageFile="~/Page.Master" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="LasVegasMagicalShow.profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container mt-0">
        <div class="row">

            <h2>Profile</h2>

            <hr />

            <div class="col-4" id="staff" runat="server">

                <asp:Label ID="Label_suserTitle" CssClass="titleStyle" runat="server" Text=""></asp:Label>
                
                <%--<asp:Label ID="Label_sInfo" CssClass="titleStyle2" runat="server" Text="Update profile"></asp:Label>--%>

                <asp:Label ID="Label_sName" runat="server" Text="Name"></asp:Label>
                <asp:TextBox ID="TextBox_sName" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Label ID="Label_sPass" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="TextBox_sPass" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Label ID="Label_sSalary" runat="server" Text="Salary ($)"></asp:Label>
                <asp:TextBox ID="TextBox_sSalary" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Button ID="Button_sUpdate" runat="server" Text="Update Staff" CssClass="btn btn-secondary" OnClick="Button_sUpdate_Click"></asp:Button>

                <asp:Label ID="Label_sInfo" runat="server" Text=""></asp:Label>
            </div>

            <div class="col-4" id="magician" runat="server">
                <asp:Label ID="Label_muserTitle" CssClass="titleStyle" runat="server" Text=""></asp:Label>
                
                <%--<asp:Label ID="Label_mInfo" CssClass="titleStyle2" runat="server" Text="Update profile"></asp:Label>--%>

                <asp:Label ID="Label_mName" runat="server" Text="Name"></asp:Label>
                <asp:TextBox ID="TextBox_mName" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Label ID="Label_mPass" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="TextBox_mPass" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Button ID="Button_mUpdate" runat="server" Text="Update Magician" CssClass="btn btn-secondary" OnClick="Button_mUpdate_Click"></asp:Button>

                <asp:Label ID="Label_mInfo" runat="server" Text=""></asp:Label>

                <asp:Label ID="Label_mTricks" runat="server" Text="Add Trick"></asp:Label>
                <asp:TextBox ID="TextBox_mTricks" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Button ID="Button_AddTrick" runat="server" Text="Add Trick" CssClass="btn btn-secondary" OnClick="Button_AddTrick_Click"></asp:Button>

                <asp:Label ID="Label_mInfo2" runat="server" Text=""></asp:Label>
            </div>

            <div class="col-7 offset-1 mt-5">
                <asp:Label ID="Label_Persons" CssClass="titleStyle2" runat="server" Text=""></asp:Label>
                <asp:ListBox ID="ListBox_Persons" runat="server" Rows="1000" Height="300"></asp:ListBox>

                <asp:Label ID="Label_Empty" runat="server" Text=""></asp:Label>
            </div>

        </div>
    </div>

</asp:Content>
