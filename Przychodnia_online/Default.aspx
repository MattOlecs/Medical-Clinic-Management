<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Przychodnia_online._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Przychodnia im. Studentów poległych</h1>
        <p class="lead">
            <asp:Label ID="Label4" runat="server" Text="Login: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p class="lead">
            <asp:Label ID="Label5" runat="server" Text="Hasło: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        </p>
        <p class="lead">
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Zaloguj się" />
        </p>
        <p class="lead">&nbsp;<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        </p>
        <p class="lead">
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="220px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Wybierz czynność" Width="210px" />
        </p>
        <p class="lead">
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" Width="300px">
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Wybierz lekarza" Width="210px" OnClick="Button2_Click1" />
        </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" MaxLength="2" TextMode="Number" min="5" max="18" step="1" Width="70px"></asp:TextBox>
            <asp:Label ID="Label_h" runat="server" Text="h"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" MaxLength="2" TextMode="Number" min="0" max="50" step="10" Width="70px"></asp:TextBox>
            <asp:Label ID="Label_m" runat="server" Text="m"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Wybierz godzinę" />
        </p>
        <p>
            <asp:Label ID="Label_wybrana_godz" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="Zajęte terminy:"></asp:Label>
        </p>
        <p>
            <asp:ListBox ID="ListBox3" runat="server" Height="270px" Width="350px" Rows="15">

            </asp:ListBox>
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Stompka </h2>
            <p>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </p>
        </div>
    </div>

</asp:Content>
