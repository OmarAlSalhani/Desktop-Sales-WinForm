using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;

namespace ClientApp.classes
{
    /// <summary>
    /// this class is used for convert operations
    /// like convert image to byte
    /// </summary>
    class convert_class
    {
        // method used to convert image to byte , to stored it in database
        // it`s take one parameter the image we want to save it
        public static byte[] image_to_byte(Image image)
        {
            try
            {


                byte[] image_byte;
                MemoryStream memoryStream = new MemoryStream();
                image.Save(memoryStream, ImageFormat.Png);
                image_byte = new byte[memoryStream.Length];
                memoryStream.Position = 0;
                memoryStream.Read(image_byte, 0, image_byte.Length);
                return image_byte;
            }
            catch(Exception ex)
            {
                OmarNotifications.Alert.ShowInformation(ex.Message);
                return null;
            }
        }
    }
}
