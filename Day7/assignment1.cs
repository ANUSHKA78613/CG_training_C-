using System;
class Assign
{
 public string CleanseAndInvert(string input)
    {
        // Rule 1: null or length check
        if (string.IsNullOrEmpty(input) || input.Length < 6)
            return "";

        // Rule 2: only alphabets allowed
        for (int i = 0; i < input.Length; i++)
        {
            if (!char.IsLetter(input[i]))
                return "";
        }

        // Step 1: convert to lowercase
        input = input.ToLower();

        // Step 2: remove characters with even ASCII values
        char[] temp = new char[input.Length];
        int count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (((int)input[i]) % 2 != 0)
            {
                temp[count] = input[i];
                count++;
            }
        }

        // Step 3: reverse
        char[] result = new char[count];
        for (int i = 0; i < count; i++)
        {
            result[i] = temp[count - 1 - i];
        }

        // Step 4: uppercase even index characters
        for (int i = 0; i < result.Length; i++)
        {
            if (i % 2 == 0)
                result[i] = char.ToUpper(result[i]);
        }

        return new string(result);
    }
}