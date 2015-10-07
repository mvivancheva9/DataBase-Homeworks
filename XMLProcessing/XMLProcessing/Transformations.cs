using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace XMLProcessing
{
    class Transformations
    {
        internal static void Transform(string direcctory)
        {
            var xslt = new XslCompiledTransform();
            xslt.Load(direcctory);
            xslt.Transform("../../catalog.xml", "../../catalog.html");
        }
    }
}
