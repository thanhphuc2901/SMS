using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data.Infrastructure
{
    class UnitOfWork
    {
        private readonly DbFactory _dbFactory;
        private SMSDbContext _smsDbcontext;


        public UnitOfWork(DbFactory dbFactory)
        {
            this._dbFactory = dbFactory;
        }
        public SMSDbContext SMSDbContext
        {
            get
            {
                return this._smsDbcontext ?? (_smsDbcontext = _dbFactory.Init());
            }
        }

        public void Commit()
        {
            SMSDbContext.SaveChanges();
        }

    }
}
