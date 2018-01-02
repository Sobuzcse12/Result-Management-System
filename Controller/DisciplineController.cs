using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Controller
{
    public class DisciplineController
    {
        Discipline discipline;
        public Boolean saveDiscipline(string name, string session)
        {
            discipline = new Discipline(name, session);
            return discipline.create();
        }
        public static Discipline getDiscipline()
        {

            return Discipline.getDiscipline();
        }
    }
}
