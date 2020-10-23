using API.Entities;
using System.Collections.Generic;
using System.Linq;

namespace API.Data
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext context;

        public StudentRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Student student)
        {
            this.context.Add(student);
            this.context.SaveChanges();
        }

        public void Update(Student student)
        {
            this.context.Update(student);
            this.context.SaveChanges();
        }

        public IEnumerable<Student> GetAll()
        {
            return this.context.Students.ToList();
        }

        public Student GetById(int id)
        {
            return this.context.Students.Find(id);
        }

        public void Remove(Student student)
        {
            this.context.Remove(student);
            this.context.SaveChanges();
        }


    }
}
