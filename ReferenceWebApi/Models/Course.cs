namespace ReferenceWebApi.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Fees { get; set;}
        public int NumberOfStudentsEnrolled { get; set; }
    }
}
