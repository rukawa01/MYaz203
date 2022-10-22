


EmployeeManager employeeManager = new EmployeeManager()
{
    
};

string[] names = new string[]
{
    "ahmet ağ",
    "mehmet bağ",
    "yasemin cağ"
};
static String Algo1(string input)
{
    var temp = input.Split(' ');
    return temp[0] + " "+ temp[1][0] + ".";
}

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(Algo1(names[i]));
}


// override yazdığımız için böyle tanımlaya gerek yok aslında
Employee employee = new Employee()
{

    FirstName = "sdfs",
    Age = 12,
    LastName = "ne bilim",
    Id = 1
};

int x = 5;




// id ı de overloada alırsam paratnez içi tanımlayabilirim
Employee employee1 = new Employee(

    "ahmet", "yılmaz", 23,2)
{anlama = "anla diye açılan prop"};





Employee employee2 = new Employee("ömer", "güven", 20, 3) { anlama = "dsfds"};
Employee employee4 = new Employee("ömer", "aaaa", 20, 4);
Employee employee3 = new Employee("ömer", "aaaaa", 23, 5);
Employee employee5 = new Employee("ömer", "asas", 242, 6);
Employee employee10 = new Employee("ceto", "erdemli", 20, 8);


employeeManager.Add(employee2);
employeeManager.Add(employee3);
employeeManager.Add(employee5);
employeeManager.Add(employee4);
employeeManager.Add(employee10);



employeeManager.Remove(6);
//list.RemoveAt(0);

int number = 0;
int numId = 0;
foreach (var i in employeeManager.list)
{
    
    if (number < i.Age)
    {
        number = i.Age;
        numId = i.Id;
    }
    Console.WriteLine(i);
    
}
foreach (Employee i in employeeManager.list)
{
    if (numId == i.Id)
    {
        Console.Write(i); Console.Write($" this is the biggest age : {number} \n"); ;
    }
}

Console.WriteLine("**************************");

foreach (var i in employeeManager.SortedList())
{
    Console.WriteLine(i);
}
//Console.WriteLine(employee);

// override yaptığımız için özellikle belirtmeden sadece objeyi (employee veya employee1) yazarakda yazdırabiliriz.
//Console.WriteLine(employee.LastName);
//Console.WriteLine(employee1.FirstName + employee1.Id);
Console.WriteLine("-----------------------------");


Employee employee30 = new Employee("ibo", "gümüs", 21, 6);
Employee[] emp = new Employee[] { employee, employee1 , employee30};



List<Employee> arr = new List<Employee>();



arr.AddRange(emp.OrderBy(i => i.Id));

foreach (var i in arr)
{
    Console.WriteLine(i);
}

