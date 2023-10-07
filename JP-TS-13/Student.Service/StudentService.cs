﻿using Microsoft.Data.SqlClient;
using Student.Models;
using Student.Service.Interfaces;

namespace Student.Service
{
    public class StudentService : IStudentService
    {
        public List<StudentModel> GetAll()
        {
            List<StudentModel> result = new();
            const string sqlExpression = "SELECT*FROM Students";

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
                            result.Add(new StudentModel
                            {
                                Id = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                DateOfBirth = reader.GetDateTime(3),
                                Pin = reader.GetString(4),
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
