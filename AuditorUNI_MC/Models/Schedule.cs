namespace Kursovaya_rabota.Model
{
    class Schedule
    {
        DateTime Date;
        public AcademicSubject AcademicSubject { get; set; }
        public List<Student> Students { get; set; }
        public List<Professor> Professors { get; set; }
    }


}