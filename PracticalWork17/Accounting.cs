//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Accounting
    {
        public int id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public Nullable<int> QuantityMon { get; set; }
        public Nullable<int> QuantityTue { get; set; }
        public Nullable<int> QuantityWed { get; set; }
        public Nullable<int> QuantityThu { get; set; }
        public Nullable<int> QuantityFri { get; set; }
        public Nullable<int> QuantitySat { get; set; }
        public Nullable<int> QuantitySun { get; set; }
        public string WorkshopName { get; set; }
        public string ProductType { get; set; }
        public Nullable<double> Cost { get; set; }
    }
}