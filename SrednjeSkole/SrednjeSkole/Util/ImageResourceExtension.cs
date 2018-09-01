using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SrednjeSkole.Util
{
    [ContentProperty("Source")]
    class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;
            var imageSource = ImageSource.FromResource(Source);
            return imageSource;
        }
    }
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            byte[] bytes = value as byte[];

            Func<Stream> myFunc = () => new MemoryStream(bytes);

            return ImageSource.FromStream(myFunc);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
