using System;
using System.Drawing;
using System.IO;
using System.Text;
using SuperSecretary.Utilities;

namespace SuperSecretary.Handlers
{
    public class CameraModelHandler : IHandler
    {
        private const int PROPERTY_ID = 0x0110;

        public string Name
        {
            get
            {
                return "Camera Model";
            }
        }

        public HandlerResult Do(string fileName, HandlerOptions options)
        {
            var result = new HandlerResult();

            try
            {
                result.Value = ExifUtilities.GetProperty(fileName, ExifProperties.CameraModel);
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }

            return result;
        }
    }
}
