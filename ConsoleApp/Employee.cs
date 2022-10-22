


public class Employee
{
    private string _firstName;
    private string lastName;

    public int Id { get; set; }
    
    public int Age { get; set; }
    public string FirstName { get => _firstName; set => _firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public string anlama { get; set; }
    // zaten constructer var biz yapısını kontrol etmek için açıyoruz
    public Employee()
    {
        Console.WriteLine("selam");
    }

    // overload
    public Employee( string FirstName , string LastName, int Age , int Id)
    {
       
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.Age = Age;
        this.Id = Id;
    }

    // override etme geçersiz kılma
    public override string? ToString()
    {
        return $"{FirstName, -20} {lastName,-15} {Age,5}  {Id , 5}";
    }

    // Listeyi oluştur sonra yazdır add fonksiyonu yap

}

