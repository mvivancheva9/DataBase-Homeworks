using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLProcessing
{
    class Start
    {
        static void Main(string[] args)
        {
            string catalogueFileLocation = "../../catalogue.xml";

            DOMParser.ExtractWithDOMParser(catalogueFileLocation);
            CatalogueXPath.ExtractWithXPath(catalogueFileLocation);
            DOMParser.DeleteChild(catalogueFileLocation);
            XmlReaderFile.ExtractSongTitles(catalogueFileLocation);
            LINQManipulations.ExtractSongTitle(catalogueFileLocation);
            LINQManipulations.CreateXMLFile("../../person.txt");
            XmlReaderFile.WriteAlbumFile(catalogueFileLocation);
            XmlReaderFile.GenerateXmlDocument("D:\\Telerik Academy Courses\\DataBase\\DataBase-Homeworks\\XMLProcessing\\XMLProcessing");
            CatalogueXPath.GenerateXmlFile("D:\\Telerik Academy Courses\\DataBase\\DataBase-Homeworks\\XMLProcessing\\XMLProcessing");
            CatalogueXPath.ExtractAlbums(catalogueFileLocation);
            LINQManipulations.ExtractAlbums(catalogueFileLocation);
            Transformations.Transform("../..catalogue.xsl");
        }
    }
}
