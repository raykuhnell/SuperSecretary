using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TagLib;

namespace SuperSecretary.Utilities
{
    public class Id3Utilities
    {
        public static Tag GetTags(string fileName)
        {
            var f = File.Create(fileName);
            return f.GetTag(TagTypes.Id3v2);
        }
    }
}
