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
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Consulta([FromServices] IProdutoRepository repository, [FromServices] IMapper mapper)
        {
            try
            {
                var lista = mapper.Map<List<ProdutoEntity>>(repository.GetAll());

                return Ok(lista);
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        //[HttpPost]
        //public IActionResult Cadastro(TesteModel model, [FromServices] IProdutoRepository repository, [FromServices] IMapper mapper)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            var produto = mapper.Map<FornecedorEntity>(model);
        //            repository.Insert(funcionario);

        //            return Ok("Deu Certo!");
        //        }
        //        catch (Exception e)
        //        {

        //            return StatusCode(500, e.Message);
        //        }
        //    }
        //    else
        //    {
        //        return BadRequest();
        //    }
        //}

        //[HttpPut]
        //public IActionResult Alterar(TesteModel model, [FromServices] IProdutoRepository repository, [FromServices] IMapper mapper)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            var funcionario = mapper.Map<FornecedorEntity>(model);
        //            repository.Update(funcionario);

        //            return Ok("Deu Certo!");
        //        }
        //        catch (Exception e)
        //        {

        //            return StatusCode(500, e.Message);
        //        }
        //    }
        //    else
        //    {
        //        return BadRequest();
        //    }
        //}

        [HttpDelete("Id")]
        public IActionResult Delete(int id, [FromServices] IProdutoRepository repository)
        {
            try
            {
                var funcionario = repository.GetById(id);
                repository.Delete(funcionario);

                return Ok("");
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        //    [HttpGet("Id")]
        //    public IActionResult ConsultaId(int id, [FromServices] IProdutoRepository repository, [FromServices] IMapper mapper)
        //    {
        //        try
        //        {
        //            var model = mapper.Map<TesteModel>(repository.GetById(id));

        //            return Ok(model);
        //        }
        //        catch (Exception e)
        //        {

        //            return StatusCode(500, e.Message);
        //        }    
        //    }
    }
}