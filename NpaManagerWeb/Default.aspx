<%@ Page Title="По подразделениям" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NpaManagerWeb._Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v16.2.Web, Version=16.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <dx:ASPxDocumentViewer ID="ASPxDocumentViewer1" runat="server" ReportTypeName="NpaManagerWeb.NpaByIogvRpt" ToolbarMode="Ribbon" Theme="DevEx" AutoHeight="False" EnableTheming="True">
    </dx:ASPxDocumentViewer>
</asp:Content>
