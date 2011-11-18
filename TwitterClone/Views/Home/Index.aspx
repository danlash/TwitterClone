<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="TwitterClone.Models" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Clammer
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

	<ol class="clams">
	    <% foreach (var clam in ViewData["clams"] as IEnumerable<Clam>) { %>
			<li class="clam">
				<span class="username"><%= clam.UserName %></span>
				<span class="pearl"><%= clam.Pearl %></span>
			</li>
        <% } %>
	</ol>

    <% if (Request.IsAuthenticated) { %>

	<section class="new-clam">
		<form method="POST" action="<%= Url.Action("Create", "Clam") %>">
			<label>
				Pearl of wisdom:
				<textarea name="pearl"></textarea>
				<button type="submit">Harvest</button>
			</label>
		</form>
	</section>

    <% } %>

</asp:Content>
