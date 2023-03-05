using Hospital.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Domain.Core.Helpers
{
    public static class DateHelper
    {

        public static string CalculateAgeDescription(DateTime date) {
            string returnAge = "";

            if (date != null)
            {
                DateTime dateOfBirth = date;
                TimeSpan span = DateTime.Now - dateOfBirth;
                DateTime age = DateTime.MinValue + span;

                // Make adjustment due to MinValue equalling 1/1/1
                int years = age.Year - 1;
                int months = age.Month - 1;
                int days = age.Day - 1;

                returnAge = String.Format("{0} Years, {1} Months, {2} Days", years, months, days);
            }
            else
            {
                returnAge = "Unknown";
            }

            return returnAge;
        }

        public static int CalculateAgeYear(DateTime date)
        {
            int returnAge = 0;

            if (date != null)
            {
                DateTime dateOfBirth = date;
                TimeSpan span = DateTime.Now - dateOfBirth;
                DateTime age = DateTime.MinValue + span;

                // Make adjustment due to MinValue equalling 1/1/1
                int years = age.Year - 1;
                

                returnAge = years;
            }
            else
            {
                returnAge = 0;
            }

            return returnAge;
        }
    }
}
