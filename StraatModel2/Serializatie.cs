﻿using Labo;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace StraatModel2
{
    class Serializatie
    {
        static public void SerializeProvinciesInBinary()
        {
            
            List<Provincie> provincies = Factories.ProvincieFactory();
            using (Stream stream = File.Open(@"C:\Users\Biebem\Downloads\provincie.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(stream, provincies);
            }
        }
        static public List<Provincie> DeSerializeProvinciesBinary()
        {
            List<Provincie> provincies;
            using (Stream stream = File.Open(@"C:\Users\Biebem\Downloads\provincie.dat", FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                provincies = (List<Provincie>)bf.Deserialize(stream);
            }
            return provincies;
        }
        #region test
        //static public void SerializeProvincieInXML() 
        //{
        //    Provincie test = new Provincie(2, "Oost-Vlaanderen", new List<Gemeente> {new Gemeente(1,"testGemeente",new List<Straat> {new Straat(2,"Hippoliet",new Graaf(2)) } )});
        //    XmlSerializer serializer = new XmlSerializer(typeof(Provincie));
        //    using (TextWriter tw = new StreamWriter(@"C:\Users\Biebem\Downloads\provincie.xml"))
        //    {
        //        serializer.Serialize(tw, test);
        //    }
        //}
        //static public Provincie DeSerializeProvincieInXML() 
        //{
        //    Provincie test;
        //    XmlSerializer deserialiezr = new XmlSerializer(typeof(Provincie));
        //    using (TextReader tr = new StreamReader(@"C:\Users\Biebem\Downloads\provincie.xml")) 
        //    {
        //        test = (Provincie)deserialiezr.Deserialize(tr);
        //    }
        //    return test;
        //}
        #endregion
    }
}
