using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclassproject
{
    class App
    {

        public void Run()

        {
            List<string> taskList = ReadListFromFile();

            var quit = false;

            do
            {
                PrintTaskList(taskList);
                InputTaskToList(taskList);
            } while (!quit);


        }

        private void InputTaskToList(List<string> taskList)
        {
            Console.Write("Add a new task: ");

            var input = Console.ReadLine();
            taskList.Add(input);
        }

        private void PrintTaskList(List<string> taskList)
        {
            foreach (var t in taskList)
            {
                Console.WriteLine(t);
            }
        }
        private List<string> ReadListFromFile()
        {
            var taskList = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\Jay\Documents\TaskList.txt"))
                {
                    var input = sr.ReadLine();
                    taskList.Add(input);
                }
            }
            catch (FileNotFoundException)
            {; }
            return taskList;
        }
    }
}
       
    

