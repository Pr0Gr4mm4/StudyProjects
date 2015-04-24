<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="HRmanagementSystems.homepage" %>

<%@ Register Src="~/ucDepartmentEmployees.ascx" TagPrefix="uc1" TagName="ucDepartmentEmployees" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:ucDepartmentEmployees runat="server" id="ucDepartmentEmployees" />
</asp:Content>
