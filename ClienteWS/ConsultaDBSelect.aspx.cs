using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ConsultaDBSelect : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        WSDBSelect.WSSuma ws = new WSDBSelect.WSSuma();
        DataSet ds = ws.GetData();
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        WSDBSelect.WSSuma ws = new WSDBSelect.WSSuma();
        DataSet ds = ws.GetData();
        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }

protected void btnInsert_Click(object sender, EventArgs e)
    {
        try
        {
            WSDBSelect.WSSuma ws = new WSDBSelect.WSSuma();
            ws.InsertData(txtName.Text, txtAuthor.Text, Convert.ToInt32(txtPrice.Text), txtPublishDate.Text);
            
        }
        catch (Exception)
        {

            throw;
        }
       
    }

    protected void btnShowInsertFields_Click(object sender, EventArgs e)
    {
        if (txtName.Visible == false)
        {
            lblName.Visible = true;
            txtName.Visible = true;
            lblAuthor.Visible = true;
            txtAuthor.Visible = true;
            lblPrice.Visible = true;
            txtPrice.Visible = true;
            lblPublishDate.Visible = true;
            txtPublishDate.Visible = true;
            btnInsert.Visible = true;
        }
        else
        {
            lblName.Visible = false;
            txtName.Visible = false;
            lblAuthor.Visible = false;
            txtAuthor.Visible = false;
            lblPrice.Visible = false;
            txtPrice.Visible = false;
            lblPublishDate.Visible = false;
            txtPublishDate.Visible = false;
            btnInsert.Visible = false;
        }
    }
}





    