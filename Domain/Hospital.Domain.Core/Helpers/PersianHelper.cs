using System.Globalization;

namespace Hospital.Domain.Core.Helpers
{
    public static class PersianHelper
    {
        public static string TodayDate()
        {
            string Today = "";

            PersianCalendar pc = new PersianCalendar();
            DateTime thisDate = DateTime.Now;

            string PYear = pc.GetYear(thisDate).ToString();
            string PMonth = pc.GetMonth(thisDate).ToString();
            if (PMonth.Length < 2)
                PMonth = "0" + PMonth;

            string PDay = pc.GetDayOfMonth(thisDate).ToString();
            if (PDay.Length < 2)
                PDay = "0" + PDay;

            Today = PYear + "/" + PMonth + "/" + PDay;

            return Today;
        }

        public static string TodayDateDescription()
        {
            string Today = "";

            PersianCalendar pc = new PersianCalendar();
            DateTime thisDate = DateTime.Now;

            string PYear = pc.GetYear(thisDate).ToString();
            string PMonth = "";
            switch (pc.GetMonth(thisDate))
            {
                case 1:
                    PMonth = "فروردین";
                    break;
                case 2:
                    PMonth = "اردیبهشت";
                    break;
                case 3:
                    PMonth = "خرداد";
                    break;
                case 4:
                    PMonth = "تیر";
                    break;
                case 5:
                    PMonth = "مرداد";
                    break;
                case 6:
                    PMonth = "شهریور";
                    break;
                case 7:
                    PMonth = "مهر";
                    break;
                case 8:
                    PMonth = "آبان";
                    break;
                case 9:
                    PMonth = "آذر";
                    break;
                case 10:
                    PMonth = "دی";
                    break;
                case 11:
                    PMonth = "بهمن";
                    break;
                case 12:
                    PMonth = "اسفند";
                    break;
            }


            string PDay = pc.GetDayOfMonth(thisDate).ToString();


            Today = PDay + " " + PMonth + " ماه " + PYear;

            return Today;
        }

        public static string PersianDate(string PDate)
        {

            string[] Parts = PDate.Split("/");
            string PYear = Parts[0];
            string PMonth = Parts[1];
            if (PMonth.Length < 2)
                PMonth = "0" + PMonth;

            string PDay = Parts[2];
            if (PDay.Length < 2)
                PDay = "0" + PDay;

            PDate = PYear + "/" + PMonth + "/" + PDay;

            return PDate;
        }

        public static string PersianDateDescription(string PDate)
        {

            string[] Parts = PDate.Split("/");
            string PYear = Parts[0];
            string PMonth = Parts[1];
            switch (Convert.ToInt32(PMonth))
            {
                case 1:
                    PMonth = "فروردین";
                    break;
                case 2:
                    PMonth = "اردیبهشت";
                    break;
                case 3:
                    PMonth = "خرداد";
                    break;
                case 4:
                    PMonth = "تیر";
                    break;
                case 5:
                    PMonth = "مرداد";
                    break;
                case 6:
                    PMonth = "شهریور";
                    break;
                case 7:
                    PMonth = "مهر";
                    break;
                case 8:
                    PMonth = "آبان";
                    break;
                case 9:
                    PMonth = "آذر";
                    break;
                case 10:
                    PMonth = "دی";
                    break;
                case 11:
                    PMonth = "بهمن";
                    break;
                case 12:
                    PMonth = "اسفند";
                    break;
            }

            string PDay = Parts[2];


            PDate = PDay + " " + PMonth + " ماه " + PYear;

            return PDate;
        }

        public static string NowLongTime()
        {
            string Time = "";
            DateTime thisDate = DateTime.Now;

            string Hour = thisDate.Hour.ToString();
            if (Hour.Length < 2)
                Hour = "0" + Hour;

            string Minute = thisDate.Minute.ToString();
            if (Minute.Length < 2)
                Minute = "0" + Minute;

            string Second = thisDate.Second.ToString();
            if (Second.Length < 2)
                Second = "0" + Second;

            Time = Hour + ":" + Minute + ":" + Second;
            return Time;
        }
        public static string NowShortTime()
        {
            string Time = "";
            DateTime thisDate = DateTime.Now;

            string Hour = thisDate.Hour.ToString();
            if (Hour.Length < 2)
                Hour = "0" + Hour;

            string Minute = thisDate.Minute.ToString();
            if (Minute.Length < 2)
                Minute = "0" + Minute;

            string Second = thisDate.Second.ToString();
            if (Second.Length < 2)
                Second = "0" + Second;

            Time = Hour + ":" + Minute;

            return Time;
        }

        public static DateTime PersianDateStringToDateTime(string persianDate)
        {
            PersianCalendar pc = new PersianCalendar();

            var persianDateSplitedParts = persianDate.Split('/');
            DateTime dateTime = new DateTime(int.Parse(persianDateSplitedParts[0]), int.Parse(persianDateSplitedParts[1]), int.Parse(persianDateSplitedParts[2]), pc);
            string pDate = dateTime.ToString(CultureInfo.InvariantCulture);
            pDate = pDate.Substring(0, 10);
            DateTime date = DateTime.ParseExact(pDate, "MM/dd/yyyy", null);
            return date;
        }

        public static DateTime PersianDateToPersianDateTime(string persianDate)
        {
            PersianCalendar pc = new PersianCalendar();

            var persianDateSplitedParts = persianDate.Split('/');
            DateTime dateTime = new DateTime(int.Parse(persianDateSplitedParts[0]), int.Parse(persianDateSplitedParts[1]), int.Parse(persianDateSplitedParts[2]), pc);
            string pDate = dateTime.ToString(CultureInfo.CurrentCulture);
            pDate = pDate.Substring(0, 10);
            DateTime date = DateTime.ParseExact(pDate, "MM/dd/yyyy", null);
            return date;
        }

        public static string DateTimeToPersianDate(DateTime date)
        {
            var calendar = new PersianCalendar();
            var persianDate = new DateTime(calendar.GetYear(date), calendar.GetMonth(date), calendar.GetDayOfMonth(date));
            var result = persianDate.ToString("yyyy/MM/dd", CultureInfo.CurrentCulture);

            return result;
        }


    }
}
