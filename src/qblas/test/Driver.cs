﻿using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;
using Microsoft.Quantum.Primitive;
namespace Quantum.test
{
    class Driver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start test!");
            using (var sim = new QuantumSimulator())
            {
                // sim.OnLog += (msg) => { Console.WriteLine(msg); };
                for(int i = 0; i < 1; i++)
                {
                    // var res = test_vector_prepare.Run(sim, i);
                    var res = test_1_sparse_integer.Run(sim,1);
                    Console.WriteLine("Result= "+res.Result);
                }
            }

            Console.WriteLine("hello qsharp!");
        }
    }
}