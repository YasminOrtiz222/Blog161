using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Otamix1.Models;

namespace Otamix1.Controllers
{
    public class ComentariosController : Controller
    {
        private readonly Otamix1Context _context;

        public ComentariosController(Otamix1Context context)
        {
            _context = context;
        }

        // GET: Comentarios
        public async Task<IActionResult> Index()
        {
            var otamix1Context = _context.Comentario.Include(c => c.Descricao).Include(c => c.Mensagem);
            return View(await otamix1Context.ToListAsync());
        }

        // GET: Comentarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comentario = await _context.Comentario
                .Include(c => c.Descricao)
                .Include(c => c.Mensagem)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comentario == null)
            {
                return NotFound();
            }

            return View(comentario);
        }

        // GET: Comentarios/Create
        public IActionResult Create()
        {
            ViewData["DescricaoId"] = new SelectList(_context.Descricao, "Id", "Id");
            ViewData["MensagemId"] = new SelectList(_context.Mensagem, "Id", "Id");
            return View();
        }

        // POST: Comentarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Titulo,MensagemId,DescricaoId,DataMensagenId,Autor")] Comentario comentario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(comentario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DescricaoId"] = new SelectList(_context.Descricao, "Id", "Id", comentario.DescricaoId);
            ViewData["MensagemId"] = new SelectList(_context.Mensagem, "Id", "Id", comentario.MensagemId);
            return View(comentario);
        }

        // GET: Comentarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comentario = await _context.Comentario.FindAsync(id);
            if (comentario == null)
            {
                return NotFound();
            }
            ViewData["DescricaoId"] = new SelectList(_context.Descricao, "Id", "Id", comentario.DescricaoId);
            ViewData["MensagemId"] = new SelectList(_context.Mensagem, "Id", "Id", comentario.MensagemId);
            return View(comentario);
        }

        // POST: Comentarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Titulo,MensagemId,DescricaoId,DataMensagenId,Autor")] Comentario comentario)
        {
            if (id != comentario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(comentario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComentarioExists(comentario.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DescricaoId"] = new SelectList(_context.Descricao, "Id", "Id", comentario.DescricaoId);
            ViewData["MensagemId"] = new SelectList(_context.Mensagem, "Id", "Id", comentario.MensagemId);
            return View(comentario);
        }

        // GET: Comentarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comentario = await _context.Comentario
                .Include(c => c.Descricao)
                .Include(c => c.Mensagem)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comentario == null)
            {
                return NotFound();
            }

            return View(comentario);
        }

        // POST: Comentarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comentario = await _context.Comentario.FindAsync(id);
            _context.Comentario.Remove(comentario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComentarioExists(int id)
        {
            return _context.Comentario.Any(e => e.Id == id);
        }
    }
}
