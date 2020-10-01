using System.Collections.Generic;
namespace L02.webapi
{
    public class StudentsRepo
    { public  List<Student> Students;
        public StudentsRepo()
        {
        Students = new List<Student>();
        Students.Add( new Student{ id=1, Nume="Trantea", Prenume="Daniel", anStudiu=4, Facultate="AC" });
        Students.Add( new Student{ id=2, Nume="Speriatu", Prenume="Mihai", anStudiu=3, Facultate="MPT" });
        Students.Add( new Student{ id=3, Nume="Manea", Prenume="Tudor", anStudiu=1, Facultate="ETC" });
        Students.Add( new Student{ id=4, Nume="Jiantu", Prenume="Mircea", anStudiu=1, Facultate="AC" });
        }
    }   

       
}