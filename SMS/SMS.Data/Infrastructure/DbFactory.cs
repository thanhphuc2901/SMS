using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data.Infrastructure
{
    class DbFactory : IDisposable
    {

        private SMSDbContext smsDbContext;
        public SMSDbContext Init()
        {
            return smsDbContext ?? (smsDbContext = new SMSDbContext());
        }
        private bool isDisposed;
        /// <summary>
        /// hàm hủy rác
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }
        public virtual void DisposeCore()
        {

        }
    }
}
