<%@ Page Title="Весь график" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="NpaManagerWeb.About" %>

<%@ Register Assembly="DevExpress.XtraReports.v16.2.Web, Version=16.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h2>График подготовки проектов нормативных правовых актов Еврейской автономной области</h2>
            </hgroup>
        </div>
    </section>
    <dx:ASPxDocumentViewer ID="ASPxDocumentViewer1" runat="server" ReportTypeName="NpaManager.NpaAllIogvRpt" ToolbarMode="Ribbon">
    </dx:ASPxDocumentViewer>
</asp:Content>
