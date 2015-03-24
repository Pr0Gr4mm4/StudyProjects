<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartmentsWithEmployees.aspx.cs" Inherits="HRApp.DepartmentsWithEmployees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:DropDownList ID="ddlDepartments" runat="server" AppendDataBoundItems="True" AutoPostBack="True" DataSourceID="odsDepartments">
        <asp:ListItem>&lt;Selecteer afdeling&gt;</asp:ListItem>
        </asp:DropDownList> 
        <asp:ObjectDataSource ID="odsDepartments" runat="server" SelectMethod="GetDepartmentNames" TypeName="HRAppLib.BAL"></asp:ObjectDataSource>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EMPLOYEE_ID" DataSourceID="odsEmployees">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="EMPLOYEE_ID" HeaderText="EMPLOYEE_ID" SortExpression="EMPLOYEE_ID" />
                <asp:BoundField DataField="FIRST_NAME" HeaderText="FIRST_NAME" SortExpression="FIRST_NAME" />
                <asp:BoundField DataField="LAST_NAME" HeaderText="LAST_NAME" SortExpression="LAST_NAME" />
                <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
                <asp:BoundField DataField="HIRE_DATE" DataFormatString="{0:d-MM-yyyy}" HeaderText="HIRE_DATE" SortExpression="HIRE_DATE" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="odsEmployees" runat="server" SelectMethod="GetEmployees" TypeName="HRAppLib.BAL">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlDepartments" Name="dept" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="odsEmployee" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="EMPLOYEE_ID" HeaderText="EMPLOYEE_ID" SortExpression="EMPLOYEE_ID" />
                <asp:BoundField DataField="FIRST_NAME" HeaderText="FIRST_NAME" SortExpression="FIRST_NAME" />
                <asp:BoundField DataField="LAST_NAME" HeaderText="LAST_NAME" SortExpression="LAST_NAME" />
                <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
                <asp:BoundField DataField="PHONE_NUMBER" HeaderText="PHONE_NUMBER" SortExpression="PHONE_NUMBER" />
                <asp:BoundField DataField="HIRE_DATE" HeaderText="HIRE_DATE" SortExpression="HIRE_DATE" />
                <asp:BoundField DataField="JOB_ID" HeaderText="JOB_ID" SortExpression="JOB_ID" />
                <asp:BoundField DataField="SALARY" HeaderText="SALARY" SortExpression="SALARY" />
                <asp:BoundField DataField="COMMISSION_PCT" HeaderText="COMMISSION_PCT" SortExpression="COMMISSION_PCT" />
                <asp:BoundField DataField="MANAGER_ID" HeaderText="MANAGER_ID" SortExpression="MANAGER_ID" />
                <asp:BoundField DataField="DEPARTMENT_ID" HeaderText="DEPARTMENT_ID" SortExpression="DEPARTMENT_ID" />
                <asp:BoundField DataField="ISMANAGER" HeaderText="ISMANAGER" SortExpression="ISMANAGER" />
                <asp:BoundField DataField="PASSWORD" HeaderText="PASSWORD" SortExpression="PASSWORD" />
            </Fields>
        </asp:DetailsView>
        <asp:ObjectDataSource ID="odsEmployee" runat="server" SelectMethod="GetEmployee" TypeName="HRAppLib.BAL">
            <SelectParameters>
                <asp:ControlParameter ControlID="GridView1" Name="empID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <br />
    </div>
    </form>
</body>
</html>
