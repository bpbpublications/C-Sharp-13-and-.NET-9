using BlazorApp.Pages;
using Bunit;
using Xunit;

namespace MyNameSpace;
public class CounterTest
{
    [Fact]
    public void RendersSuccessfully()
    {
        using var ctx = new TestContext();
        var component = ctx.RenderComponent<Counter>();
        Assert.Equal("Click me", component.Find($".btn").TextContent);
    }
}