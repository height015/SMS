using System;
namespace Creative.Domain;

	public class ParentsObj : AppUserObj{

    public ParentsObj()
    {
        Students = new HashSet<StudentsObj>();
    }
   
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string PhoneMobile { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Address { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime LastLogin { get; set; }
    public DateTime JoinDate { get; set; }
    public string LastLoginIp { get; set; }

    public ICollection<StudentsObj> Students { get; set; }
}

