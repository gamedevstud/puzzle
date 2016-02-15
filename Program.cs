//запускает класс Form1 и выводит его на экран ,т.е запускает пользовательский интерфейс.
static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }
