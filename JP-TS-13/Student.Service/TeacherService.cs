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

        public TeacherModel GetSingleTeacher(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException();

            string sqlExpression = @$"SELECT [Id]
                                    ,[FirstName]
                                    ,[LastName]
                                    ,[DateOfBirth]
                                    ,[Pin]
                                    ,[Salary]
                                FROM [JPTS13].[dbo].[Teachers]
                                WHERE Id = {id}";

            TeacherModel result = new();

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
                            result.Id = reader.GetInt32(0);
                            result.FirstName = reader.GetString(1);
                            result.LastName = reader.GetString(2);
                            result.DateOfBirth = reader.GetDateTime(3);
                            result.Pin = reader.GetString(4);
                            result.Salary = reader.GetInt32(5);
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
