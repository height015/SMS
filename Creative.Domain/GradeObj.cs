using System;
using System.Reflection.Metadata;

namespace Creative.Domain;

	public class GradeObj
	{

	public GradeObj()
	{
		Attendances = new HashSet<AttendanceObj>();

    }

	public int GradeObjId { get; set; }
	public int Score { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public int CourseId { get; set; }
	public CourseObj Course { get; set; }
	public int StudentId { get; set; }
	public StudentsObj Students { get; set; }
	public ICollection<AttendanceObj> Attendances { get; set; }
}

