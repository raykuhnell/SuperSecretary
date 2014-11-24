using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SuperSecretary.Utilities;

namespace SuperSecretary.Handlers
{
    public class Id3GenreHandler : IHandler
    {
        public string Name
        {
            get
            {
                return "Genre";
            }
        }

        public HandlerResult Do(string fileName, HandlerOptions options)
        {
            var result = new HandlerResult();

            try
            {
                var tags = Id3Utilities.GetTags(fileName);
                result.Value = tags.JoinedGenres;
            }
            catch (Exception ex)
            {
                result.Exception = ex;
            }

            return result;
        }
    }
}
