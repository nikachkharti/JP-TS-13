using Microsoft.Data.SqlClient;
using Student.Models;
using System.Data;

namespace Student.Service
{
    public class StudentService : IStudentService
    {
        public List<StudentModel> GetAllStudents()
        {
            List<StudentModel> result = new();

            const string sqlExpression = @"SELECT [Id]
                                            ,[FirstName]
                                            ,[LastName]
                                            ,[DateOfBirth]
                                            ,[Pin]
                                          FROM [JPTS13].[dbo].[Students]";


            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.Text;
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new StudentModel
                            {
                                Id = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                DateOfBirth = reader.GetDateTime(3),
                                Pin = reader.GetString(4)
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
