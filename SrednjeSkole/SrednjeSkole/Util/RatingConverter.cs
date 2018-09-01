using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SrednjeSkole.Util
{
        
    class RatingConverter : IValueConverter
    {    
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var rating = (int)value;
            if (rating == 1)
                return "Loše!";
            if (rating == 2)
                return "Nako!";
            if (rating == 3)
                return "Može proć!";
            if (rating == 4)
                return "Dobar!";
            if (rating == 5)
                return "Odličan!";

            return "Nako! " + value.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
