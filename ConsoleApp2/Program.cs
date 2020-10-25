using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            int alts=-10;
            int usss=10;
            int d=5;
            int ssize=10;
            Random r = new Random();
            

            double[][] swarm = new double[ssize][];
            for(int i=0;i<ssize;i++)
            {
                swarm[i] = new double[5];
                for(int j=0;j<d;j++)
                {
                    swarm[i][j] = -1 + r.NextDouble() * 10;
                }
            }

            double[] obj = new double[ssize];
            for (int i = 0; i < ssize; i++)
            {
                obj[i] = 0;

            }
             for(int i=0;i<ssize;i++)
            {
                for(int j=0;j<d;j++)
                {
                    obj[i] += (int)Math.Pow(swarm[i][j],2);
                }
            }
            double[][] velocity = new double[ssize][];
             for(int i =0;i<ssize;i++)
            {
                velocity[i] = new double[5]; 
                for(int j=0;j<d;j++)
                {
                    velocity[i][j] = 0;
                }
            }

            double[][] pbestpos = new double[ssize][];
            pbestpos = swarm;
            double[] pbesval = new double[ssize];
            pbesval = obj;

         for(int i=0;i<ssize;i++)
            {
                for(int j=0;j<d;j++)
                {
                    Console.WriteLine(" "+swarm[i][j]);
                }
            }
        }
        }
    }

