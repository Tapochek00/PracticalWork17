using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork17
{
    public partial class AccountingEntities : DbContext
    {
        //Добавляем статичную ссылку на контекст
        private static AccountingEntities context;

        //Добавляем метод получения ссылки на контекст
        public static AccountingEntities GetContext()
        {
            if (context == null)
                context = new AccountingEntities();
            return context;
        }
    }
}
}
