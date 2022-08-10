using SuperTags;

namespace SuperTagsApp
{
    class SuperTags
    {
        static Expansion _expansion = new Expansion();
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                Console.WriteLine(_expansion.Nested(args[0], args[1]));
            } 
            else if (args.Length == 1)
            {
                Console.WriteLine(_expansion.Nested(args[0], ""));
            } 
            else
            {
                Console.WriteLine("SuperTagsApp <pattern> <value>");
            }
        }
    }
}
