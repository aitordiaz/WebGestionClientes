using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using System.Threading.Tasks;
using WebGestionClientes.Controllers;
using Xunit;
using FluentAssertions;
using WebGestionClientes.Models;
using WebGestionClientes.Data;
using Microsoft.EntityFrameworkCore;

namespace WebGestionClientes.Tests.UnitTests
{
    public class ClientesControllerTests
    {
        [Fact]
        public async Task Details_Returns_NotFound_When_Id_Is_Null()
        {
            // Arrange
            var controller = new ClientesController(context: null);
            // Act
            var result = await controller.Details(id: null);
            // Assert
            result.Should().BeOfType<NotFoundResult>();
        }

        private List<Cliente> GetTestClients()
        {
            var clientes = new List<Cliente>();
            clientes.Add(new Cliente()
            {
                Dni = "55000111P",
                Nombre = "Juan",
                Apellidos = "Pérez Casa",
                Email = "jpc@email.com",
                Telefono = 600100200,
                PaisRes = "España",
                FehcaNac = DateTime.Parse("2000-2-12"),
            });
            clientes.Add(new Cliente()
            {
                Dni = "4075021P",
                Nombre = "Andrea",
                Apellidos = "Marquez Ramirez",
                Email = "andrea@email.com",
                Telefono = 615202100,
                PaisRes = "España",
                FehcaNac = DateTime.Parse("1980-2-25"),
            });
            return clientes;
        }
    }
}
