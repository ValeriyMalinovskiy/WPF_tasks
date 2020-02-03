using FileStore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace BicycleStore.Model
{
    internal class ImagePathHelper
    {
        private BitmapImage ConvertBitmapToImage(Bitmap bitmap)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
                memoryStream.Position = 0;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();

                return bitmapImage;
            }
        }

        public BitmapImage GetImageByModel(string model)
        {
            ResourceManager MyResourceClass = new ResourceManager(typeof(Resource));
            ResourceSet resourceSet = Resource.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            foreach (DictionaryEntry entry in resourceSet)
            {
                model = model.Replace(' ', '_');
                model = model.Replace('.', '_');
                if (model == entry.Key.ToString())
                {
                    return this.ConvertBitmapToImage(entry.Value as Bitmap);
                }
            }
            return this.ConvertBitmapToImage(Resource.no_image_found);
        }
    }
}
