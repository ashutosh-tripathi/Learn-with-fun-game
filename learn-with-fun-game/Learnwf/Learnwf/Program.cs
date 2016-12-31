using System;

namespace Learnwf
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Game1 f3 = new Game1())
            {
               
                
                f3.Run();
            }
        }
    }
#endif
}

