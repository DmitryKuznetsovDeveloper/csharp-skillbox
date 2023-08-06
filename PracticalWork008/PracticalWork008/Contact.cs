namespace PracticalWork008;

public class Contact
{
    public string FullName { get; set; }
    public string Street { get; set; }
    public int HouseNumber { get; set; }
    public int ApartmentNumber { get; set; }
    public string MobilePhone { get; set; }
    public string HomePhone { get; set; }
    
    public Contact(){}
    public Contact(string fullName, string street, int houseNumber, int apartmentNumber, string mobilePhone, string homePhone)
    {
        FullName = fullName;
        Street = street;
        HouseNumber = houseNumber;
        ApartmentNumber = apartmentNumber;
        MobilePhone = mobilePhone;
        HomePhone = homePhone;
    }
}