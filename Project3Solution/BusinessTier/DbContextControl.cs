using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public static class DbContextControl
    {
        private static ServiceDbContext context;

        public static ServiceDbContext GetNew()
        {
            context = new ServiceDbContext();

            return context;
        }

        /// <summary>
        /// Get the last used context, or a new one if needed.
        /// </summary>
        /// <returns></returns>
        public static ServiceDbContext GetLastOrNew()
        {
            if (context == null)
            {
                //Since a lot of old code generates a new context, this helps minimize refactoring
                if (ServiceDbContext.lastContext == null)
                    context = new ServiceDbContext();
                else context = ServiceDbContext.lastContext;
            }

            return context;
        }
    }
}
