using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

[HtmlTargetElement("grid")]
public class GridTagHelper : TagHelper
{
    public IEnumerable<dynamic> Items { get; set; }
    public string CssClass { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "div"; // Replacing <grid> with <div>
        output.Attributes.SetAttribute("class", CssClass);
        var content = new StringBuilder();
        content.Append("<table>");
        // Assuming each item in Items is an object with properties
        foreach (var item in Items)
        {
            content.Append("<tr>");
            foreach (var prop in item.GetType().GetProperties())
            {
                content.Append($"<td>{prop.GetValue(item)}</td>");
            }

            content.Append("</tr>");
        }

        content.Append("</table>");
        output.Content.SetHtmlContent(content.ToString());
    }
}