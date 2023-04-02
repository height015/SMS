using System;
namespace Creative.Domain
{
	public class CourseObj
	{

        public CourseObj()
        {
            Grade = new HashSet<GradeObj>();
        }
        public int CourseObjId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Unit { get; set; }

        public ICollection<GradeObj> Grade { get; set; }
    }
}

