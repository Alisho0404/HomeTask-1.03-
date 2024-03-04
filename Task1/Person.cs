namespace Task1;

public class Person
{
    private string _name; 
    private string _address; 

    public Person(string name, string address)
    {
    _name=name; 
    _address=address;  
    }  

    public string GetName()
    {
        return _name;
    } 

    public string GetAddress()
    {
        return _address;
    }  

    public void SetAddress(string address)
    {
    _address=address;
    } 
        public override string ToString()
        {
            return $"name: {_name} address: {_address}";
        }
}
