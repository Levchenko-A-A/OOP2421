using System.Linq.Expressions;
using System.Text;

namespace Control
{
    internal class Program
    {
        private static int WINDOW_WIDTH = 120;
        private static int WINDOW_HEIGHT = 40;
        private static string _currentDir = Directory.GetCurrentDirectory();
        private static string _tree = "";

        static void Main(string[] args)
        {
            Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);
            Console.SetBufferSize(WINDOW_WIDTH, WINDOW_HEIGHT);

            DrawConsole(0, 0, WINDOW_WIDTH, 18);
            DrawConsole(0, 20, WINDOW_WIDTH, 8);
            UpdateConsole();
        }

        static void DrawConsole(int x, int y, int width, int height)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("┌");
            for (int column = 0; column < width - 2; column++)
            {
                Console.Write("─");
            }
            Console.Write("┐");

            for (int row = 0; row < height; row++)
            {
                Console.Write("│");
                for (int column = 0; column < width - 2; column++)
                {
                    Console.Write(" ");
                }
                Console.Write("│");
            }
            Console.Write("└");
            for (int column = 0; column < width - 2; column++)
            {
                Console.Write("─");
            }
            Console.Write("┘");
        }

        static void UpdateConsole()
        {
            DrawInputCommandField(_currentDir, 0, 30, WINDOW_WIDTH, 1);
            CommandInputProcess();
        }

        static void DrawInputCommandField(string currentDir, int x, int y, int width, int height)
        {
            DrawConsole(x, y, width, height);

            int inputFieldLeft = 1; int inputFieldTop = 31;
            Console.SetCursorPosition(inputFieldLeft, inputFieldTop);

            Console.Write($"{currentDir}:");
        }

        static void GetCurrentCursorPosition(ref int left, ref int top)
        {
            left = Console.CursorLeft; top = Console.CursorTop;
        }

        static void CommandInputProcess()
        {
            StringBuilder command = new StringBuilder();
            int left = 0; int top = 0;
            try
            {
                GetCurrentCursorPosition(ref left, ref top);
                char pressedKey;
                do
                {
                    int currentLeft = 0; int currentTop = 0;
                    GetCurrentCursorPosition(ref currentLeft, ref currentTop);
                    pressedKey = Console.ReadKey().KeyChar;

                    if ((ConsoleKey)pressedKey == ConsoleKey.Backspace && Console.CursorLeft < left)
                    {
                        Console.Write(":");
                    }
                    else if ((ConsoleKey)pressedKey == ConsoleKey.Backspace)
                    {
                        Console.Write(" ");
                        command.Remove(command.Length - 1, 1);
                        Console.SetCursorPosition(currentLeft - 1, currentTop);
                    }
                    else if (currentLeft == WINDOW_WIDTH - 2)
                    {
                        Console.SetCursorPosition(currentLeft, currentTop);
                        Console.Write(" ");
                        Console.SetCursorPosition(currentLeft, currentTop);

                    }
                    else if ((ConsoleKey)pressedKey != ConsoleKey.Enter)
                    {
                        command.Append(pressedKey);
                    }
                }
                while ((ConsoleKey)pressedKey != ConsoleKey.Enter);

                UserCommandList(command.ToString());

            }
            catch (Exception ex)
            {
                SendMessage(ex.Message);
            }
            CommandParser(command.ToString());
        }

        static void SendMessage(string message)
        {
            Console.SetCursorPosition(1, 21);
            Console.Write(message);
            DrawInputCommandField(_currentDir, 0, 30, WINDOW_WIDTH, 1);
        }

        static void CommandParser(string command)
        {
            string[] commandKeys = command.Split(" ");

            switch (commandKeys[0])
            {

                case "ls":
                    string treePath = "";
                    int page = 0;
                    if (commandKeys.Length == 1)
                    {
                        treePath = _currentDir;
                        page = 1;
                    }
                    if (commandKeys.Length == 2)
                    {
                        treePath = _currentDir;
                        page = int.Parse(commandKeys[1]);
                    }
                    if (commandKeys.Length == 3)
                    {
                        page = int.Parse(commandKeys[1]);
                        treePath = commandKeys[2];
                    }
                    if (Directory.Exists(treePath))
                    {
                        DrawTree(page, treePath);
                    }
                    else
                    {
                        SendMessage("Directory not found");
                    }
                    break;
                case "cd":
                    _currentDir = commandKeys[1];
                    break;
            }
            UpdateConsole();
        }

        static void UserCommandList(string command)
        {
            string filePath = @"C:\Users\C5PC13\source\repos\Control\Control\ConsoleLogs.txt";
            List<string> commands;

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                commands = new List<string>();
            }
            else
            {
                commands = File.ReadAllLines(filePath).ToList();
            }
            commands.Add(command);
            string list = "";
            for (int i = 0; i < commands.Count; i++)
            {
                list += commands[i] + "\n";
            }
            File.WriteAllText(filePath, list);
        }

        static void GetTree(DirectoryInfo directory, string indent, bool lastDirectory)
        {
            _tree += indent;
            if (lastDirectory)
            {
                _tree += "└──";
                indent += "   ";
            }
            else
            {
                _tree += "├──";
                indent += "│  ";
            }
            _tree += directory.Name + "\n";

            try
            {
                DirectoryInfo[] subDirectories = directory.GetDirectories();
                for (int i = 0; i < subDirectories.Length; i++)
                {
                    GetTree(subDirectories[i], indent, i == subDirectories.Length - 1);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                UserCommandList(ex.Message);
            }
        }

        static void DrawTree(int page, string defaultPath)
        {
            GetTree(new DirectoryInfo(defaultPath), "", true);
            DrawConsole(0, 0, WINDOW_WIDTH, 18);

            string[] lines = _tree.Split('\n'); ;

            int lunesAtPage = 18;
            int pageQuantity = (int)Math.Ceiling(lines.Length / (double)lunesAtPage);

            string[,] pages = new string[pageQuantity, lunesAtPage];
            if (lines.Length >= lunesAtPage)
            {
                for (int i = 0; i < pages.GetLength(0); i++)
                {
                    int counter = 0;
                    for (int j = lunesAtPage * i; j < lunesAtPage * (i + 1); j++)
                    {
                        if (lines[j] == "")
                        {
                            break;
                        }
                        pages[i, counter] = lines[j];
                        counter++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < pages.GetLength(0); i++)
                {
                    int counter = 0;
                    for (int j = lunesAtPage * i; j < lines.Length; j++)
                    {
                        pages[i, counter] = lines[j];
                        counter++;
                    }
                }
            }
            for (int i = 0; i < pages.GetLength(1); i++)
            {
                Console.SetCursorPosition(1, i + 1);
                Console.WriteLine(pages[page - 1, i]);
            }
            string currentPage = $"Страница: [{page}/{pages.GetLength(0)}]";
            Console.SetCursorPosition(WINDOW_WIDTH / 2 - currentPage.Length / 2, 19);
            Console.Write(currentPage);

            _tree = "";


        }

    }
}