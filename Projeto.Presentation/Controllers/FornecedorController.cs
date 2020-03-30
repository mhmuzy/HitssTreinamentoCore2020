using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Models;
using Projeto.Domain.Contracts;
using Projeto.Domain.Contracts.Repositories;
using AutoMapper;
using Projeto.Domain.Entities;
namespace Projeto.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        [HttpGet]
        public IActionResult Consulta([FromServices] IFornecedorRepository repository, [FromServices] IMapper mapper)
        {
            
            try
            {
                var lista = mapper.Map<List<FornecedorEntity>>(repository.GetAll());

                return Ok(lista);
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public IActionResult Cadastro(FornecedorCadastroModel model, [FromServices] IFornecedorRepository repository, [FromServices] IMapper mapper)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var forncedor = mapper.Map<FornecedorEntity>(model);
                    repository.Insert(forncedor);

                    return Ok("Fornecedor cadastrado com sucesso!");
                }
                catch (Exception e)
                {

                    return StatusCode(500, e.Message);
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Alterar(FornecedorEdicaoModel model, [FromServices] IFornecedorRepository repository, [FromServices] IMapper mapper)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var fornecedor = mapper.Map<FornecedorEntity>(model);
                    repository.Update(fornecedor);

                    return Ok("Fornecedor cadastrado com sucesso!");
                }
                catch (Exception e)
                {

                    return StatusCode(500, e.Message);
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("Id")]
        public IActionResult Delete(int id, [FromServices] IFornecedorRepository repository)
        {
            try
            {
                var fornecedor = repository.GetById(id);
                repository.Delete(fornecedor);

                return Ok("Fornecedor excluído com sucesso!");
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("Id")]
        public IActionResult ConsultaId(int id, [FromServices] IFornecedorRepository repository, [FromServices] IMapper mapper)
        {
            try
            {
                var model = mapper.Map<FornecedorConsultaModel>(repository.GetById(id));

                return Ok(model);
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }    
        }
    }
}