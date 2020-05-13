using Microsoft.Data.SqlClient;
using mutual_aid.Models;
using mutual_aid.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mutual_aid.DAL
{
    public class UserSqlDAO
    {
        private readonly string connectionString;

        public UserSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void RegisterUser(User user)
        {
            string RegisterUserSQL = "INSERT INTO users VALUES (@email, @password, @salt, @first_name, @last_name, @phone_number, @county, @role); ";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(RegisterUserSQL, conn);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@salt", user.Salt);
                    cmd.Parameters.AddWithValue("@first_name", user.FirstName);
                    cmd.Parameters.AddWithValue("@last_name", user.LastName);
                    cmd.Parameters.AddWithValue("@phone_number", user.PhoneNumber);
                    cmd.Parameters.AddWithValue("@county", user.County);
                    cmd.Parameters.AddWithValue("@role", user.Role);

                    cmd.ExecuteNonQuery();

                    return;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public User GetUser(string email)
        {
            string GetUserSQL = "SELECT * FROM users WHERE email = @email";
            User user = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(GetUserSQL, conn);
                    cmd.Parameters.AddWithValue("@email", email);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        user = MapRowToUser(reader);
                    }
                }
                return user;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public User GetUserById(int userId)
        {
            string GetUserByIdSQL = "SELECT * FROM users WHERE id = @id";
            User user = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(GetUserByIdSQL, conn);
                    cmd.Parameters.AddWithValue("@id", userId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        user = MapRowToUser(reader);
                    }
                }
                return user;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<User> GetAllUsers(int currentUserId)
        {
            string GetAllUsersSQL = "SELECT * FROM users WHERE id <> @id";
            List<User> users = new List<User>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(GetAllUsersSQL, conn);
                    cmd.Parameters.AddWithValue("@id", currentUserId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        users.Add(MapRowToUser(reader));
                    }
                }
                return users;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void UpdatePassword(User user)
        {
            string UpdatePasswordSQL = "UPDATE users SET password = @password, salt = @salt WHERE id = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(UpdatePasswordSQL, conn);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@salt", user.Salt);
                    cmd.Parameters.AddWithValue("@id", user.Id);

                    cmd.ExecuteNonQuery();

                    return;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void EditUserInfo(User user, int userId)
        {
            string EditUserInfoSQL = "UPDATE users SET email = @email, first_name = @first_name, last_name = @last_name, " +
                "phone_number = @phone_number, county = @county WHERE id = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(EditUserInfoSQL, conn);
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@first_name", user.FirstName);
                    cmd.Parameters.AddWithValue("@last_name", user.LastName);
                    cmd.Parameters.AddWithValue("@phone_number", user.PhoneNumber);
                    cmd.Parameters.AddWithValue("@county", user.County);

                    cmd.ExecuteNonQuery();

                    return;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void DeleteUser(User user)
        {
            string DeleteUserSQL = "DELETE FROM users WHERE id = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(DeleteUserSQL, conn);
                    cmd.Parameters.AddWithValue("@id", user.Id);

                    cmd.ExecuteNonQuery();

                    return;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private User MapRowToUser(SqlDataReader reader)
        {
            return new User()
            {
                Id = Convert.ToInt32(reader["id"]),
                Email = Convert.ToString(reader["email"]),
                Password = Convert.ToString(reader["password"]),
                Salt = Convert.ToString(reader["salt"]),
                Role = Convert.ToString(reader["role"]),
                FirstName = Convert.ToString(reader["first_name"]),
                LastName = Convert.ToString(reader["last_name"]),
                PhoneNumber = Convert.ToString(reader["phone_number"]),
                County = Convert.ToString(reader["county"])
            };
        }
    }
}
