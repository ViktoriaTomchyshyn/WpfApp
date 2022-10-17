using kpz2.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace kpz2.UI.Convertors
{
    public class ImagePathConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
                var status = ((OrderStatus)value).ToString();
                var uri = new Uri(string.Format(@"../Images/OrderStatus/status_{0}.png", status), UriKind.Relative);
                return new BitmapImage(uri);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
