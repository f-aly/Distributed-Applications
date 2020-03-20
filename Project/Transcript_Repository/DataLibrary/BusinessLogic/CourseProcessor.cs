using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class CourseProcessor
    {
        public static int CreateCourse(int courseId, string courseName, 
            string courseQualification, int courseResult, int courseLength)
        {
            CourseModel data = new CourseModel
            {
                CourseId = courseId,
                CourseName = courseName,
                CourseQualification = courseQualification,
                CourseResult = courseResult,
                CourseLength = courseLength
            };

            string sql = @"insert into dbo.Course (CourseId, CourseName, CourseQualification, CourseResult, CourseLength)
                            values (@CourseId, @CourseName, @CourseQualification, @CourseResult, @CourseLength);"; 

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<CourseModel> LoadCourses()
        {
            string sql = @"select Id, CourseId, CourseName, CourseQualification, CourseResult, CourseLength
                            from dbo.Course;";
            return SqlDataAccess.LoadData<CourseModel>(sql);
        }
    }
}
