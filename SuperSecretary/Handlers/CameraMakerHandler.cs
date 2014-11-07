using System;
using System.Drawing;
using System.IO;
using System.Text;
using SuperSecretary.Utilities;

namespace SuperSecretary.Handlers
{
    public class CameraMakerHandler : IHandler
    {
        public string Name
        {
            get
            {
                return "Camera Maker";
            }
        }

        public HandlerResult Do(string fileName, HandlerOptions options)
        {
            var result = new HandlerResult();

            try
            {
                result.Value = ExifUtilities.GetProperty(fileName, ExifProperties.CameraMaker);
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }

            return result;
        }
    }
}
