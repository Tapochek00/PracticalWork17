﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracticalWork17
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AccountingEntities1 : DbContext
    {
        public AccountingEntities1()
            : base("name=AccountingEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accounting> Accounting { get; set; }

        //Добавляем статичную ссылку на контекст
        private static AccountingEntities1 context;

        //Добавляем метод получения ссылки на контекст
        public static AccountingEntities1 GetContext()
        {
            if (context == null)
                context = new AccountingEntities1();
            return context;
        }
    }
}
