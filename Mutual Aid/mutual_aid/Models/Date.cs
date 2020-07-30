using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mutual_aid.Models
{
    public class Date
    {
        public string CurrentDate()
        {
            int date = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            string currentDate = "";

            if (month == 1)
            {
                if (date == 1 || date == 21 || date == 31)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, January {@DateTime.Now.Day}st, {DateTime.Now.Year}";
                }
                else if (date == 2 || date == 22)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, January {@DateTime.Now.Day}nd, {DateTime.Now.Year}";
                }
                else if (date == 3 || date == 23)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, January {@DateTime.Now.Day}rd, {DateTime.Now.Year}";
                }
                else
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, January {@DateTime.Now.Day}th, {DateTime.Now.Year}";
                }
            }
            else if (month == 2)
            {
                if (date == 1 || date == 21 || date == 31)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, February {@DateTime.Now.Day}st, {DateTime.Now.Year}";
                }
                else if (date == 2 || date == 22)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, February {@DateTime.Now.Day}nd, {DateTime.Now.Year}";
                }
                else if (date == 3 || date == 23)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, February {@DateTime.Now.Day}rd, {DateTime.Now.Year}";
                }
                else
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, February {@DateTime.Now.Day}th, {DateTime.Now.Year}";
                }
            }
            else if (month == 3)
            {
                if (date == 1 || date == 21 || date == 31)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, March {@DateTime.Now.Day}st, {DateTime.Now.Year}";
                }
                else if (date == 2 || date == 22)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, March {@DateTime.Now.Day}nd, {DateTime.Now.Year}";
                }
                else if (date == 3 || date == 23)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, March {@DateTime.Now.Day}rd, {DateTime.Now.Year}";
                }
                else
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, March {@DateTime.Now.Day}th, {DateTime.Now.Year}";
                }
            }
            else if (month == 4)
            {
                if (date == 1 || date == 21 || date == 31)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, April {@DateTime.Now.Day}st, {DateTime.Now.Year}";
                }
                else if (date == 2 || date == 22)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, April {@DateTime.Now.Day}nd, {DateTime.Now.Year}";
                }
                else if (date == 3 || date == 23)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, April {@DateTime.Now.Day}rd, {DateTime.Now.Year}";
                }
                else
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, April {@DateTime.Now.Day}th, {DateTime.Now.Year}";
                }
            }
            else if (month == 5)
            {
                if (date == 1 || date == 21 || date == 31)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, May {@DateTime.Now.Day}st, {DateTime.Now.Year}";
                }
                else if (date == 2 || date == 22)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, May {@DateTime.Now.Day}nd, {DateTime.Now.Year}";
                }
                else if (date == 3 || date == 23)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, May {@DateTime.Now.Day}rd, {DateTime.Now.Year}";
                }
                else
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, May {@DateTime.Now.Day}th, {DateTime.Now.Year}";
                }
            }
            else if (month == 6)
            {
                if (date == 1 || date == 21 || date == 31)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, June {@DateTime.Now.Day}st, {DateTime.Now.Year}";
                }
                else if (date == 2 || date == 22)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, June {@DateTime.Now.Day}nd, {DateTime.Now.Year}";
                }
                else if (date == 3 || date == 23)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, June {@DateTime.Now.Day}rd, {DateTime.Now.Year}";
                }
                else
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, June {@DateTime.Now.Day}th, {DateTime.Now.Year}";
                }
            }
            else if (month == 7)
            {
                if (date == 1 || date == 21 || date == 31)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, July {@DateTime.Now.Day}st, {DateTime.Now.Year}";
                }
                else if (date == 2 || date == 22)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, July {@DateTime.Now.Day}nd, {DateTime.Now.Year}";
                }
                else if (date == 3 || date == 23)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, July {@DateTime.Now.Day}rd, {DateTime.Now.Year}";
                }
                else
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, July {@DateTime.Now.Day}th, {DateTime.Now.Year}";
                }
            }
            else if (month == 8)
            {
                if (date == 1 || date == 21 || date == 31)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, August {@DateTime.Now.Day}st, {DateTime.Now.Year}";
                }
                else if (date == 2 || date == 22)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, August {@DateTime.Now.Day}nd, {DateTime.Now.Year}";
                }
                else if (date == 3 || date == 23)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, August {@DateTime.Now.Day}rd, {DateTime.Now.Year}";
                }
                else
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, August {@DateTime.Now.Day}th, {DateTime.Now.Year}";
                }
            }
            else if (month == 9)
            {
                if (date == 1 || date == 21 || date == 31)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, September {@DateTime.Now.Day}st, {DateTime.Now.Year}";
                }
                else if (date == 2 || date == 22)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, September {@DateTime.Now.Day}nd, {DateTime.Now.Year}";
                }
                else if (date == 3 || date == 23)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, September {@DateTime.Now.Day}rd, {DateTime.Now.Year}";
                }
                else
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, September {@DateTime.Now.Day}th, {DateTime.Now.Year}";
                }
            }
            else if (month == 10)
            {
                if (date == 1 || date == 21 || date == 31)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, October {@DateTime.Now.Day}st, {DateTime.Now.Year}";
                }
                else if (date == 2 || date == 22)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, October {@DateTime.Now.Day}nd, {DateTime.Now.Year}";
                }
                else if (date == 3 || date == 23)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, October {@DateTime.Now.Day}rd, {DateTime.Now.Year}";
                }
                else
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, October {@DateTime.Now.Day}th, {DateTime.Now.Year}";
                }
            }
            else if (month == 11)
            {
                if (date == 1 || date == 21 || date == 31)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, November {@DateTime.Now.Day}st, {DateTime.Now.Year}";
                }
                else if (date == 2 || date == 22)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, November {@DateTime.Now.Day}nd, {DateTime.Now.Year}";
                }
                else if (date == 3 || date == 23)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, November {@DateTime.Now.Day}rd, {DateTime.Now.Year}";
                }
                else
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, November {@DateTime.Now.Day}th, {DateTime.Now.Year}";
                }
            }
            else if (month == 12)
            {
                if (date == 1 || date == 21 || date == 31)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, December {@DateTime.Now.Day}st, {DateTime.Now.Year}";
                }
                else if (date == 2 || date == 22)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, December {@DateTime.Now.Day}nd, {DateTime.Now.Year}";
                }
                else if (date == 3 || date == 23)
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, December {@DateTime.Now.Day}rd, {DateTime.Now.Year}";
                }
                else
                {
                    currentDate = $"{DateTime.Now.DayOfWeek}, December {@DateTime.Now.Day}th, {DateTime.Now.Year}";
                }
            }

            return currentDate;
        }
    }
}
