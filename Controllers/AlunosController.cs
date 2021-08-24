using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using api_desafio21dias.Models;
using api_desafio21dias.Servicos;
using EntityFrameworkPaginateCore;

namespace api_desafio21dias.Controllers
{
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private readonly DbContexto _context;
        private const int QUANTIDADE_POR_PAGINA = 3;

        public AlunosController(DbContexto context)
        {
            _context = context;
        }

        // GET: /alunos
        [HttpGet]
        [Route("/alunos")]
        public async Task<IActionResult> Index(int page = 1)
        {
            return StatusCode(200, await _context.Alunos.OrderBy(a => a.Id).PaginateAsync(page, QUANTIDADE_POR_PAGINA));
            //return StatusCode(200, await _context.Alunos.OrderByDescending(a => a.Id).PaginateAsync(page, QUANTIDADE_POR_PAGINA));
        }

        // GET: /alunos/5
        [HttpGet]
        [Route("/alunos/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = await _context.Alunos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }

            return StatusCode(200, aluno);
        }

        // POST: /alunos
        [HttpPost]
        [Route("/alunos")]
        public async Task<IActionResult> Create([Bind("Id,Nome,Matricula,Notas")] Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aluno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return StatusCode(201, aluno);
        }

        // PUT: /alunos/5
        [HttpPut]
        [Route("/alunos/{id}")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Matricula,Notas")] Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    aluno.Id = id;
                    _context.Update(aluno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlunoExists(aluno.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return StatusCode(200, aluno);
            }
            return StatusCode(200, aluno);
        }

        // DELETE: /alunos/5
        [HttpDelete]
        [Route("/alunos/{id}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            _context.Alunos.Remove(aluno);
            await _context.SaveChangesAsync();
            return StatusCode(204);
        }

        private bool AlunoExists(int id)
        {
            return _context.Alunos.Any(e => e.Id == id);
        }
    }
}
