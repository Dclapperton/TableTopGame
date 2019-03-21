using System;
using System.Collections.Generic;
using TableTopGame.Models;
using TableTopGame.Models.Commands;
using static TableTopGame.Helpers.Enums;

namespace TableTopGame.Helpers
{
    public static class ValidCommandHelpers
    {
        public static Type GetClassType(this ValidCommand command)
        {
            return CommandClassMap[command];
        }

        static Dictionary<ValidCommand, Type> CommandClassMap = new Dictionary<ValidCommand, Type>()
        {
            {ValidCommand.RIGHT,typeof(Right)},
            {ValidCommand.LEFT,typeof(Left)},
            {ValidCommand.PLACE,typeof(Place)},
            {ValidCommand.MOVE,typeof(Move)},
            {ValidCommand.REPORT,typeof(Report)}
        };
    }
}
