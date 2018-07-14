using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class ProbarWS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSuma_Click(object sender, EventArgs e)
    {
        printearSuma();
    }

    private void printearSuma()
    {
        try
        {
            localhostSuma.WSSuma wsSuma = new localhostSuma.WSSuma();

            int numero1 = Convert.ToInt16(txtNumber1.Text.ToString());
            int numero2 = Convert.ToInt16(txtNumber2.Text.ToString());
           
            int resultado = wsSuma.sumaDosNumeros(numero1, numero2);

            lblResult.Text = "El resultado de la suma de " +numero1+" y "+numero2+" es: "+resultado.ToString();
        }
        catch (Exception ex)
        {
            ex.ToString();
        }
    }
}