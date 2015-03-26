<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="spDepartments.aspx.cs" Inherits="HRApp.spDepartments" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Overzicht afdelingen met werknemers</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gvSpDepartments" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="odsSpDepartments" DataKeyNames="Department_ID">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Department_ID" HeaderText="Department_ID" SortExpression="Department_ID" />
                <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" />
                <asp:BoundField DataField="Manager" HeaderText="Manager" SortExpression="Manager" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="odsSpDepartments" runat="server" SelectMethod="spGetDepartments" TypeName="HRAppLib.BAL"></asp:ObjectDataSource>
        <br />
        <asp:GridView ID="gvSpDepartmentEmployees" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="EMPLOYEE_ID" DataSourceID="odsSpDepartmentEmployees">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="EMPLOYEE_ID" HeaderText="EMPLOYEE_ID" SortExpression="EMPLOYEE_ID" />
                <asp:BoundField DataField="FIRST_NAME" HeaderText="FIRST_NAME" SortExpression="FIRST_NAME" />
                <asp:BoundField DataField="LAST_NAME" HeaderText="LAST_NAME" SortExpression="LAST_NAME" />
                <asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" />
                <asp:BoundField DataField="HIRE_DATE" DataFormatString="{0:d MMMM yyyy}" HeaderText="HIRE_DATE" SortExpression="HIRE_DATE" />
                <asp:BoundField DataField="SALARY" DataFormatString="{0:c}" HeaderText="SALARY" SortExpression="SALARY" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="odsSpDepartmentEmployees" runat="server" SelectMethod="spGetDepartmentEmployees" TypeName="HRAppLib.BAL">
            <SelectParameters>
                <asp:ControlParameter ControlID="gvSpDepartments" Name="deptID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:FormView ID="FormView1" runat="server" DataSourceID="odsEmployeeForm">
            <EditItemTemplate>
                EMPLOYEE_ID:
                <asp:TextBox ID="EMPLOYEE_IDTextBox" runat="server" Text='<%# Bind("EMPLOYEE_ID") %>' />
                <br />
                FIRST_NAME:
                <asp:TextBox ID="FIRST_NAMETextBox" runat="server" Text='<%# Bind("FIRST_NAME") %>' />
                <br />
                LAST_NAME:
                <asp:TextBox ID="LAST_NAMETextBox" runat="server" Text='<%# Bind("LAST_NAME") %>' />
                <br />
                EMAIL:
                <asp:TextBox ID="EMAILTextBox" runat="server" Text='<%# Bind("EMAIL") %>' />
                <br />
                PHONE_NUMBER:
                <asp:TextBox ID="PHONE_NUMBERTextBox" runat="server" Text='<%# Bind("PHONE_NUMBER") %>' />
                <br />
                HIRE_DATE:
                <asp:TextBox ID="HIRE_DATETextBox" runat="server" Text='<%# Bind("HIRE_DATE") %>' />
                <br />
                JOB_ID:
                <asp:TextBox ID="JOB_IDTextBox" runat="server" Text='<%# Bind("JOB_ID") %>' />
                <br />
                SALARY:
                <asp:TextBox ID="SALARYTextBox" runat="server" Text='<%# Bind("SALARY") %>' />
                <br />
                COMMISSION_PCT:
                <asp:TextBox ID="COMMISSION_PCTTextBox" runat="server" Text='<%# Bind("COMMISSION_PCT") %>' />
                <br />
                MANAGER_ID:
                <asp:TextBox ID="MANAGER_IDTextBox" runat="server" Text='<%# Bind("MANAGER_ID") %>' />
                <br />
                DEPARTMENT_ID:
                <asp:TextBox ID="DEPARTMENT_IDTextBox" runat="server" Text='<%# Bind("DEPARTMENT_ID") %>' />
                <br />
                ISMANAGER:
                <asp:TextBox ID="ISMANAGERTextBox" runat="server" Text='<%# Bind("ISMANAGER") %>' />
                <br />
                PASSWORD:
                <asp:TextBox ID="PASSWORDTextBox" runat="server" Text='<%# Bind("PASSWORD") %>' />
                <br />
                EMPLOYEEs:
                <asp:TextBox ID="EMPLOYEEsTextBox" runat="server" Text='<%# Bind("EMPLOYEEs") %>' />
                <br />
                DEPARTMENT:
                <asp:TextBox ID="DEPARTMENTTextBox" runat="server" Text='<%# Bind("DEPARTMENT") %>' />
                <br />
                EMPLOYEE1:
                <asp:TextBox ID="EMPLOYEE1TextBox" runat="server" Text='<%# Bind("EMPLOYEE1") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                EMPLOYEE_ID:
                <asp:TextBox ID="EMPLOYEE_IDTextBox" runat="server" Text='<%# Bind("EMPLOYEE_ID") %>' />
                <br />
                FIRST_NAME:
                <asp:TextBox ID="FIRST_NAMETextBox" runat="server" Text='<%# Bind("FIRST_NAME") %>' />
                <br />
                LAST_NAME:
                <asp:TextBox ID="LAST_NAMETextBox" runat="server" Text='<%# Bind("LAST_NAME") %>' />
                <br />
                EMAIL:
                <asp:TextBox ID="EMAILTextBox" runat="server" Text='<%# Bind("EMAIL") %>' />
                <br />
                PHONE_NUMBER:
                <asp:TextBox ID="PHONE_NUMBERTextBox" runat="server" Text='<%# Bind("PHONE_NUMBER") %>' />
                <br />
                HIRE_DATE:
                <asp:TextBox ID="HIRE_DATETextBox" runat="server" Text='<%# Bind("HIRE_DATE") %>' />
                <br />
                JOB_ID:
                <asp:TextBox ID="JOB_IDTextBox" runat="server" Text='<%# Bind("JOB_ID") %>' />
                <br />
                SALARY:
                <asp:TextBox ID="SALARYTextBox" runat="server" Text='<%# Bind("SALARY") %>' />
                <br />
                COMMISSION_PCT:
                <asp:TextBox ID="COMMISSION_PCTTextBox" runat="server" Text='<%# Bind("COMMISSION_PCT") %>' />
                <br />
                MANAGER_ID:
                <asp:TextBox ID="MANAGER_IDTextBox" runat="server" Text='<%# Bind("MANAGER_ID") %>' />
                <br />
                DEPARTMENT_ID:
                <asp:TextBox ID="DEPARTMENT_IDTextBox" runat="server" Text='<%# Bind("DEPARTMENT_ID") %>' />
                <br />
                ISMANAGER:
                <asp:TextBox ID="ISMANAGERTextBox" runat="server" Text='<%# Bind("ISMANAGER") %>' />
                <br />
                PASSWORD:
                <asp:TextBox ID="PASSWORDTextBox" runat="server" Text='<%# Bind("PASSWORD") %>' />
                <br />
                EMPLOYEEs:
                <asp:TextBox ID="EMPLOYEEsTextBox" runat="server" Text='<%# Bind("EMPLOYEEs") %>' />
                <br />
                DEPARTMENT:
                <asp:TextBox ID="DEPARTMENTTextBox" runat="server" Text='<%# Bind("DEPARTMENT") %>' />
                <br />
                EMPLOYEE1:
                <asp:TextBox ID="EMPLOYEE1TextBox" runat="server" Text='<%# Bind("EMPLOYEE1") %>' />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                EMPLOYEE_ID:
                <asp:Label ID="EMPLOYEE_IDLabel" runat="server" Text='<%# Bind("EMPLOYEE_ID") %>' />
                <br />
                FIRST_NAME:
                <asp:Label ID="FIRST_NAMELabel" runat="server" Text='<%# Bind("FIRST_NAME") %>' />
                <br />
                LAST_NAME:
                <asp:Label ID="LAST_NAMELabel" runat="server" Text='<%# Bind("LAST_NAME") %>' />
                <br />
                EMAIL:
                <asp:Label ID="EMAILLabel" runat="server" Text='<%# Bind("EMAIL") %>' />
                <br />
                PHONE_NUMBER:
                <asp:Label ID="PHONE_NUMBERLabel" runat="server" Text='<%# Bind("PHONE_NUMBER") %>' />
                <br />
                HIRE_DATE:
                <asp:Label ID="HIRE_DATELabel" runat="server" Text='<%# Bind("HIRE_DATE") %>' />
                <br />
                JOB_ID:
                <asp:Label ID="JOB_IDLabel" runat="server" Text='<%# Bind("JOB_ID") %>' />
                <br />
                SALARY:
                <asp:Label ID="SALARYLabel" runat="server" Text='<%# Bind("SALARY") %>' />
                <br />
                COMMISSION_PCT:
                <asp:Label ID="COMMISSION_PCTLabel" runat="server" Text='<%# Bind("COMMISSION_PCT") %>' />
                <br />
                MANAGER_ID:
                <asp:Label ID="MANAGER_IDLabel" runat="server" Text='<%# Bind("MANAGER_ID") %>' />
                <br />
                DEPARTMENT_ID:
                <asp:Label ID="DEPARTMENT_IDLabel" runat="server" Text='<%# Bind("DEPARTMENT_ID") %>' />
                <br />
                PASSWORD:
                <asp:Label ID="PASSWORDLabel" runat="server" Text='<%# Bind("PASSWORD") %>' />
                <br />
                EMPLOYEEs:
                <asp:Label ID="EMPLOYEEsLabel" runat="server" Text='<%# Bind("EMPLOYEEs") %>' />
                <br />
                DEPARTMENT:
                <asp:Label ID="DEPARTMENTLabel" runat="server" Text='<%# Bind("DEPARTMENT") %>' />
                <br />
                EMPLOYEE1:
                <asp:Label ID="EMPLOYEE1Label" runat="server" Text='<%# Bind("EMPLOYEE1") %>' />
                <br />
            </ItemTemplate>
        </asp:FormView>
        <asp:ObjectDataSource ID="odsEmployeeForm" runat="server" SelectMethod="GetEmployee" TypeName="HRAppLib.BAL">
            <SelectParameters>
                <asp:ControlParameter ControlID="gvSpDepartmentEmployees" Name="empID" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
