using BlazorApp.Pages;
using Bunit;
using Xunit;

namespace MyNameSpace;
public class CounterTest
{
    public void RendersSuccessfully()
    {
        using var ctx = new TestContext();
        Action onBtnClickHandler = () =>
        {
        };
        var component = ctx.RenderComponent<Counter>(parameters => parameters.Add(c => c.DefaultCount, 10).Add(c => c.OnBtnClick, onBtnClickHandler));
        Assert.Equal("Click me", component.Find($".btn").TextContent);
    }
}