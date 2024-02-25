﻿namespace ContosoUniversity_EndSession1_.Models
{

    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID
        {
            get; set;
        }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        //navigation properties
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
