using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Models
{
    public class Time
    {
        public int ID { get; set; }
        public int TimeCodeID { get; set; }
        public decimal TimeWorked { get; set; }
        public int StartTimeHour { get; set; }
        public decimal StartTimeMinute { get; set; }
        public int EndTimeHour { get; set; }
        public decimal EndTimeMinute { get; set; }

        public List<SelectListItem> Hours = new List<SelectListItem>
        {
                new SelectListItem() {Text = "24", Value= "24" },
                new SelectListItem() {Text = "23", Value= "23" },
                new SelectListItem() {Text = "22", Value= "22" },
                new SelectListItem() {Text = "21", Value= "21" },
                new SelectListItem() {Text = "20", Value= "20" },
                new SelectListItem() {Text = "19", Value= "19" },
                new SelectListItem() {Text = "18", Value= "18" },
                new SelectListItem() {Text = "17", Value= "17" },
                new SelectListItem() {Text = "16", Value= "16" },
                new SelectListItem() {Text = "15", Value= "15" },
                new SelectListItem() {Text = "14", Value= "14" },
                new SelectListItem() {Text = "13", Value= "13" },
                new SelectListItem() {Text = "12", Value= "12" },
                new SelectListItem() {Text = "11", Value= "11" },
                new SelectListItem() {Text = "10", Value= "10" },
                new SelectListItem() {Text = "09", Value= "9" },
                new SelectListItem() {Text = "08", Value= "8" },
                new SelectListItem() {Text = "07", Value= "7" },
                new SelectListItem() {Text = "06", Value= "6" },
                new SelectListItem() {Text = "05", Value= "5" },
                new SelectListItem() {Text = "04", Value= "4" },
                new SelectListItem() {Text = "03", Value= "3" },
                new SelectListItem() {Text = "02", Value= "2" },
                new SelectListItem() {Text = "01", Value= "1" }
        };

        public List<SelectListItem> Minutes = new List<SelectListItem>
        {
            new SelectListItem() { Text = "00", Value = "0"},
            new SelectListItem() { Text = "15", Value = ".25"},
            new SelectListItem() { Text = "30", Value = ".50"},
            new SelectListItem() { Text = "45", Value = ".75" }
        };
    }
}
