using System;
using System.Globalization;
using System.Text.RegularExpressions;
using eRecruiter.Utilities;

namespace eRecruiter.Api
{
    public class FlexDate : IComparable<FlexDate>, IComparable
    {
        #region Constructors

        public FlexDate()
        {
        }

        public FlexDate(int? day, int? month, int? year, bool isRelative = false)
        {
            Day = (day ?? 0) <= 0 ? null : day;
            Month = (month ?? 0) <= 0 ? null : month;
            Year = (year ?? 0) <= 0 ? null : year;
            IsRelativeDate = isRelative;
        }

        public FlexDate(DateTime date)
            : this(date.Day, date.Month, date.Year)
        {
        }

        public FlexDate(string date)
            : this(0, 0, 0, false)
        {
            if (string.IsNullOrEmpty(date) || string.IsNullOrWhiteSpace(date))
                return;

            date = date.Trim();

            var r = new Regex(@"^([dmy])(\d*)$");
            if (r.IsMatch(date))
            {
                var m = r.Match(date);
                int i = m.Groups[2].Value.GetInt();
                IsRelativeDate = true;
                switch (m.Groups[1].Value)
                {
                    case "d":
                        Day = i;
                        break;
                    case "m":
                        Month = i;
                        break;
                    case "y":
                        Year = i;
                        break;
                }
                return;
            }

            //01.02.03, 01.02.2003, 01/02/03, 01/02/2013
            r = new Regex(@"^(\d{1,2})[\./](\d{1,2})[\./](\d{1,4})$");
            if (r.IsMatch(date))
            {
                var m = r.Match(date);
                Day = m.Groups[1].Value.GetInt();
                Month = m.Groups[2].Value.GetInt();
                Year = m.Groups[3].Value.GetInt();
                return;
            }

            //01.02, 01.2002, 01/02, 01/2002
            r = new Regex(@"^(\d{1,2})[\./](\d{2,4})$");
            if (r.IsMatch(date))
            {
                var m = r.Match(date);
                Month = int.Parse(m.Groups[1].Value);
                Year = int.Parse(m.Groups[2].Value);
                return;
            }

            //01, 2001
            r = new Regex(@"^(\d{2,4})$");
            if (r.IsMatch(date))
            {
                var m = r.Match(date);
                Year = int.Parse(m.Groups[1].Value);
                return;
            }

            if (date.IsDate())
            {
                var d = date.GetDate();
                Day = d.Day;
                Month = d.Month;
                Year = d.Year;
                return;
            }
            throw new ArgumentException("The given parameter is not a flexdate", "date");
        }

        #endregion Constructors

        #region Properties

        public int? Year { get; set; }

        public int? Month { get; set; }

        public int? Day { get; set; }

        public bool IsRelativeDate { get; set; }

        #endregion Properties

        #region Methods

        public bool IsEmpty
        {
            get { return !(Year.HasValue || Month.HasValue || Day.HasValue); }
        }

        public static FlexDate FromString(string date)
        {
            return new FlexDate(date);
        }

        public DateTime ToDate()
        {
            if (IsRelativeDate)
            {
                var relativeDate = DateTime.Now;
                if (Day.HasValue)
                {
                    relativeDate = relativeDate.AddDays(Day.Value);
                }
                if (Month.HasValue)
                {
                    relativeDate = relativeDate.AddMonths(Month.Value);
                }
                if (Year.HasValue)
                {
                    relativeDate = relativeDate.AddYears(Year.Value);
                }
                return relativeDate;
            }
            return new DateTime(
                Year.HasValue && Year.Value > 0 ? Year.Value : 1901,
                Month.HasValue && Month.Value > 0 && Month.Value <= 12 ? Month.Value : 1,
                Day.HasValue && Day.Value > 0 && Day.Value <= 31 ? Day.Value : 1);
        }

        /// <summary>
        /// If <see cref="IsRelativeDate">IsRelativeDate</see>> property is set to true, 
        /// the returned string has a format of "[d|m|y][number]. e.g. "d7", "m3" or "y2013".
        /// If <see cref="IsRelativeDate">IsRelativeDate</see>> property is set to false, 
        /// a complete absolute date is represented as a string in format "dd.MM.yyyy".
        /// A certain month in a year is represented as in a format "MM/yyyy".
        /// A year is in format "yyyy".
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (IsRelativeDate)
            {
                if (Day.HasValue && Day.Value != 0)
                {
                    return "d" + Day.Value;
                }
                if (Year.HasValue && Year.Value != 0)
                {
                    return "y" + Year.Value;
                }
                if (Month.HasValue && Month.Value != 0)
                {
                    return "m" + Month.Value;
                }
                return string.Empty;
            }
            if (Year.HasValue && Year.Value > 0)
            {
                if (Month.HasValue && Month.Value > 0)
                {
                    if (Day.HasValue && Day.Value > 0)
                    {
                        return ToDate().ToString("dd.MM.yyyy");
                    }
                    return Month + "/" + Year;
                }
                return Year.Value.ToString(CultureInfo.InvariantCulture);
            }
            return string.Empty;
        }

        #endregion Methods

        #region IComparable

        public int CompareTo(object obj)
        {
            if (obj is FlexDate)
            {
                return CompareTo(obj as FlexDate);
            }
            throw new ArgumentException("The given type is not of type Flexdate", "obj");
        }

        /// <summary>
        /// Compares the value of this instance to a specified <see cref="FlexDate"/> value and returns an integer that indicates whether this instance is earlier than, the same as, or later than the specified <see cref="FlexDate"/> value.
        /// Notice: the empty date defines the borders of the range of a flex date, which means that the empty date is the lowest and the greatest boundary (empty date &lt; any date &lt; empty date).
        /// </summary>
        /// <param name="other">The flexible date object to compare to the current instance.</param>
        /// <returns>A signed number indicating the relative values of this instance and the value parameter.
        /// Value Description
        /// Less than zero This instance is earlier than value.
        /// Zero This instance is the same as value. 
        /// Greater than zero This instance is later than value.
        /// </returns>
        public int CompareTo(FlexDate other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other");
            }
            /* Special case: an empty date defines the borders of the flex date type.
             *  empty date < any date
             *  any date < empty date (to current date)
             */
            if ((IsEmpty && !other.IsEmpty) || (!IsEmpty && other.IsEmpty))
            {
                return -1;
            }
            return ToDate().Date.CompareTo(other.ToDate().Date);
        }

        #endregion IComparable
    }
}