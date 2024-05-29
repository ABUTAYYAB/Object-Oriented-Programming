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
        bool ChangeComplainsByUserName(string Username, string Complains);
        string GetComplainsByUserName(string UserName);


    }
}
