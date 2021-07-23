using StaffInfoSystem.BLL;
using StaffInfoSystem.Database;
using StaffInfoSystem.Models;
using System;
using System.Collections.Generic;

namespace StaffInfoSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("职工信息管理系统");
            do
            {
            Console.WriteLine("请输入序号选择菜单......");
                Console.WriteLine("1. 新增职工信息");
                Console.WriteLine("2. 删除职工信息");
                Console.WriteLine("3. 修改职工信息");
                Console.WriteLine("4. 查询职工信息");
                Console.WriteLine("请输入选项：");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Action actionvAdd = WorkerBll.AddData;
                        actionvAdd();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Action actionDel = WorkerBll.DelData;
                        actionDel();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Action actionUpDate = WorkerBll.UpDate;
                        actionUpDate();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Action actionSearch = WorkerBll.SearchData;
                        actionSearch();
                        break;
                    default:
                        Console.WriteLine("\n错误的输入键......");
                        break;
                }
                Console.WriteLine("按 ESC 键为退出系统，其他键继续......");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            //DbWorker dbWorker = new DbWorker();
            //List<Worker> y = dbWorker.GetWorker();
            //Worker worker = new Worker()
            //{
            //    Id = Guid.NewGuid(),
            //    WorkerName = "大文",
            //    Age = 23,
            //    Gender = false,
            //    Salary = 45000,
            //    Department = "销售部",
            //    JobNum = "20210723005"
            //};
            //List<Worker> workers = new List<Worker>();
            //workers.Add(worker);
            //dbWorker.SetWorkerAsync(workers);
            ////dbWorker.UpdateWorkerAsync(worker);
            //List<Worker> x = dbWorker.GetWorker();
            //Console.WriteLine("Hello World!");
        }
    }
}
