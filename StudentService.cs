using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StudentService : IStudentService
    {
        private readonly IDataBase _database;

        public StudentService(IDataBase database)
        {
            _database = database;
        }

        //you can add many methods here
        public Student GetStudent(short id)
        {
            return _database.getAllStudents().SingleOrDefault(x => x.Id == id)!;
        }
    }
}