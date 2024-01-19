using System;
namespace ABC{
    class Program{
        static void Main(string[] args){
            string str=Console.ReadLine();
            string[] words=str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    char firstChar = words[i][0];

                    if (char.IsUpper(firstChar))
                    {
                        words[i] = char.ToUpper(firstChar) + words[i].Substring(1).ToLower();
                    }
                    else if (char.IsLower(firstChar))
                    {
                        words[i] = char.ToLower(firstChar) + words[i].Substring(1).ToUpper();
                    }
                }
            }
            Console.Write( string.Join(" ", words));
        }
    }
}