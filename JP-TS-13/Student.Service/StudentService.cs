using Microsoft.Data.SqlClient;
using Student.Models;
using System.Data;

namespace Student.Service
{
    public class StudentService : IStudentService
    {
        public void AddStudent(StudentModel newStudentObject)
        {
            string sqlExpression = @$"
                INSERT INTO Students (FirstName,LastName,DateOfBirth,Pin)
                VALUES (N'{newStudentObject.FirstName}',N'{newStudentObject.LastName}','{newStudentObject.DateOfBirth}','{newStudentObject.Pin}')";

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
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

        public void DeleteStudent(int id)
        {
            string sqlExpression = $"DELETE FROM Students WHERE Id = {id}";

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.Text;

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
        public StudentModel GetStudent(int id)
        {
            string sqlExpression = @$"SELECT [Id]
                                        ,[FirstName]
                                        ,[LastName]
                                        ,[DateOfBirth]
                                        ,[Pin]
                                    FROM [JPTS13].[dbo].[Students]
                                    WHERE Id = {id}";

            StudentModel result = new();

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
