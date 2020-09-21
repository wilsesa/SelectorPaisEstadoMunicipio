using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ddlPaisEstadoCiudad
{
    public partial class SelectorPaisesEstadoCiudad : System.Web.UI.Page
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
            dropPais.DataSource = Consultar("SELECT * FROM Paises1");
            dropPais.DataTextField = "Pais";
            dropPais.DataValueField = "PaisID";
            dropPais.DataBind();
           

            dropPais.Items.Insert(0,new ListItem("[Seleccionar]","0"));
            dropEstado.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            dropCiudad.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
            dropMunicipio.Items.Insert(0, new ListItem("[Seleccionar]", "0"));
        }

       
        protected void PaisSelecionado(object sender, EventArgs e)
        {
            int PaisID = Convert.ToInt32(dropPais.SelectedValue);
            dropEstado.DataSource = Consultar("SELECT * FROM Estados1 WHERE PaisID="+PaisID);
            dropEstado.DataTextField = "Estado";
            dropEstado.DataValueField = "EstadoID";
            dropEstado.DataBind();
            dropEstado.Items.Insert(0,new ListItem("[Seleccionar...]","0"));
        }

        protected void EstadoSeleccionado(object sender, EventArgs e)
        {
            int EstadoId = Convert.ToInt32(dropEstado.SelectedValue);
            dropCiudad.DataSource = Consultar("SELECT * FROM Ciudad1 WHERE EstadoID="+EstadoId);
            dropCiudad.DataTextField = "Ciudad";
            dropCiudad.DataValueField = "CiudadID";
            dropCiudad.DataBind();
            dropCiudad.Items.Insert(0, new ListItem("[Seleccionar..]", "0"));
        }

        protected void CiudadSelecionada(object sender, EventArgs e)
        {
            int CiudadId = Convert.ToInt32(dropCiudad.SelectedValue);
            dropMunicipio.DataSource = Consultar("SELECT * FROM Municipio1 WHERE CiudadID=" + CiudadId);
            dropMunicipio.DataTextField = "Municipio";
            dropMunicipio.DataValueField = "MunicipioID";
            dropMunicipio.DataBind();
            dropMunicipio.Items.Insert(0, new ListItem("[Selecionar...]", "0"));
        }

        public DataSet Consultar(string strSQL)
        {
            string strconn = @"Data Source=PC\SQLEXPRESS;Initial Catalog=FeriadosBrasil;Integrated Security=True";
            SqlConnection con = new SqlConnection(strconn);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            return ds;
        }
    }
}