using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WebAppConnect.Models;

public class Employee
{
    public Employee()
    {
        
    }
    public int ID { get; set; }
    
    [Display(Name = "Surname")]
    public string Surname { get; set; }
    
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    public Gender Gender { get; set; }
    
    [Display(Name = "Date of Birth")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
    public DateTime DOB { get; set; }

    [Display(Name = "Job Title")] public string JobRole { get; set; } = "Accounting Officer 1";

    public Department Department { get; set; }
    
    public string FullName => Surname + " " + FirstName;
    public int Age => (DateTime.Today.Subtract(DOB.Date)).Days;
}

public enum Department
{
    Account,Sales,Admin
}
public enum Gender
{
    Male,Female
}