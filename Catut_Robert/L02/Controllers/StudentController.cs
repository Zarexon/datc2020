using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace L02.webapi.Controllers
{
    [ApiController]
    [Route( "[controller]" )]
    public class StudentsController : ControllerBase
    {
        StudentsRepo students = new StudentsRepo();
        
        private ILogger<StudentsController> _logger;
        public StudentsController( ILogger<StudentsController> logger )
        {
            _logger = logger;        
        }

        [HttpGet]
        public List<Student> Get()
        {
            return students.Students;
        }

        [HttpGet( "{Id}" )]
        public Student Get( int Id )
        {
            foreach ( Student student in students.Students )
            {
                if( student.id == Id )
                {
                    return student;
                }
            }
            return null;
        }
        
        [HttpPost]
        public List<Student> Post( [FromBody] Student student)
        {
            students.Students.Add(student) ;
            return students.Students;
        }
    
       [HttpDelete( "{Id}" )]
       public List<Student> Delete(int Id)
        {
           foreach( Student student in students.Students )
           {
               if( student.id == Id )
               {
                   students.Students.Remove(student);
                   return students.Students;
               }
           }
           return null;
        }

       [HttpPut( "{Id}" )]
       public Student Update( int Id, [FromBody] Student studentUpdate )
       {
           foreach( Student student in students.Students )
           {
               if( student.id == Id )
               {
                   student.Nume=studentUpdate.Nume;
                   student.Prenume=studentUpdate.Prenume;
                   student.Facultate=studentUpdate.Facultate;
                   student.anStudiu=studentUpdate.anStudiu;
                   return student;
               }
           }
           return null;          
       }
    }    
}