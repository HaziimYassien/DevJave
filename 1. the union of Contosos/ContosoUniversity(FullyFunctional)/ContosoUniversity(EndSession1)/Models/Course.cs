using System.ComponentModel.DataAnnotations.Schema;


namespace ContosoUniversity_EndSession1_.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        //navigation properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
