using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pim_8.Pages;

namespace pim_8.Controllers
{
	public class UsuariosController : Controller
	{
		private readonly Contexto_context;

		public UsuariosController(Contexto context)
		{
			_context = context;		
		}

		//GET :USER
		public async Task<|ActionResult> Index()
		{
			return View(await _context.usuarios.ToLisAsync());
		}

		//GET : USERDEFAULT/5
		public async Task<|ActionResult> Details(int?id)
		{
			if (id == null)
			{
				return NotFound();
			}	

			var usuario = await _context.UsuariosController
			.FirstOrDefaultAsync(m => m.Id == id);
			if (usuario == null)
			{
				return NotFound();
			}

			return View(usuario);
		}
		public |ActionResult Create()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<|ActionResult> Create([Bind("Id,Name,Cpf,Endereco,Telefone")] Usuario usuario)
		{
			if (ModelState.IsValid)
			{
				_context.Add(usuario);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			return View(usuario);
		}
		public async Task<|ActionResult> Edit(int?id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var usuario = await_context.usuarios.FindAsync(id);
			if (usuario == null)
			{
				return NotFound();
			}
			return View(usuario);			
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<|ActionResult> Edit(int id,[Bind("Id,Name,Cpf,Endereco,Telefone")]Usuario usuario)
		{
			if (id!= usuario.Id)
			{
				return NotFound();
			}	

			if (ModelState.IsValid)
			{
				try
				{
					_context.Update(usuario);
					await_context.SaveChangesAsync();
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!UsuarioExists(usuario.Id))
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
			return View(usuario);
		}
		public async Task<|ActionResult> Delete(int?id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var usuario = await_context.usuarios
			.FirstOrDefaultAsync(m => m.Id == id);
			if (usuario == null)
			{
				return NotFound();
			}

			return View(usuario);
		}
		[HttpPost.ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<|ActionResult> DeleteConfirme(int id)
		{
			var usuario = await_context.usuarios.FindAsync(id);
			_context.usuarios.Remove(usuario);
			await_context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private bool UsuarioExists(int id)
		{
			
		}
	}
}