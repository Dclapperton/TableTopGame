using System;
using TableTopGame.Interfaces;

namespace TableTopGame.Models
{
    public class Unknown : ICommand
    {
        public string Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Parameters { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Execute()
        {
            Console.WriteLine("Unknown Command");
        }

        public bool IsValid()
        {
            return true;
        }
    }
}
