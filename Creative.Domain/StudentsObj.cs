using System;
namespace Creative.Domain;

	public class StudentsObj : AppUserObj{

    public StudentsObj()
    {
        Grades = new HashSet<GradeObj>();

    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string StateOfOrigin { get; set; }
    public string Address { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime LastLogin { get; set; }
    public DateTime JoinDate { get; set; }
    public int CreatedBy { get; set; }

    public int ParentId { get; set; }
    public ParentsObj ParentsObj { get; set; }

    public ICollection<GradeObj> Grades { get; set; }

}

