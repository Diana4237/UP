//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class history_hanges_statuses
    {
        public int id_change { get; set; }
        public Nullable<System.DateTime> date_time_change { get; set; }
        public Nullable<int> id_status { get; set; }
    
        public virtual status_licence status_licence { get; set; }
    }
}
