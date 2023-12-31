//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TravelHub.Данные
{
    using System;
    using System.Collections.Generic;
    
    public partial class Номер
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Номер()
        {
            this.Бронирование = new HashSet<Бронирование>();
            this.Список_брони = new HashSet<Список_брони>();
        }
    
        public int ID_Номера { get; set; }
        public int ID_Типа { get; set; }
        public string Название_номера { get; set; }
        public decimal Цена { get; set; }
        public byte[] Фото { get; set; }
        public int ID_Отеля { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Бронирование> Бронирование { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Список_брони> Список_брони { get; set; }
        public virtual Тип Тип { get; set; }
    }
}
