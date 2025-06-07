using System.Text;

string result = "";
// Not optimized
for (int i = 0; i < 10000; i++)
{
    result += i.ToString();
}

result = "";
// Optimized with StringBuilder
StringBuilder sb = new StringBuilder();
for (int i = 0; i < 10000; i++)
{
    sb.Append(i);
}

result = sb.ToString();