<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucDepartmentEmployees.ascx.cs" Inherits="HRmanagementSystems.ucDepartmentEmployees" %>
<asp:DropDownList ID="ddlDepartmentEmployees" runat="server" OnSelectedIndexChanged="ddlDepartmentEmployees_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
<br /><br />
<asp:DetailsView ID="dvDepartmentEmployee" runat="server" Height="50px" Width="125px"></asp:DetailsView>

