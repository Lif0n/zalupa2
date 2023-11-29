namespace zalupApi.Models
{
    public class Course
    {
        public int Id { get; set; }

        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
        public string Name { get; set; }
        public string Shortname { get; set; }
    }
}
