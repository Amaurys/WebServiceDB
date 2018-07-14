using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace WSApp
{
    /// <summary>
    /// Descripción breve de WSSuma
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSSuma : System.Web.Services.WebService
    {

       /* [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }*/

        [WebMethod]
        public int sumaDosNumeros(int number1, int number2)
        {
            return number1 + number2;
        }

        [WebMethod]
        public DataSet GetData()
        {
            string selectQuery = "select * from Books";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString="Data Source=DESKTOP-PQ7IHPC; Initial Catalog=Book;Integrated Security=True;";
            SqlDataAdapter da = new SqlDataAdapter(selectQuery,conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        [WebMethod]
        public void InsertData(string name,string author,int price,string publishDate)
        {
            string insertQuery = "insert into Books values ('"+name+"','"+author+"','"+price+"','"+publishDate+"');";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=DESKTOP-PQ7IHPC; Initial Catalog=Book;Integrated Security=True;" +
                "Trusted_Connection = True;";
            conn.Open();
            SqlCommand command = new SqlCommand(insertQuery,conn);
            command.ExecuteNonQuery();
        }
    }
}
