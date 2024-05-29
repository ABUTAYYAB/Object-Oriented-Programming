using DairyDelightsLibrary.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDelightsLibrary.Interface
{
    public interface IWorker
    {
        List<Worker> GetWorkerList();
        bool ChangeSalaryByUserName(string Username, string Salary);
        bool ChangeBonusByUserName(string Username, string Bonus);
        string GetComplainsByUserName(string UserName);
        bool AddComplain(String UserName, string complain);
        bool ClearComplainsByUserName(string Username);
        List<string> GetComplainsList(string Username);
        string GetSalaryByUserName(string UserName);
        string GetBonusByUserName(string UserName);




    }
}
