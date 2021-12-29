using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ProgCont//создаем два события
    {
        public event EventHandler Mutation;
        public event EventHandler Del;
        public void contr()
        {
            Console.WriteLine("Cotnroller started: ");
            if (Mutation != null)
                Mutation(this, null);
            Del?.Invoke(this, null);
        }
    }
}