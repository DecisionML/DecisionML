using System;

namespace DecisionML
{
    public class DecisionMaker
    {
        System.Xml.XmlDocument document = new System.Xml.XmlDocument();
        public DecisionMaker(string path)
        {
            
            document.Load(path);
        }


       
    }
}
