
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace XML.XML
{
    class DevProps
    {
        public DevProps()
        {
        }
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public List<TrainWin> trainWins = new List<TrainWin>();
        public List<DevProps> devProps = new List<DevProps>();
        public void DevPropsLoad(string path)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;
            XmlReader reader = XmlReader.Create(path, settings);
            xmlDoc.Load(reader);

            if (xmlDoc != null)
            {
                XmlNodeList nodeList = xmlDoc.SelectNodes("/DevProps/Devs/TrainWin");
                //foreach (XmlNode nodes in nodeList)
                //{
                //        Console.WriteLine(nodes.Attributes["DevType"].Value.ToString());
                //        this.Type = nodes.Attributes["DevType"].Value.ToString();

                    foreach (XmlNode node in nodeList)
                    {
                        TrainWin trainWin = new TrainWin();
                        trainWin.name = node.Attributes["name"].Value.ToString();
                    trainWin.name = node.Attributes["id"].Value.ToString();
                    trainWin.Alias = node.Attributes["Alias"].Value.ToString();
                    trainWin.ThroatType = node.Attributes["ThroatType"].Value.ToString();
                    trainWin.RelatedDev = node.Attributes["RelatedDev"].Value.ToString();
                    this.trainWins.Add(trainWin);
                    Console.WriteLine(node.Attributes["name"].Value.ToString());
             

                    }
                    this.devProps.Add(new DevProps);
                //}
            }
            Console.WriteLine();
        }
    }
    class TrainWin: DevProps
    {
        public TrainWin()
        {
        }
        private string Name;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        private string Id;
        public string id
        {
            get { return Id; }
            set { Id = value; }
        }
        private string alias;
        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }
        private string throatType;
        public string ThroatType
        {
            get { return throatType; }
            set { throatType = value; }
        }
        private string relatedDev;
        public string RelatedDev
        {
            get { return relatedDev; }
            set { relatedDev = value; }
        }
        

    }
    
}