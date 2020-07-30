using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mutual_aid.Models
{
    public class Request
    {
        public int Id { get; set; }
        public int IsAccepted { get; set; }
        public int IsCompleted { get; set; }
        public string AcceptedUserFirstName { get; set; }
        public string AcceptedUserLastName { get; set; }
        public string AcceptedUserPhoneNumber { get; set; }
        public string AcceptedUserEmail { get; set; }
        public DateTime AcceptedDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public string County { get; set; }

        public IList<SelectListItem> Counties = new List<SelectListItem>();
        public void AddCounty(string s)
        {
            Counties.Add(new SelectListItem { Text = s, Value = s });
        }
        public List<Request> SearchResults { get; set; }
        public void ListRequests(Request req)
        {
            SearchResults.Add(req);
        }

        //toiletries 
        public string ToiletPaper { get; set; }
        public string PaperTowels { get; set; }
        public string HandSoap { get; set; }
        public string Shampoo { get; set; }
        public string Conditioner { get; set; }
        public string Toothpaste { get; set; }
        public string Disinfectant { get; set; }

        //food
        public string Dairy { get; set; }
        public string Bread { get; set; }
        public string Produce { get; set; }
        public string CannedFood { get; set; }
        public string Meat { get; set; }
        public string Seafood { get; set; }
        public string Cereal { get; set; }
        public string Pantry { get; set; }

        //allergies
        public string Allergens { get; set; }
    }
}
