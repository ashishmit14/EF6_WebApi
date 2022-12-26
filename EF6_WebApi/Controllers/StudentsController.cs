using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using EF6_WebApi;
using EF6_WebApi.Data;
using EF6_WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF6_WebApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class StudentsController : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        private SchoolDBContext db;

        public StudentsController(SchoolDBContext dBContext)
        {
            db = dBContext;
            //db.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/Students

        [Route("api/Students")]
        public List<Student> GetStudent()
        {
            return db.Students.ToList<Student>();
        }

        // GET: api/Students/5
        [HttpGet]
        [Route("api/Students/{id}")]
        public IActionResult GetStudent(int id)
        {
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        // PUT: api/Students/5
        //[ResponseType(typeof(void))]
        [HttpPut]
        [Route("api/Students/{id}")]
        public IActionResult PutStudent(int id, Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != student.StudentId)
            {
                return BadRequest();
            }

            db.Entry(student).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Students
        //[ResponseType(typeof(Student))]
        [HttpPost]
        [Route("api/Students")]
        public IActionResult PostStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Students.Add(student);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = student.StudentId }, student);
        }

        // DELETE: api/Students/5
        //[ResponseType(typeof(Student))]
        [HttpDelete]
        [Route("api/Students/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            db.Students.Remove(student);
            db.SaveChanges();

            return Ok(student);
        }

        private bool StudentExists(int id)
        {
            return db.Students.Count(e => e.StudentId == id) > 0;
        }
    }
}