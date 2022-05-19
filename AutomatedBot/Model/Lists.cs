using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedBot.Model
{
    public class Lists
    {
        public static readonly Tuple<int, string>[] Functions =
        {
            new Tuple<int, string>(0, "Sem Ação"),
            new Tuple<int, string>(1, "Clique Duplo"),
            new Tuple<int, string>(2, "Escrever"),
            new Tuple<int, string>(3, "Clicar tecla"),
            new Tuple<int, string>(4, "Pressionar tecla"),
            new Tuple<int, string>(5, "Soltar teclas"),
            new Tuple<int, string>(6, "Verif. cor e aguardar"),
            new Tuple<int, string>(7, "Verif. cor e chamar rotina"),
        };

        public static readonly string[] Keys =
        {
            "-",
            "CTRL",
            "SHIFT",
            "TAB",
            "CAPSLOCK",
            "ALT",
            "ALT GR",
            "WIN",
            "ESC",
            "BACKSPACE",
            "ENTER",
            "SPACE",
            "ARROW UP",
            "ARROW DOWN",
            "ARROW LEFT",
            "ARROW RIGHT",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "Keypad 1",
            "Keypad 2",
            "Keypad 3",
            "Keypad 4",
            "Keypad 5",
            "Keypad 6",
            "Keypad 7",
            "Keypad 8",
            "Keypad 9",
            "Keypad 0",
        };
    }
}
