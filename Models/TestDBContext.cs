// using System.Collections.Generic;
// using MySql.Data.MySqlClient;

// namespace project.Models
// {
//     public class TestDBContext
//     {
//         public string ConnectionString{get; set;}
//         public TestDBContext(string ConnectionString)
//         {
//             this.ConnectionString = ConnectionString;
//         }
//         private MySqlConnection GetConnection()
//         {
//             return new MySqlConnection(ConnectionString);
//         }
//         public List<test> GetAllTexts()
//         {
//             List<test> list = new List<test>();
//             using (MySqlConnection conn = GetConnection())
//             {
//                 conn.Open();
//                 MySqlCommand cmd = new MySqlCommand("SELECT * FROM test",conn );
//                 using (MySqlDataReader reader = cmd.ExecuteReader())
//                 {
//                     while (reader.Read())
//                     {
//                         list.Add(new test()
//                         {
//                             Text = reader.GetString("text")
//                         });
//                         }
//                     }
//                 return list;
//             }
//         }


//     }
// }