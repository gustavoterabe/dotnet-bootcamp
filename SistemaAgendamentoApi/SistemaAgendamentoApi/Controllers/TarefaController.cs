using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaAgendamentoApi.Context;
using SistemaAgendamentoApi.Models;
using SistemaAgendamentoApi.ViewModel.Tarefa;

namespace SistemaAgendamentoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
     {
        private readonly SistemaAgendamentoContext _context;
        private readonly IMapper _mapper;

        public TarefaController(SistemaAgendamentoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            Tarefa? tarefa = _context.Tarefas.Find(id);

            if (tarefa == null)
                return NotFound();
            
            return Ok(tarefa);
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos()
        {
            List<Tarefa> tarefas = _context.Tarefas.ToList();
            
            return Ok(tarefas);
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo)
        {
            List<Tarefa> tarefas = _context.Tarefas.Where(t => t.Titulo == titulo).ToList();
            return Ok(tarefas);
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var tarefa = _context.Tarefas.Where(x => x.Data.Date == data.Date);
            return Ok(tarefa);
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusTarefa status)
        {
            var tarefa = _context.Tarefas.Where(x => x.Status == status);
            return Ok(tarefa);
        }

        [HttpPost]
        public IActionResult Criar(CriarTarefaViewModel tarefa)
        {
            Tarefa newTarefa = _context.Tarefas.Add(_mapper.Map<Tarefa>(tarefa)).Entity;
            _context.SaveChanges();

            return CreatedAtAction(nameof(ObterPorId), new { id = newTarefa.Id }, newTarefa);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, EditarTarefaViewModel tarefa)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null)
                return NotFound();

            tarefaBanco.Titulo = tarefa.Titulo ?? tarefaBanco.Titulo;
            tarefaBanco.Descricao = tarefa.Descricao ?? tarefaBanco.Descricao;
            tarefaBanco.Data = tarefa.Data ?? tarefaBanco.Data;
            tarefaBanco.Status = tarefa.Status ?? tarefaBanco.Status;
            
            _context.SaveChanges();
            
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null)
                return NotFound();

            _context.Tarefas.Remove(tarefaBanco);
            _context.SaveChanges();
            
            return NoContent();
        }
    }
}
