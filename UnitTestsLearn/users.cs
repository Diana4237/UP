//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTestsLearn
{
    using System;
    using System.Collections.Generic;
    
    public partial class users
    {
        public int id_user { get; set; }
        public string password_user { get; set; }
        public string login_user { get; set; }
        public Nullable<int> id_role { get; set; }
    
        public virtual roles roles { get; set; }
    }
}
