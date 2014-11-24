using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace SuperSecretary.Updates
{
    [XmlRoot]
    public class Update
    {
        [XmlElement]
        public string Version;
        [XmlElement]
        public string FileName;
        [XmlElement]
        public string Url;
    }
}
