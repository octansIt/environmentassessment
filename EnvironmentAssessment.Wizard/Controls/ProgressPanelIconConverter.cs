using System;
using System.Windows.Data;

namespace EnvironmentAssessment.Controls
{
    using Common;
    using System.Collections.Generic;
    using System.Windows.Media.Imaging;

    class ProgressPanelIconConverter : IValueConverter
    {
        private Dictionary<string, BitmapImage> ImageList = new Dictionary<string, BitmapImage> { };

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            CTaskInfo.State status = ((CTaskInfo)value).Status;

            string img = "info.png";

            if (status != null)
            {
                img = "active.png";
                if (status == CTaskInfo.State.Success) { img = "success.png"; }
                else if (status == CTaskInfo.State.Warning) { img = "warning.png"; }
                else if (status == CTaskInfo.State.Error) { img = "error.png"; }
            }

            if (!ImageList.ContainsKey(img)) { ImageList.Add(img, new BitmapImage(new Uri("/Resources/" + img, UriKind.Relative))); }

            return ImageList[img];
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
