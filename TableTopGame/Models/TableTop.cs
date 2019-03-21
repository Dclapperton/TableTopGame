using System;
using System.Linq;
using TableTopGame.Helpers;
using TableTopGame.Interfaces;
using TableTopGame.Models;
using static TableTopGame.Helpers.Enums;

namespace TableTopGame
{
    public class TableTop : ITableTop
    {
        const int MaxCommandParts = 2;

        public void Start()
        {
            while (true)
            {
                GetCommand().Execute();
            }
        }

        public ICommand GetCommand()
        {
            string userInput = Console.ReadLine();

            string[] rawInput = userInput.Trim().Split();

            string commandName = rawInput.First().ToUpper();

            ValidCommand validCommand;
            bool isValidCommand = Enum.TryParse<ValidCommand>(commandName, out validCommand);

            if (isValidCommand && rawInput.Length <= MaxCommandParts)
            {
                var objectType = validCommand.GetClassType();

                ICommand command = Activator.CreateInstance(objectType) as ICommand;

                command.Parameters = rawInput.Length > 1 ? rawInput.Last() : string.Empty;

                return command;
            }
            else
            {
                return new Unknown();
            }
        }
    }
}
