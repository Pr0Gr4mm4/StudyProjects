<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartmentLocations.aspx.cs" Inherits="HRApp.DepartmentLocations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="ddlLocations" runat="server" AutoPostBack="True" DataSourceID="odsLocations"></asp:DropDownList>
        <asp:ObjectDataSource ID="odsLocations" runat="server" SelectMethod="GetLocations" TypeName="HRAppLib.BAL"></asp:ObjectDataSource>
        <asp:GridView ID="gvDepartments" runat="server" AutoGenerateColumns="False" DataKeyNames="DEPARTMENT_ID" DataSourceID="odsLocationDepartments">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="DEPARTMENT_ID" HeaderText="Department ID" SortExpression="DEPARTMENT_ID" />
                <asp:BoundField DataField="DEPARTMENT_NAME" HeaderText="Dpartment Name" SortExpression="DEPARTMENT_NAME" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="odsLocationDepartments" runat="server" SelectMethod="GetDepartments" TypeName="HRAppLib.BAL">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlLocations" Name="loc" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:DetailsView ID="dvDeptManager" runat="server" Height="50px" Width="125px" AutoGenerateRows="False" DataSourceID="odsManagerDetails">
            <Fields>
                <asp:BoundField DataField="EMPLOYEE_ID" HeaderText="EMPLOYEE_ID" SortExpression="EMPLOYEE_ID" />
                <asp:BoundField DataField="FIRST_NAME" HeaderText="FIRST_NAME" SortExpression="FIRST_NAME" />
                <asp:BoundField DataField="LAST_NAME" HeaderText="LAST_NAME" SortExpression="LAST_NAME" />
                <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
                <asp:BoundField DataField="HIRE_DATE" HeaderText="HIRE_DATE" SortExpression="HIRE_DATE" />
            </Fields>
        </asp:DetailsView>
        <asp:ObjectDataSource ID="odsManagerDetails" runat="server" SelectMethod="GetDepartmentManager" TypeName="HRAppLib.BAL">
            <SelectParameters>
                <asp:ControlParameter ControlID="gvDepartments" Name="deptID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
