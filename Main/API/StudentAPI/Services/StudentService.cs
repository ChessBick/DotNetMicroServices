using MongoDB.Driver;
using StudentAPI.Models;
using StudentAPI.Settings;

namespace StudentAPI.Services
{
    public class StudentService
    {
        private readonly IMongoCollection<Students> _students;
        public StudentService(IStudentDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _students = database.GetCollection<Students>(settings.StudentsCollectionName);
        }
        public async Task<List<Students>> GetAllAsync()
        {
            return await _students.Find(s => true).ToListAsync();
        }
        public async Task<Students> GetByIdAsync(string id)
        {
            return await _students.Find<Students>(s => s.Id == id).FirstOrDefaultAsync();
        }
        public async Task<Students> CreateAsync(Students student)
        {
            await _students.InsertOneAsync(student);
            return student;
        }
        public async Task UpdateAsync(string id, Students student)
        {
            await _students.ReplaceOneAsync(s => s.Id == id, student);
        }
        public async Task DeleteAsync(string id)
        {
            await _students.DeleteOneAsync(s => s.Id == id);
        }
    }
}
