using BackendAPI.Database;
using BackendAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Services
{
    public class LogService
    {
        private ApplicationDbContext DbContext { get;}
        public LogService(ApplicationDbContext DbContext)
        {
            this.DbContext = DbContext;
        }
        public void CreateLog(string endpoint, string data)
        {
            Log newLog = new Log();
            newLog.Data = data;
            newLog.Endpoint = endpoint;
            newLog.CreatedAt = DateTime.Now;
            DbContext.Logs.Add(newLog);
            DbContext.SaveChanges();
        }
        public List<Log> FindAll()
        {
            return DbContext.Logs.ToList();
        }
    }
}
