using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.IO;


    [Serializable]
    [XmlRoot("Employee")]
    public class DictionaryClass<Tkey, TValue> : Dictionary<Tkey,TValue>, IXmlSerializable
    {
        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {

        XmlSerializer KeyDeserializer = new XmlSerializer(typeof(Tkey));
        XmlSerializer ValueDeserializer = new XmlSerializer(typeof(TValue));

        bool wasEmpty = reader.IsEmptyElement;
        if (wasEmpty)
        {
            return;
        }

        reader.ReadStartElement("Employee");

        while (reader.NodeType != XmlNodeType.EndElement)
        {
            reader.ReadStartElement("Item");

            reader.ReadStartElement("Key");
            Tkey key = (Tkey)KeyDeserializer.Deserialize(reader);
            reader.ReadEndElement();

            reader.ReadStartElement("Value");
            TValue value = (TValue)ValueDeserializer.Deserialize(reader);
            reader.ReadEndElement();

            reader.ReadEndElement();

            this.Add(key,value);

        }

        reader.ReadEndElement();

    }

    public void WriteXml(XmlWriter writer)
        {
            XmlSerializer keySerializer = new XmlSerializer(typeof(Tkey));

            //XmlSerializer serializer = new XmlSerializer(typeof(DictionaryClass<int, Employee>));

            XmlSerializer ValueSerializer = new XmlSerializer(typeof(Employee));

            //foreach(Tkey key in this.Keys)
            //{ 
            for (int i = 0; i < Keys.Count; i++)
            {
                Tkey key = Keys.ElementAt(i);
                TValue value = this.ElementAt(i).Value;

                writer.WriteStartElement("Item");

                writer.WriteStartElement("Key");
                keySerializer.Serialize(writer,key);
                writer.WriteEndElement();

                writer.WriteStartElement("Value");
                ValueSerializer.Serialize(writer,value);
                writer.WriteEndElement();

                writer.WriteEndElement();
            }
        }
    }
