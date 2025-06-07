using System;
using BlazorApp.Data;
using BlazorApp.Pages;
using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace MyNameSpace;
public class FetchDataTest
{
    [Fact]
    public void RendersSuccessfully()
    {
        using var ctx = new TestContext();
        ctx.Services.AddSingleton<WeatherForecastService>(new WeatherForecastService());
        // Render Counter component.
        var component = ctx.RenderComponent<FetchData>();
        Assert.Equal("Weather forecast", component.Find($"h1").TextContent);
    }
}