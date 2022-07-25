using API.DataContext;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ApplicationDbContext _usuariosDbContext;

        public UsuarioController(ApplicationDbContext usuariosDbContext)
        {
            _usuariosDbContext = usuariosDbContext;
        }

        [HttpGet]
        public ActionResult<Usuario> GetProduct(string email, string senha)
        {
            var usuario = _usuariosDbContext.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);
            if(usuario == null)
            {
                return NotFound("usuario não encontrado");
            }
            return Ok(usuario);
        }

        [HttpPost]
        public ActionResult<Usuario> Create([FromBody] Usuario usuario)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

             _usuariosDbContext.Usuarios.Add(usuario);
             _usuariosDbContext.SaveChanges();

            return Ok(usuario);
        }
    }
}
