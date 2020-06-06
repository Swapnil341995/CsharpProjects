using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Schema;

    public class Employee : IXmlSerializable
    {
        public int Id = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Qualification { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public string Address { get; set; }
        public string PinCode { get; set; }
        public string BloodGroup { get; set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
        bool b;
        reader.ReadStartElement("Employee");

        b = reader.IsEmptyElement;
        reader.ReadStartElement("Id");
        if (!b)
        {
            Id = reader.ReadContentAsInt();
            reader.ReadEndElement();
        }

        b = reader.IsEmptyElement;
        reader.ReadStartElement("FirstName");
        if (!b)
        {
            FirstName = reader.ReadContentAsString();
            reader.ReadEndElement();
        }

        b = reader.IsEmptyElement;
        reader.ReadStartElement("LastName");
        if (!b)
        {
            LastName = reader.ReadContentAsString();
            reader.ReadEndElement();
        }

        b = reader.IsEmptyElement;
        reader.ReadStartElement("NickName");
        if (!b)
        {
            NickName = reader.ReadContentAsString();
            reader.ReadEndElement();
        }

        b = reader.IsEmptyElement;
        reader.ReadStartElement("Qualification");
        if (!b)
        {
            Qualification = reader.ReadContentAsString();
            reader.ReadEndElement();
        }

        b = reader.IsEmptyElement;
        reader.ReadStartElement("Country");
        if (!b)
        {
            Country = reader.ReadContentAsString();
            reader.ReadEndElement();
        }

        b = reader.IsEmptyElement;
        reader.ReadStartElement("State");
        if (!b)
        {
            State = reader.ReadContentAsString();
            reader.ReadEndElement();
        }

        b = reader.IsEmptyElement;
        reader.ReadStartElement("Town");
        if (!b)
        {
            Town = reader.ReadContentAsString();
            reader.ReadEndElement();
        }

        b = reader.IsEmptyElement;
        reader.ReadStartElement("Street");
        if (!b)
        {
            Street = reader.ReadContentAsString();
            reader.ReadEndElement();
        }

        b = reader.IsEmptyElement;
        reader.ReadStartElement("Address");
        if (!b)
        {
            Address = reader.ReadContentAsString();
            reader.ReadEndElement();
        }

        reader.ReadEndElement();

        }

        public void WriteXml(XmlWriter writer)
        {
        
        writer.WriteStartElement("Id");
            writer.WriteString(Id.ToString());
        writer.WriteEndElement();

        writer.WriteStartElement("FirstName");
            writer.WriteString(FirstName?.ToString());
        writer.WriteEndElement();

        writer.WriteStartElement("LastName");
        writer.WriteString(LastName?.ToString());
        writer.WriteEndElement();

        writer.WriteStartElement("NickName");
        writer.WriteString(NickName?.ToString());
        writer.WriteEndElement();

        writer.WriteStartElement("Qualification");
        writer.WriteString(Qualification?.ToString());
        writer.WriteEndElement();

        writer.WriteStartElement("Country");
        writer.WriteString(Country?.ToString());
        writer.WriteEndElement();

        writer.WriteStartElement("State");
        writer.WriteString(State?.ToString());
        writer.WriteEndElement();

        writer.WriteStartElement("Town");
        writer.WriteString(Town?.ToString());
        writer.WriteEndElement();

        writer.WriteStartElement("Street");
        writer.WriteString(Street?.ToString());
        writer.WriteEndElement();

        writer.WriteStartElement("Address");
        writer.WriteString(Address?.ToString());
        writer.WriteEndElement();

    }

    public override string ToString()
        {
            return ("Employee Id = "+Id+" First name = "+FirstName+" Last name = "+LastName+
                " Nick name = "+NickName+" Qualification = "+Qualification+" Country = "+Country+" State = "+State+
                " Town = "+Town+" Street "+Street+" Address = "+Address+" Pincode = "+PinCode+" Blood group = "+BloodGroup);
        }

    }
