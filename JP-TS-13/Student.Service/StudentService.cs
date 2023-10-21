using Microsoft.Data.SqlClient;
using Student.Models;
using System.Data;

namespace Student.Service
{
    public class StudentService : IStudentService
    {
        public void AddStudent(StudentModel newStudentObject)
        {
            string sqlExpression = "sp_addStudent";

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("firsName", newStudentObject.FirstName);
                    command.Parameters.AddWithValue("lastName", newStudentObject.LastName);
                    command.Parameters.AddWithValue("dateOfBirth", newStudentObject.DateOfBirth);
                    command.Parameters.AddWithValue("pin", newStudentObject.Pin);

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
            string sqlExpression = $"sp_deleteStudent";

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", id);

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

            const string sqlExpression = @"sp_GetAllStudents";


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
            string sqlExpression = "sp_GetSingleStudent";

            StudentModel result = new();

            using (SqlConnection connection = new(HelperConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("id", id);

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
