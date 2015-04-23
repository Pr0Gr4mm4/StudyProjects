<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="HRmanagementSystems.WebForm1" %>

<%@ Register Src="~/ucLogin.ascx" TagPrefix="uc1" TagName="ucLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ucLogin runat="server" ID="ucLogin" />
</asp:Content>
