
public class EmployeeManager{

   public List<Employee> list = new List<Employee>()
{
    
};
     public void Add(Employee emplo)
    {
        list.Add(emplo);

    }

   public void Remove(int id)
    {
        var employee = list.FirstOrDefault(e => e.Id == id);
        if (employee == null)
        {
            throw new Exception("this employee couldn't found");
        }
        list.Remove(employee);
    }
    public List<Employee> SortedList()
    {
        var listSorted = list.OrderBy(i => i.Id);
        return listSorted.ToList();
    }
}

