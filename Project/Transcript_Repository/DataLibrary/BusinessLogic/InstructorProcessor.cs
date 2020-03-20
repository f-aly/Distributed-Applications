using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public class InstructorProcessor
    {
        public static int CreateInstructor(int instructorId, string instructorFirstName,
               string instructorLastName, string instructorEmail)
        {
            InstructorModel data = new InstructorModel
            {
                InstructorId = instructorId,
                InstructorFirstName = instructorFirstName,
                InstructorLastName = instructorLastName,
                InstructorEmail = instructorEmail
            };

            // @ tells it it's a variable.  it's the data you're paassign with the statment. 
            // e.g @ModuleId's value is going to be stored in moduleId
            string sql = @"insert into dbo.Instructor (InstructorId, InstructorFirstName, InstructorLastName, InstructorEmail)
                            values (@InstructorId, @InstructorFirstName, @InstructorLastName, @InstructorEmail);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<InstructorModel> LoadInstructors()
        {
            string sql = @"select Id, InstructorId, InstructorFirstName, InstructorLastName, InstructorEmail
                            from dbo.Instructor;";

            return SqlDataAccess.LoadData<InstructorModel>(sql);
        }
    }
}
