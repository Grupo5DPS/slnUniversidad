using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente_CSharp
{
    public partial class Escuela : System.Web.UI.Page
    {
        private srEscuela.WebService1SoapClient servicio;
        private void Listar()
        {
            servicio = new srEscuela.WebService1SoapClient();
            gvEscuela.DataSource = servicio.Listar();
            gvEscuela.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Listar();
            }

        }

        protected void gvEscuela_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}