namespace StudentAPI.Settings
{
    public class StudentDatabaseSettings: IStudentDatabaseSettings
    {
        public string StudentsCollectionName { get; set; }
        public string CoursesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
     
    public interface IStudentDatabaseSettings
    {
        string StudentsCollectionName { get; set; }
        string CoursesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
