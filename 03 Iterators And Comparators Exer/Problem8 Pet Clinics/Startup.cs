﻿using Problem8_Pet_Clinics.Core;

namespace Problem8_Pet_Clinics
{
    internal class Startup
    {
        private static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}