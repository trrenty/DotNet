using API.Entities;
using System.Collections.Generic;

namespace API.Data
{
    public interface IStudentRepository
    {
        void Create(Student student);
        IEnumerable<Student> GetAll();
        Student GetById(int id);
        void Remove(Student student);
        void Update(Student student);
    }
}