<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Kalkulator</h1>
    </div>

    <div class="row">
        <div class="col-md-12">
            <p>
                Number A&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxA" runat="server" OnTextChanged="TextBox2_TextChanged" TextMode="Number"></asp:TextBox>
&nbsp;Number B&nbsp;&nbsp;
                <asp:TextBox ID="TextBoxB" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Number"></asp:TextBox>
&nbsp;
            </br>
            </br>
                Kliknij aby wykonac dzialanie:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="+" Width="30px" />
                <asp:Button ID="Button2" runat="server" Text="-" Width="30px" OnClick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="*" Width="30px" />
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="/" Width="30px" />
            </br>
            </br>
                Wynik&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBoxResult" runat="server" Enabled="False" OnTextChanged="TextBox1_TextChanged1"></asp:TextBox>
            </p>
            
            <p>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource2" GridLines="Vertical" Height="148px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="289px" AllowPaging="True" EnableSortingAndPagingCallbacks="True" EnableViewState="False">
                    <AlternatingRowStyle BackColor="Gainsboro" />
                    <Columns>
                        <asp:BoundField DataField="Data_operacji" HeaderText="Data_operacji" SortExpression="Data_operacji" />
                        <asp:BoundField DataField="Dzialanie" HeaderText="Dzialanie" SortExpression="Dzialanie" />
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerSettings Visible="False" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:KalkulatorConnectionString %>" SelectCommand="SELECT [Data operacji] AS Data_operacji, [Dzialanie] FROM [Events] ORDER BY [Data operacji] DESC"></asp:SqlDataSource>
            </p>
        </div>
        
        
    </div>
</asp:Content>
