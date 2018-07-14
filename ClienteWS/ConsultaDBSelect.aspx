<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConsultaDBSelect.aspx.cs" Inherits="ConsultaDBSelect" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
            <asp:Button ID="btnUpdateTable" runat="server" OnClick="Button1_Click" Text="Consultar Tabla" />
        </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnShowInsertFields" runat="server" OnClick="btnShowInsertFields_Click" Text="Mostrar campos para insertar" />
        </p>
        <p>
            <asp:Label ID="lblName" runat="server" Text="Nombre" Visible="False"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblAuthor" runat="server" Text="Autor" Visible="False"></asp:Label>
            <asp:TextBox ID="txtAuthor" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p style="font-weight: 700">
            <asp:Label ID="lblPrice" runat="server" Text="Precio" Visible="False"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" TextMode="Number" Visible="False"></asp:TextBox>
        </p>
        <p style="font-weight: 700">
            <asp:Label ID="lblPublishDate" runat="server" Text="Fecha de Publicación" Visible="False"></asp:Label>
            <asp:TextBox ID="txtPublishDate" runat="server" TextMode="Date" Visible="False"></asp:TextBox>
        </p>
        <p style="font-weight: 700">
            <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insertar Data" />
        </p>
    </form>
</body>
</html>
