using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    public class userTable : Controller
    {
        public static string con_string = "Server=tcp:sqlexample.database.windows.net,1433;Initial Catalog=sqlexampleD;Persist Security Info=False;User ID=Phenyo;Password=Birdzone33;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        public static SqlConnection con = new SqlConnection(con_string);


        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email {  get; set; }




        public int insert_User(userTable n)
        {

            try
            {
                string sql = "Insert into userTable (userName, userSurname, userEmail) VALUES (@Name, @Surname, @Email";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", n.Name);
                cmd.Parameters.AddWithValue("@Surname", n.Surname);
                cmd.Parameters.AddWithValue("@Email", n.Email);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return rowsAffected;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }



    }
}
