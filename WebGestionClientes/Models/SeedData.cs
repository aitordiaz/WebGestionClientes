using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using WebGestionClientes.Data;

namespace WebGestionClientes.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebGestionClientesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebGestionClientesContext>>()))
            {
                // Buscar algún cliente en la base de datos
                if (context.Cliente.Any())
                {
                    return;   // DB has been seeded
                }

                context.Cliente.AddRange(
                    new Cliente
                    {
                        Dni = "55000111P",
                        Nombre = "Juan",
                        Apellidos = "Pérez Casa",
                        Email = "jpc@email.com",
                        Telefono = 600100200,
                        PaisRes = "España",
                        FehcaNac = DateTime.Parse("2000-2-12"),
                    },

                    new Cliente
                    {
                        Dni = "55700141H",
                        Nombre = "Alberto",
                        Apellidos = "Alberto Alberto",
                        Email = "alberto@email.com",
                        Telefono = 611100290,
                        PaisRes = "España",
                        FehcaNac = DateTime.Parse("1995-3-12"),
                    },

                    new Cliente
                    {
                        Dni = "1075021P",
                        Nombre = "Andrea",
                        Apellidos = "Marquez Ramirez",
                        Email = "andrea@email.com",
                        Telefono = 615202100,
                        PaisRes = "España",
                        FehcaNac = DateTime.Parse("1980-2-25"),
                    },

                    new Cliente
                    {
                        Dni = "51047205V",
                        Nombre = "Juan",
                        Apellidos = "Ribera Sánchez",
                        Email = "juan@email.com",
                        Telefono = 678514201,
                        PaisRes = "Portugal",
                        FehcaNac = DateTime.Parse("1970-2-12"),
                    }
                );
                context.SaveChanges();
            }
        }
    }
}