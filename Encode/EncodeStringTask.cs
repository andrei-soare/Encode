using System.Text;

namespace Encode;

public class EncodeStringTask
{
    public static string Encode(string input)
    {
        if(string.IsNullOrEmpty(input))
        {
            return "";
        }

        StringBuilder encodedString = new StringBuilder();

        int count = 1;

        for(int i = 1; i < input.Length; i++)
        {
            if (input[i] == input[i - 1])
            {
                count++;
            }
            else
            {
                encodedString.Append(input[i - 1]);
                encodedString.Append(count);
                count = 1;
            }
        }

        encodedString.Append(input[input.Length - 1]);
        encodedString.Append(count);

        return encodedString.ToString();
    }

}
