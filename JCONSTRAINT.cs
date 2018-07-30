using System;
using System.Collections.Generic;
namespace Journal
{
    class Journal
    {
        void Out(char x) { Console.Write(x); }
        void OutLine() { Console.WriteLine(); }

        ConsoleKey[] KeyPositions = {
            ConsoleKey.D2,ConsoleKey.D3,
            ConsoleKey.Tab,ConsoleKey.Q,ConsoleKey.W,ConsoleKey.E,ConsoleKey.R,ConsoleKey.T,ConsoleKey.I,ConsoleKey.O,ConsoleKey.P,ConsoleKey.Oem4,ConsoleKey.Oem6,
            ConsoleKey.A,ConsoleKey.S,ConsoleKey.D,ConsoleKey.F,ConsoleKey.G,ConsoleKey.J,ConsoleKey.K,ConsoleKey.L,ConsoleKey.Oem1,ConsoleKey.Oem7,
            ConsoleKey.V,ConsoleKey.M,ConsoleKey.OemComma,ConsoleKey.OemPeriod,ConsoleKey.Oem2,
            ConsoleKey.Spacebar,ConsoleKey.Backspace
        };
        Char[] MainKeyList = {
                     '(', ')',
            '"', 'L', 'I', 'N', 'G', 'P',        '.', 'M', 'W', 'V', '\'',
                  'O', 'U', 'S', 'D', 'C',   ',', 'E', 'H', 'T', 'R',
                                  'Y',        'A', 'F', 'B', 'K',
            ' ', '♣'
        };
        Char[] AltKeyList = { // = < > ~ % × ÷
                     '♦', '♥',
            '♠', '•', 'Z', '&', '#', '=',        '!', '5', '4', '3', '8',
                  'J', 'Q', '9', '-', '+',   '/', 'X', '?', '2', '1',
                                  '$',        ':', ';', '7', '6',
            '@', '@'
        };
        private readonly Dictionary<ConsoleKey,char> MainKeys = new Dictionary<ConsoleKey,char>();
        private readonly Dictionary<ConsoleKey,char> ShiftKeys = new Dictionary<ConsoleKey,char>();
        private readonly Dictionary<ConsoleKey,char> AltKeys = new Dictionary<ConsoleKey,char>();

        Journal()
        {
            for (int i = 0; i < KeyPositions.Length; ++i)
            {
                MainKeys.Add(KeyPositions[i], MainKeyList[i]);
                //if (ShiftKeyList[i] != '@') { ShiftKeys.Add(KeyPositions[i], ShiftKeyList[i]); }
                if (AltKeyList[i] != '@')
                {
                    ShiftKeys.Add(KeyPositions[i], AltKeyList[i]);
                    AltKeys.Add(KeyPositions[i], AltKeyList[i]);
                }
            }
        }

        private char prev = ' ';
        private int savedcol = -1;
        private int currentcol = 0;
        void NextKey(ConsoleKey x, ConsoleModifiers m)
        {
            char c; bool thing;
            if ((m & ConsoleModifiers.Shift) != 0) { thing = ShiftKeys.TryGetValue(x, out c); }
            else if ((m & ConsoleModifiers.Alt) != 0) { thing = AltKeys.TryGetValue(x, out c); }
            else { thing = MainKeys.TryGetValue(x, out c); }

            if (thing)
            {
                if (prev == ' ' && c == ' ')
                {
                    while (currentcol - 1 > savedcol) { --Console.CursorLeft; Console.Write(' '); --Console.CursorLeft; --currentcol; }
                }
                else
                {
                    if (prev == ' ')
                    {
                        if (currentcol >= 60) { OutLine(); currentcol = 0; }
                        savedcol = currentcol - 1;
                    }
                    Out(c);
                    ++currentcol;
                }
                prev = c;
            }
            else
            {
                //Out(x);
            }
        }

        private void Main() {
            bool fin = false;
            while (!fin)
            {
                var rk = Console.ReadKey(true);
                if (rk.Key == ConsoleKey.Escape || rk.Key == ConsoleKey.Oem3) { fin = true; }
                else { NextKey(rk.Key, rk.Modifiers); }
            }
        }
        public static void Main(string[] args)
        {
            Console.Title = "JCONSTRAINT";
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int countdown = 3;
            while (countdown > 0)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.K) { --countdown; }
                else { countdown = 3; }
            }
            new Journal().Main();
        }
    }
}
