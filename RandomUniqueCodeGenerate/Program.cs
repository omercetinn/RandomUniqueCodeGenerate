using System;

public class RandomUniqueCodeGenerate
{
    public static void Main(string[] args)
    {
        var enterChars = "ACDEFGHKLMNPRTXYZ234579";
        var stringChars = new char[8]; // chars length
        var random = new Random(); // random value generate

        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = enterChars[random.Next(enterChars.Length)]; // 8 chars random value generate
        }

        var uniqueString = new String(stringChars); 
        Console.WriteLine(uniqueString);
    }
}