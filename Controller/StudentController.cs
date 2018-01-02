using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
namespace Controller
{
    public class StudentController
    {
        Student student;

        public void saveStudent(string startRoll, string endRoll, string batch)
        {
            string disciplineCode = startRoll.Substring(0, 4);

            for (int i = Int32.Parse(startRoll.Substring(4, 2)); i <= Int32.Parse(endRoll.Substring(4, 2)); i++)
            {
                if (i < 10)
                {
                    student = new Student(disciplineCode + "0" + i, "", batch, 0);
                    student.create();
                }
                else
                {
                    student = new Student(disciplineCode + i, "", batch, 0);
                    student.create();
                }
            }
        }
    }
}