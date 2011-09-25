<%@ language="C#" %>
<html>
<script runat=server>
	static int x = 0;
	void Clicked (object o, EventArgs e)
	{
	    
	    System.Web.UI.WebControls.Button botao = (System.Web.UI.WebControls.Button) o;
	    x++;
	    botao.Text = x.ToString();
	    
	}
</script>
<head>
<title>Button</title>
</head>
<body>
<form runat="server">
<asp:Button id="btn" Text="Clique Aqui" OnClick="Clicked" runat="server"/>
</form>
</body>
</html>
