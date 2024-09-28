using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IDataBase _dataBase;

        public EnrollmentService(IDataBase dataBase)
        {
            _dataBase = dataBase;
        }

        //you can add many methods here
        public List<Enrollment> GetAllEnrollment()
        {
            return _dataBase.getAllEnrollment();
        }
    }

    public interface IEnrollmentService
    {
        List<Enrollment> GetAllEnrollment();
    }
}