using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebApi2Book.Common.Extensions
{
    public static class XDocSoapExtensions
    {
        public static XElement GetSoapBody(this XDocument doc)
        {
            var body = doc.Descendants().FirstOrDefault(x => x.Name.LocalName.ToLowerInvariant() == "body");
            return body;
        }
    }
}
