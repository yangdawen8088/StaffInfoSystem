using StaffInfoSystem.Database;
using StaffInfoSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaffInfoSystem.Services
{
    class WorkerRepository : IWorkerRepository
    {
        void IWorkerRepository.AddWorker(Worker worker)
        {
            List<Worker> workers = new List<Worker>();
            workers.Add(worker);
            DbWorker dbWorker = new DbWorker();
            dbWorker.SetWorkerAsync(workers);
        }

        void IWorkerRepository.DelWorker(Guid workerId)
        {
            DbWorker dbWorker = new DbWorker();
            dbWorker.DelWorkerAsync(workerId);
        }

        Worker IWorkerRepository.GetWorker(string KeyJobNum)
        {
            DbWorker dbWorker = new DbWorker();
            IEnumerable<Worker> workers = dbWorker.GetWorker();
            return workers.Where(w=>w.JobNum==KeyJobNum).FirstOrDefault();
        }

        IEnumerable<Worker> IWorkerRepository.GetWorkers(string KeyName)
        {
            DbWorker dbWorker = new DbWorker();
            IEnumerable<Worker> workers = dbWorker.GetWorker();
            if (!string.IsNullOrWhiteSpace(KeyName))
            {
                workers = workers.Where(w => w.WorkerName.Contains(KeyName));
            }
            return workers;
        }

        void IWorkerRepository.UpdateWorker(Worker worker)
        {
            DbWorker dbWorker = new DbWorker();
            dbWorker.UpdateWorkerAsync(worker);
        }
    }
}
