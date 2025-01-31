public class Employee
{
    public string name; 
    public string id;
    public string email;
    public double salary;
    public int experience;

    public void Work(){
      // code to perform work
    }
    public double GetSalary(){
      return salary * 1.8;
    }
}