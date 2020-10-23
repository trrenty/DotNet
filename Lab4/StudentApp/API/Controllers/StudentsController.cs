using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  [Route("api/students")]
  public class StudentsController : ControllerBase
  {
        private readonly IStudentRepository _repository;

        public StudentsController(IStudentRepository repository)
    {
            this._repository = repository;
        }

    [HttpGet]
    public ActionResult<List<Student>> Get() => _repository.GetAll().ToList();

    [HttpGet("{id}")]

    public ActionResult<Student> Get(int id) => _repository.GetById(id);

  }
}