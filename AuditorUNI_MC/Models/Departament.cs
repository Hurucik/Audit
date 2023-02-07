namespace Kursovaya_rabota.Model
{
    class Departament
    {
        public string Name { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Student> Students { get; set; }
    }


}