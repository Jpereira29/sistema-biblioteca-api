using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using SistemaBibliotecaAPI.Context;
using SistemaBibliotecaAPI.Models;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace SistemaBiblioteca.Tests
{
    public class BibliotecaApiIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly WebApplicationFactory<Program> _factory;

        public BibliotecaApiIntegrationTests(WebApplicationFactory<Program> factory)
        {
            _factory = factory.WithWebHostBuilder(builder => { });

            using var scope = _factory.Services.CreateScope();
            var scopedServices = scope.ServiceProvider;
            var db = scopedServices.GetRequiredService<AppDbContext>();
            db.Database.EnsureCreated();
        }

        // Método auxiliar para criar um cliente já autenticado
        private async Task<HttpClient> CreateAuthenticatedClientAsync()
        {
            var client = _factory.CreateClient();
            // 1. Garante que o usuário de teste existe
            var data = new { UserName = "testuser", PasswordHash = "Test@123" };
            await client.PostAsJsonAsync("/api/Auth/register", data);

            // 2. Faz o login para obter o token
            var response = await client.PostAsJsonAsync("/api/Auth/login", data);
            response.EnsureSuccessStatusCode();
            var result = await response.Content.ReadFromJsonAsync<TokenResponse>();
            var token = result?.Token ?? string.Empty;

            // 3. Adiciona o token como padrão para todas as futuras requisições deste cliente
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            return client;
        }

        [Fact]
        public async Task GetLivros_WithoutToken_ShouldReturnUnauthorized()
        {
            // Arrange
            var client = _factory.CreateClient();
            // Act
            var response = await client.GetAsync("/api/Livro");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        }

        [Fact]
        public async Task GetLivros_WithToken_ShouldReturnOk()
        {
            // Arrange
            var client = await CreateAuthenticatedClientAsync(); // Cliente autenticado!

            // Act
            var response = await client.GetAsync("/api/Livro");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task PostAutor_WithValidData_ShouldReturnCreated()
        {
            // Arrange
            var client = await CreateAuthenticatedClientAsync();
            var newAuthor = new Autor
            {
                Nome = "Jorge Amado"
            };

            // Act
            var response = await client.PostAsJsonAsync("/api/Autor", newAuthor);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.Created);
        }

        [Fact]
        public async Task PostLivro_WithoutTitle_ShouldReturnBadRequest()
        {
            // Arrange
            var client = await CreateAuthenticatedClientAsync();
            // O payload anônimo não inclui 'titulo', que deve ser obrigatório
            var invalidBook = new Livro
            {
                Categoria = "Romance",
                AnoPublicacao = "1985"
            };

            // Act
            var response = await client.PostAsJsonAsync("/api/Livro", invalidBook);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task DeleteAutor_WithNonExistentId_ShouldReturnNotFound()
        {
            // Arrange
            var client = await CreateAuthenticatedClientAsync();
            var nonExistentId = 9999;

            // Act
            var response = await client.DeleteAsync($"/api/Autor/{nonExistentId}");

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }
    }
}
