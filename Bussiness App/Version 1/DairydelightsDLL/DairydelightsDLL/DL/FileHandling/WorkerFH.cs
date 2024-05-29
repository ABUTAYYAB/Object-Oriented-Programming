using DairydelightsDLL.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairydelightsDLL.DL.FileHandling
{
    public class WorkerFH
    {
        public static List<Worker> Workers = new List<Worker>();
        public static string Path = "Workercredentials.txt";

        public static List<Worker> AccessDetailsOfWorker(string path)
        {
            List<Worker> WorkerList = new List<Worker>(); // Initialize WorkerList
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    double Salary = double.Parse(SeperatedText(line, 1));
                    double Bonus = double.Parse(SeperatedText(line, 2));
                    string Complains = SeperatedText(line, 3);
                    string[] list = Complains.Split('%'); // Correct variable name to 'Complains'
                    Worker worker = new Worker(Salary, Bonus);
                    List<string> strings = new List<string>();

                    for(int i = 0; i < list.Length; i++)
                    {
                        strings.Add(list[i]);
                    }
                    bool result = worker.SetComplainsList(strings);
                    WorkerList.Add(worker); // Correct variable name to 'worker'
                }
                file.Close();
            }
            return WorkerList;
        }

        public static string SeperatedText(string line, int num)
        {
            int count = 1;
            string word = "";

            for (int i = 0; i < line.Length; i++)
            {
                char ch = line[i];

                if (ch == '|')
                {
                    count++;
                }
                else if (count == num)
                {
                    word += ch;
                }
            }

            return word;
        }

        public static bool StoreDetailsOfWorker(string path)
        {
            bool check = false;
            StreamWriter file = new StreamWriter(path, append: false);

            for (int i = 0; i < Workers.Count; i++)
            {
                Worker worker = Workers[i]; // Correct variable name to 'worker'
                file.WriteLine($"{worker.GetSalary()}|{worker.GetBonus()}|{worker.GetComplainsInString()}|"); // Correct variable name to 'worker'
            }
            file.Flush();
            file.Close();
            check = true;

            return check;
        }

        public static bool AddWorkerIntoList(Worker w)
        {
            Workers.Add(w); // Correct variable name to 'Workers'
            return true;
        }

        public static bool RemoveWorkerFromList(Worker w) // Correct method name to 'RemoveWorkerFromList'
        {
            Workers.Remove(w); // Correct variable name to 'Workers'
            return true;
        }
    }
}
