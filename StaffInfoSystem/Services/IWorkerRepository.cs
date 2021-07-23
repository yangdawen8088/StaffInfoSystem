using StaffInfoSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffInfoSystem.Services
{
    interface IWorkerRepository
    {
        IEnumerable<Worker> GetWorkers(string KeyName);
        Worker GetWorker(string KeyJobNum);
        void AddWorker(Worker worker);
        void UpdateWorker(Worker worker);
        void DelWorker(Guid workerId);
    }
}
