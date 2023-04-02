using System;
namespace Creative.Domain
{
	public class AttendanceObj
	{
        public int AttendanceObjId { get; set; }
        public DateTime AttendanceDate { get; set; }

        public int GradeId { get; set; }
        public GradeObj Grade { get; set; }
    }
}

