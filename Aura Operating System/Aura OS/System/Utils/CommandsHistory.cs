﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aura_OS.System.Utils
{
    class CommandsHistory
    {
        public static void Add(string cmd)
        {
            Cosmos.System.Console.commands.Add(cmd);
            Cosmos.System.Console.commandindex++;
        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        public static void GetNewestCommand() //DOWN ARROW
        {

        }

        public static void GetOlderCommand() //UP ARROW
        {

        }

    }
}