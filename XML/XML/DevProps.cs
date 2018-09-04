
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace XML.XML
{

    class DevProps
    {
        string path = @"C:\Users\ShenBY\Desktop\date\DataFile\Bureau_WLMQ\Station_LTY\DevProps.xml";
        public DevProps()
        {
        }
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
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

        public static List<TrainWin> trainWins = new List<TrainWin>();
        public List<DevProps> devProps = new List<DevProps>();
        public XElement DevPropsLoad(string path)
        {

            XElement  xElement = XElement.Load(path);
            return xElement;
        }
        public IEnumerable<XElement> Load( string devtype)
        {
         
                IEnumerable<XElement> elementss = from el in DevPropsLoad(path).Elements("Devs")
                                                 select el;
                IEnumerable<XElement> elements = from el in elementss.Elements(devtype)
                                                 select el;
            
            
            return elements;
        }
    }
    class TrainWin: DevProps
    {
        public TrainWin()
        {
        }
        
        public  void   DevPropsLoad()
        {
           
            foreach (var ele in Load("TrainWin"))
            {
                TrainWin trainwin = new TrainWin();
                trainwin.id = ele.Attribute("id").Value;
                trainwin.name = ele.Attribute("name").Value;
                trainwin.Alias= ele.Attribute("Alias").Value;
                trainwin.RelatedDev= ele.Attribute("RelatedDev").Value;
                trainwin.ThroatType= ele.Attribute("ThroatType").Value;
                trainWins.Add(trainwin);
            }

        }
        
        

    }
    
}