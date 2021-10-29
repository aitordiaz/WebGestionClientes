using Microsoft.EntityFrameworkCore;
using WebGestionClientes.Models;

namespace WebGestionClientes.Data
{
    /// <summary>
    /// Clase de contexto de la base de datos. Esta clase permite generar un objeto de contexto 
    /// que representa una sesión con la base de datos
    /// </summary>
    public class WebGestionClientesContext : DbContext
    {
        public WebGestionClientesContext (DbContextOptions<WebGestionClientesContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}
