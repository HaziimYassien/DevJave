namespace ContosoUniversity_EndSession1_.Models
{
    // this will be considered as an entity or an excel sheet 
    public class Student
    {
        //this will be considered as a column 
        //it will be called as an the manin PK as it's called ID
        public int ID { get; set; }
        //row
        public string LastName { get; set; }
        //row
        public string FirstMidName { get; set; }
        //row
        public DateTime EnrollmentDate { get; set; }


        // this is the navigation properties
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
