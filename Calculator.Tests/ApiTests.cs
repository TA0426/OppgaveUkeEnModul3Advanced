using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http.Json;


namespace Calculator.Tests;

public class ApiTests
{
    [Fact]
    public async Task GetCharacters_ReturnsOk()
    {
        await using var factory =
            new WebApplicationFactory<Program>();

        using var client = factory.CreateClient();

        var response =
            await client.GetAsync("/StoreCharacters");

        Assert.Equal(
            HttpStatusCode.OK,
            response.StatusCode);
    }

    [Fact]
    public async Task PostCharacter_ReturnsCreated()
    {
        await using var factory =
            new WebApplicationFactory<Program>();

        using var client = factory.CreateClient();

        var response = await client.PostAsJsonAsync(
            "/StoreCharacters",
            new
            {
                name = "Anna"
            });

        Assert.Equal(
            HttpStatusCode.Created,
            response.StatusCode);
    }

    [Fact]
    public async Task PostFight_ReturnsOk()
    {
        // Opprett testdata
        // Send POST /Fight
        // Forvent 200 OK
    }
}