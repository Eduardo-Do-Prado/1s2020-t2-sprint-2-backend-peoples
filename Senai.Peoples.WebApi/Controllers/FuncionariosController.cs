using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Peoples.WebApi.Repositories;
using Senai.Peoples.WebApi.Domains;

namespace Senai.Peoples.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        private FuncionarioRepository _funcionarioRespository { get; set; }

        public FuncionariosController()
        {
            _funcionarioRespository = new FuncionarioRepository();
        }

        [HttpGet]
        public IEnumerable<FuncionarioDomain> Get()
        {
            return _funcionarioRespository.Listar();
        }

        [HttpPost]
        public IActionResult Post(FuncionarioDomain novofuncionario)
        {
            _funcionarioRespository.Cadastrar(novofuncionario);
            return StatusCode(201);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int id)
        {
            FuncionarioDomain FuncionarioBuscado = _funcionarioRespository.BuscarPorId(id);

            if (FuncionarioBuscado == null)
            {
                return NotFound("Funcionário não encontrado");
            }
            return Ok(FuncionarioBuscado);
        }
        [HttpDelete("{Id}")]
        public IActionResult Delete(int id)
        {
            _funcionarioRespository.Deletar(id);

            return Ok("Funcionário excluído");
        }
        [HttpPut("{Id}")]
        public IActionResult PutIdUrl(int id, FuncionarioDomain funcionario)
        {
            FuncionarioDomain FuncionarioBuscado = _funcionarioRespository.BuscarPorId(id);
            try
            {
                _funcionarioRespository.AtualizarIdUrl(id, funcionario);

                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}