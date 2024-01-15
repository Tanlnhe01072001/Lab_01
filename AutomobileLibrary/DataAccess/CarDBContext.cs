using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileLibrary.BussinessObject;
namespace AutomobileLibrary.DataAccess
{
    public class CarDBContext
    {
        //khởi tạo danh sách xe 
        private static List<Car> CarList = new List<Car>()
        {
            new Car { CarID = 1 , CarName = "CRV" , Manufacturer = "HonDa", Price = 30000 , ReleaseYear = 2021 },
            new Car { CarID = 2 , CarName = "Ford Focus" , Manufacturer = "Ford", Price = 15000 , ReleaseYear = 2020 }
        };
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }
        public  static CarDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }
       }
    }

