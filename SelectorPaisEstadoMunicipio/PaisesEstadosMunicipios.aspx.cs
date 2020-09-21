using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SelectorPaisEstadoMunicipio
{
    public partial class PaisesEstadosMunicipios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IniciarLlenadoDropDown();
            }
        }

        private void IniciarLlenadoDropDown()
        {
            ddlPais.DataSource = Consultar("SELECT * FROM Paises ");
            ddlPais.DataTextField = "Pais";
            ddlPais.DataValueField = "PaisID";
            ddlPais.DataBind();
            ddlPais.Items.Insert(0,new ListItem("[Seleccionar]","0"));
            ddlEstado.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            ddlMunicipio.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        protected void PaisSeleccionado(object sender, EventArgs e)
        {
            int PaisID = Convert.ToInt32(ddlPais.SelectedValue);
            ddlEstado.DataSource = Consultar("SELECT * FROM Estados WHERE PaisID =" + PaisID);
            ddlEstado.DataTextField = "Estado";
            ddlEstado.DataValueField = "EstadoID";
            ddlEstado.DataBind();
            ddlEstado.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        protected void EstadoSeleccionado(object sender, EventArgs e)
        {
            int EstadoID = Convert.ToInt32(ddlEstado.SelectedValue);
            ddlMunicipio.DataSource = Consultar("SELECT * FROM Municipios WHERE EstadoID = " + EstadoID);
            ddlMunicipio.DataTextField = "Municipio";
            ddlMunicipio.DataValueField = "MunicipioID";
            ddlMunicipio.DataBind();
            ddlMunicipio.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

        public DataSet Consultar(string strSQL)
        {
            string strconn = @"Data Source=PC\SQLEXPRESS;Initial Catalog=FeriadosBrasil;Integrated Security=True";
            SqlConnection con = new SqlConnection(strconn);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
    }
}