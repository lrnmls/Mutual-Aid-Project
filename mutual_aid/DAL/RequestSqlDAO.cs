using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Data.SqlClient;
using mutual_aid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mutual_aid.DAL
{
    public class RequestSqlDAO
    {
        private readonly string connectionString;

        public RequestSqlDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Request> GetAllRequests()
        {
            string GetAllRequestsSQL = "SELECT * FROM requests JOIN users ON users.id = requests.user_id " +
                "FULL JOIN accepted_requests ON accepted_requests.accepted_request_id = requests.id " +
                "FULL JOIN completed_requests ON completed_requests.completed_request_id = requests.id ORDER BY is_completed, is_accepted";

            List<Request> requests = new List<Request>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(GetAllRequestsSQL, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        requests.Add(MapRowToItemsExtended(reader));
                    }
                }
                return requests;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<Request> GetAllRequestsByCounty(string county)
        {
            string GetAllRequestsSQL = "SELECT * FROM requests JOIN users ON users.id = requests.user_id " +
                "FULL JOIN accepted_requests ON accepted_requests.accepted_request_id = requests.id " +
                "FULL JOIN completed_requests ON completed_requests.completed_request_id = requests.id WHERE county = @county";

            List<Request> requests = new List<Request>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(GetAllRequestsSQL, conn);
                    cmd.Parameters.AddWithValue("@county", county);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        requests.Add(MapRowToItemsExtended(reader));
                    }
                }
                return requests;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<Request> GetUserRequests(int userId)
        {
            string GetUserRequestsSQL = "SELECT * FROM requests JOIN users ON users.id = requests.user_id WHERE is_accepted = 0 AND users.id <> @user_id ORDER BY county";
            List<Request> requests = new List<Request>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(GetUserRequestsSQL, conn);
                    cmd.Parameters.AddWithValue("@user_id", userId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        requests.Add(MapRowToItems(reader));
                    }
                }
                return requests;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<Request> GetRequestByCounty(string county, int userId)
        {
            string GetRequestByCountySQL = "SELECT * FROM requests JOIN users ON users.id = requests.user_id WHERE is_accepted = 0 AND county = @county AND users.id <> @user_id";
            List<Request> requests = new List<Request>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(GetRequestByCountySQL, conn);
                cmd.Parameters.AddWithValue("@county", county);
                cmd.Parameters.AddWithValue("@user_id", userId);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    requests.Add(MapRowToItems(reader));
                }
            }
            return requests;
        }

        public List<Request> GetRequestsByUserId(int userId)
        {
            string GetRequestsByUserIdSQL = "SELECT * FROM requests JOIN users ON users.id = requests.user_id " +
                "FULL JOIN accepted_requests ON accepted_requests.accepted_request_id = requests.id " +
                "FULL JOIN completed_requests ON completed_requests.completed_request_id = requests.id " +
                "WHERE users.id = @user_id";
            List<Request> requests = new List<Request>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(GetRequestsByUserIdSQL, conn);
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        requests.Add(MapRowToItemsExtended(reader));
                    }
                    return requests;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Request GetRequestsByRequestId(int requestId)
        {
            string GetRequestsByRequestIdSQL = "SELECT * FROM requests JOIN users ON users.id = requests.user_id " +
                "FULL JOIN accepted_requests ON accepted_requests.accepted_request_id = requests.id " +
                "FULL JOIN completed_requests ON completed_requests.completed_request_id = requests.id " +
                "WHERE requests.id = @id";
            Request request = new Request();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(GetRequestsByRequestIdSQL, conn);
                    cmd.Parameters.AddWithValue("@id", requestId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        request = MapRowToItemsExtended(reader);
                    }
                }
                return request;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<Request> IncompleteRequestsByAcceptedUser(int userId)
        {
            string IncompleteRequestsByAcceptedUserSQL = "SELECT * FROM requests JOIN users ON users.id = requests.user_id " +
                "JOIN accepted_requests ON accepted_requests.accepted_request_id = requests.id " +
                "WHERE accepted_requests.accepted_user_id = @user_id AND is_completed = 0";
            List<Request> requests = new List<Request>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(IncompleteRequestsByAcceptedUserSQL, conn);
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        requests.Add(MapRowToItems(reader));
                    }
                }
                return requests;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<string> GetCounties(int userId)
        {
            string GetCountiesSQL = "SELECT county FROM users JOIN requests ON requests.user_id = users.id WHERE users.id <> @id GROUP BY county";
            List<string> counties = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(GetCountiesSQL, conn);
                cmd.Parameters.AddWithValue("@id", userId);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    counties.Add(Convert.ToString(reader["county"]));
                }
            }
            return counties;
        }

        public void AddRequest(Request request, int userId)
        {
            string AddRequestSQL = "INSERT INTO requests(user_id, toilet_paper, paper_towels, hand_soap, shampoo, conditioner, toothpaste, " +
                "disinfectant, dairy, bread, produce, canned_food, meat, seafood, cereal, pantry, allergens) " +
                "VALUES (@user_id, @toilet_paper, @paper_towels, @hand_soap, @shampoo, @conditioner, @toothpaste, @disinfectant, @dairy, @bread, " +
                "@produce, @canned_food, @meat, @seafood, @cereal, @pantry, @allergens)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(AddRequestSQL, conn);
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    if (request.ToiletPaper == null)
                    {
                        cmd.Parameters.AddWithValue("@toilet_paper", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@toilet_paper", request.ToiletPaper);
                    }
                    if (request.PaperTowels == null)
                    {
                        cmd.Parameters.AddWithValue("@paper_towels", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@paper_towels", request.PaperTowels);
                    }
                    if (request.HandSoap == null)
                    {
                        cmd.Parameters.AddWithValue("@hand_soap", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@hand_soap", request.HandSoap);
                    }
                    if (request.Shampoo == null)
                    {
                        cmd.Parameters.AddWithValue("@shampoo", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@shampoo", request.Shampoo);
                    }
                    if (request.Conditioner == null)
                    {
                        cmd.Parameters.AddWithValue("@conditioner", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@conditioner", request.Conditioner);
                    }
                    if (request.Toothpaste == null)
                    {
                        cmd.Parameters.AddWithValue("@toothpaste", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@toothpaste", request.Toothpaste);
                    }
                    if (request.Disinfectant == null)
                    {
                        cmd.Parameters.AddWithValue("@disinfectant", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@disinfectant", request.Disinfectant);
                    }
                    if (request.Dairy == null)
                    {
                        cmd.Parameters.AddWithValue("@dairy", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@dairy", request.Dairy);
                    }
                    if (request.Bread == null)
                    {
                        cmd.Parameters.AddWithValue("@bread", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@bread", request.Bread);
                    }
                    if (request.Produce == null)
                    {
                        cmd.Parameters.AddWithValue("@produce", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@produce", request.Produce);
                    }
                    if (request.CannedFood == null)
                    {
                        cmd.Parameters.AddWithValue("@canned_food", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@canned_food", request.CannedFood);
                    }
                    if (request.Meat == null)
                    {
                        cmd.Parameters.AddWithValue("@meat", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@meat", request.Meat);
                    }
                    if (request.Seafood == null)
                    {
                        cmd.Parameters.AddWithValue("@seafood", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@seafood", request.Seafood);
                    }
                    if (request.Cereal == null)
                    {
                        cmd.Parameters.AddWithValue("@cereal", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@cereal", request.Cereal);
                    }
                    if (request.Pantry == null)
                    {
                        cmd.Parameters.AddWithValue("@pantry", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@pantry", request.Pantry);
                    }
                    if (request.Allergens == null)
                    {
                        cmd.Parameters.AddWithValue("@allergens", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@allergens", request.Allergens);
                    }
                    cmd.ExecuteNonQuery();

                    return;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void AddAcceptedRequest(int requestId, int acceptedUserId, string acceptedUserFirstName, string acceptedUserLastName, string acceptedUserEmail, string acceptedUserPhoneNumber)
        {
            string AddAcceptedRequestSQL = "INSERT INTO accepted_requests(accepted_request_id, accepted_user_id, accepted_user_first_name, accepted_user_last_name, accepted_user_email, accepted_user_phone_number) " +
                "VALUES (@request_id, @accepted_user_id, @first_name, @last_name, @email, @phone_number)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(AddAcceptedRequestSQL, conn);
                    cmd.Parameters.AddWithValue("@request_id", requestId);
                    cmd.Parameters.AddWithValue("@accepted_user_id", acceptedUserId);
                    cmd.Parameters.AddWithValue("@first_name", acceptedUserFirstName);
                    cmd.Parameters.AddWithValue("@last_name", acceptedUserLastName);
                    cmd.Parameters.AddWithValue("@email", acceptedUserEmail);
                    cmd.Parameters.AddWithValue("@phone_number", acceptedUserPhoneNumber);

                    cmd.ExecuteNonQuery();

                    UpdateRequestStatusAccepted(requestId);
                    return;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            //figure out how to send email confirmation to both parties
        }

        public void UpdateRequestStatusAccepted(int requestId)
        {
            string UpdateRequestStatusAcceptedSQL = "UPDATE requests SET is_accepted = 1 WHERE id = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(UpdateRequestStatusAcceptedSQL, conn);
                    cmd.Parameters.AddWithValue("@id", requestId);

                    cmd.ExecuteNonQuery();

                    return;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void AddCompletedRequest(int requestId, int acceptedUserId, string acceptedUserFirstName, string acceptedUserLastName, string acceptedUserEmail, string acceptedUserPhoneNumber)
        {
            string AddCompletedRequestSQL = "INSERT INTO completed_requests(completed_request_id, completed_user_id, completed_user_first_name, completed_user_last_name, completed_user_email, completed_user_phone_number) " +
                "VALUES (@request_id, @accepted_user_id, @first_name, @last_name, @email, @phone_number)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(AddCompletedRequestSQL, conn);
                    cmd.Parameters.AddWithValue("@request_id", requestId);
                    cmd.Parameters.AddWithValue("@accepted_user_id", acceptedUserId);
                    cmd.Parameters.AddWithValue("@first_name", acceptedUserFirstName);
                    cmd.Parameters.AddWithValue("@last_name", acceptedUserLastName);
                    cmd.Parameters.AddWithValue("@email", acceptedUserEmail);
                    cmd.Parameters.AddWithValue("@phone_number", acceptedUserPhoneNumber);

                    cmd.ExecuteNonQuery();

                    UpdateRequestStatusCompleted(requestId);
                    return;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            //figure out how to send email confirmation to both parties
        }

        public void UpdateRequestStatusCompleted(int requestId)
        {
            string UpdateRequestStatusCompletedSQL = "UPDATE requests SET is_completed = 1 WHERE id = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(UpdateRequestStatusCompletedSQL, conn);
                    cmd.Parameters.AddWithValue("@is_completed", 1);
                    cmd.Parameters.AddWithValue("@id", requestId);

                    cmd.ExecuteNonQuery();

                    return;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void DeleteRequest(int requestId)
        {
            string DeleteRequestSQL = "DELETE FROM requests WHERE id = @id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(DeleteRequestSQL, conn);
                    cmd.Parameters.AddWithValue("@id", requestId);

                    cmd.ExecuteNonQuery();

                    return;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private Request MapRowToItems(SqlDataReader reader)
        {
            Request request = new Request();
            request.Id = Convert.ToInt32(reader["id"]);
            request.IsAccepted = Convert.ToInt32(reader["is_accepted"]);
            request.IsCompleted = Convert.ToInt32(reader["is_completed"]);
            request.Email = Convert.ToString(reader["email"]);
            request.FirstName = Convert.ToString(reader["first_name"]);
            request.LastName = Convert.ToString(reader["last_name"]);
            request.PhoneNumber = Convert.ToString(reader["phone_number"]);
            request.Date = Convert.ToDateTime(reader["request_date"]);
            request.County = Convert.ToString(reader["county"]);
            request.ToiletPaper = Convert.ToString(reader["toilet_paper"]);
            request.PaperTowels = Convert.ToString(reader["paper_towels"]);
            request.HandSoap = Convert.ToString(reader["hand_soap"]);
            request.Shampoo = Convert.ToString(reader["shampoo"]);
            request.Conditioner = Convert.ToString(reader["conditioner"]);
            request.Toothpaste = Convert.ToString(reader["toothpaste"]);
            request.Disinfectant = Convert.ToString(reader["disinfectant"]);
            request.Dairy = Convert.ToString(reader["dairy"]);
            request.Bread = Convert.ToString(reader["bread"]);
            request.Produce = Convert.ToString(reader["produce"]);
            request.CannedFood = Convert.ToString(reader["canned_food"]);
            request.Meat = Convert.ToString(reader["meat"]);
            request.Seafood = Convert.ToString(reader["seafood"]);
            request.Cereal = Convert.ToString(reader["cereal"]);
            request.Pantry = Convert.ToString(reader["pantry"]);
            request.Allergens = Convert.ToString(reader["allergens"]);

            return request;
        }

        private Request MapRowToItemsExtended(SqlDataReader reader)
        {
            Request request = new Request();
            request.Id = Convert.ToInt32(reader["id"]);
            request.IsAccepted = Convert.ToInt32(reader["is_accepted"]);
            request.IsCompleted = Convert.ToInt32(reader["is_completed"]);
            request.Email = Convert.ToString(reader["email"]);
            request.FirstName = Convert.ToString(reader["first_name"]);
            request.LastName = Convert.ToString(reader["last_name"]);
            request.PhoneNumber = Convert.ToString(reader["phone_number"]);
            request.County = Convert.ToString(reader["county"]);
            request.Date = Convert.ToDateTime(reader["request_date"]);
            request.AcceptedUserEmail = Convert.ToString(reader["accepted_user_email"]);
            request.AcceptedUserFirstName = Convert.ToString(reader["accepted_user_first_name"]);
            request.AcceptedUserLastName = Convert.ToString(reader["accepted_user_last_name"]);
            request.AcceptedUserPhoneNumber = Convert.ToString(reader["accepted_user_phone_number"]);
            if (DBNull.Value.Equals(reader["accepted_date"]))
            {
                request.AcceptedDate = DateTime.Today;
            }
            else
            {
                request.AcceptedDate = Convert.ToDateTime(reader["accepted_date"]);
            }
            if (DBNull.Value.Equals(reader["completed_date"]))
            {
                request.AcceptedDate = DateTime.Today;
            }
            else
            {
                request.CompletedDate = Convert.ToDateTime(reader["completed_date"]);
            }
            request.ToiletPaper = Convert.ToString(reader["toilet_paper"]);
            request.PaperTowels = Convert.ToString(reader["paper_towels"]);
            request.HandSoap = Convert.ToString(reader["hand_soap"]);
            request.Shampoo = Convert.ToString(reader["shampoo"]);
            request.Conditioner = Convert.ToString(reader["conditioner"]);
            request.Toothpaste = Convert.ToString(reader["toothpaste"]);
            request.Disinfectant = Convert.ToString(reader["disinfectant"]);
            request.Dairy = Convert.ToString(reader["dairy"]);
            request.Bread = Convert.ToString(reader["bread"]);
            request.Produce = Convert.ToString(reader["produce"]);
            request.CannedFood = Convert.ToString(reader["canned_food"]);
            request.Meat = Convert.ToString(reader["meat"]);
            request.Seafood = Convert.ToString(reader["seafood"]);
            request.Cereal = Convert.ToString(reader["cereal"]);
            request.Pantry = Convert.ToString(reader["pantry"]);
            request.Allergens = Convert.ToString(reader["allergens"]);

            return request;
        }
    }
}
