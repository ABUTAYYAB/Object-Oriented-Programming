using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DairyDelightsLibrary.BL;
using DairyDelightsLibrary.Interface;


namespace DairyDelightsLibrary.DL.FileHandling
{
    public class WorkerDL : IWorker
    {
        static WorkerDL Instance;
        private WorkerDL()
        {
        }
        public static WorkerDL GetInstance(string Connection)
        {
            if (Instance == null)
            {
                Instance = new WorkerDL();
            }
            return Instance;
        }
        public bool AddComplain(string UserName, string complain)
        {
            throw new NotImplementedException();
        }

        public bool ChangeBonusByUserName(string Username, string Bonus)
        {
            throw new NotImplementedException();
        }

        public bool ChangeSalaryByUserName(string Username, string Salary)
        {
            throw new NotImplementedException();
        }

        public bool ClearComplainsByUserName(string Username)
        {
            throw new NotImplementedException();
        }

        public string GetBonusByUserName(string UserName)
        {
            throw new NotImplementedException();
        }

        public string GetComplainsByUserName(string UserName)
        {
            throw new NotImplementedException();
        }

        public List<string> GetComplainsList(string Username)
        {
            throw new NotImplementedException();
        }

        public string GetSalaryByUserName(string UserName)
        {
            throw new NotImplementedException();
        }

        public List<Worker> GetWorkerList()
        {
            throw new NotImplementedException();
        }
    }
}
