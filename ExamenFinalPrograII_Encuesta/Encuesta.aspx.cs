using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamenFinalPrograII_Encuesta
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int cont = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            labelID.Text = "Encuesta #0";
        }

        public void alertas(String texto)
        {
            string message = texto;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

        }

        protected void ButtonSalvar_Click(object sender, EventArgs e)
        {
            int idPartido = CLS.Partido.getID(DDLPartido.Text);
            if (CLS.Encuesta.Agregar(TextBoxNOM.Text, int.Parse(TextBoxEdad.Text), TextBoxCorreo.Text, idPartido) > 0)
            {
                alertas("Datos ingresados correctamente");
            }
            else
            {
                alertas("Datos ingresados incorrectamente");
            }
            TextBoxNOM.Text = "";
            TextBoxEdad.Text = "";
            TextBoxCorreo.Text = "";
            DDLPartido.SelectedIndex = 0;
            cont++;
            labelID.Text = $"Encuesta #{cont}";
        }
    }
}