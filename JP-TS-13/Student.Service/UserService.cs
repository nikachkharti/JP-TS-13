using Microsoft.Data.SqlClient;
using Student.Models;
using Student.Service.Interfaces;
using System.Data;

namespace Student.Service
{
    public class UserService : IUserService
    {
        public void AddUser(UserModel user)
        {
            string sqlExpression = "sp_addNewUser";

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("email", user.Email);
                    command.Parameters.AddWithValue("password", user.Password);
                    command.Parameters.AddWithValue("role", user.Role);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public List<UserModel> GetAllUsers()
        {
            List<UserModel> result = new();

            const string sqlExpression = @"sp_getAllUsers";


            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new UserModel
                            {
                                Id = reader.GetInt32(0),
                                Email = reader.GetString(1),
                                Password = reader.GetString(2),
                                Role = reader.GetString(3)
                            });
                        }
                    }

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }


                return result;
            }
        }
    }
}
