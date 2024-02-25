namespace ContosoUniversity_EndSession1_.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }


        // properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
