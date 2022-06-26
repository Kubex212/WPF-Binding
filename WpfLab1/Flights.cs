using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Globalization;

namespace WpfLab1
{
    public class Flight
    {
        public string Number { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public TimeSpan Duration { get; set; }
        public List<Crew> Members { get; set; }
    }

    public enum Role
    {
        Capitan, Officer, Steward
    }

    public class Crew
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Role Role { get; set; }
    }

    class TimeToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var time = (TimeSpan)value;
            string data = "";
            data += (time.TotalMinutes).ToString();
            data += " minutes";
            return data;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    class MyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var person = (Crew)value;

            return person.Name + " " + person.Surname;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
