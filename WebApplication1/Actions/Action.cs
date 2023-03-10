using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Text;
using System.Text.Json.Serialization;
using WebApplication1.Models;

namespace WebApplication1.Actions
{
    public class Action
    {
        public List<UserModel> makelist()
        {
            var dbcnx = new Dbconect();
            var db = dbcnx.conect();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM dbo.Users");
            db.Open();
            SqlCommand sc = new SqlCommand(sb.ToString(), db);
            SqlDataReader reader = sc.ExecuteReader();
            List<UserModel> userlist = new List<UserModel>();
            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    var user = new UserModel();
                    user.Id = (int)reader["Id"];
                    user.Name = (string)reader["Nombre"];
                    user.Email = "default@mail.com";
                    userlist.Add(user);
                }
            }
            
            db.Close();
            return userlist;
        }
    }
}
