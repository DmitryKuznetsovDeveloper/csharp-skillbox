using System.Xml.Linq;
using System.Xml.Serialization;

namespace PracticalWork008;

public class MyXml
{
    public void SerializeContact(Contact contact, string path)
    {
        XElement person = new XElement("Person");
        XElement address = new XElement("Address");
        XElement phones = new XElement("Phones");

        XAttribute xAttributeFullName = new XAttribute("Fullname", contact.FullName);
        XAttribute xAttributeStreet = new XAttribute("Street", contact.Street);
        XAttribute xAttributeHouseNumber = new XAttribute("HouseNumber", contact.HouseNumber);
        XAttribute xAttributeFlatNumber = new XAttribute("FlatNumber", contact.ApartmentNumber);
        XAttribute xAttributeMobilePhone = new XAttribute("MobilePhone", contact.MobilePhone);
        XAttribute xAttributeFlatPhone = new XAttribute("FlatPhone", contact.HomePhone);
        
        person.Add(address,phones);
        person.Add(xAttributeFullName);
        address.Add($"\n\t{xAttributeStreet}\n\t{xAttributeHouseNumber}\n\t{xAttributeFlatNumber}");
        phones.Add($"\n\t{xAttributeMobilePhone}\n\t{xAttributeFlatPhone}");
        person.Save(path);
        
    }
}