namespace Kursovaya_rabota.Model
{
    class Professor
    {
        public string Name { get; private set; }
        public Departament Departament { get; set; }
        public List<AcademicSubject> AcademicSubjects { get; set; }
    }


}