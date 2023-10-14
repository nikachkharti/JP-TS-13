using Microsoft.Data.SqlClient;
using Student.Models;
using Student.Service.Interfaces;

namespace Student.Service
{
    public class TeacherService : ITeacherService
    {
        public List<TeacherModel> GetAllTeachers()
        {
            string sqlExpression = @"SELECT [Id]
                                        ,[FirstName]
                                        ,[LastName]
                                        ,[DateOfBirth]
                                        ,[Pin]
                                        ,[Salary]
                                    FROM [JPTS13].[dbo].[Teachers]";

            List<TeacherModel> result = new();

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new TeacherModel
                            {
                                Id = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                DateOfBirth = reader.GetDateTime(3),
                                Pin = reader.GetString(4),
                                Salary = reader.GetInt32(5)
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
            }

            return result;
        }
    }
}
