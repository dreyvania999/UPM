//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UPM
{
    using System;
    using System.Collections.Generic;
    
    public partial class CodeRole
    {
        public string Code { get; set; }
        public int IdRole { get; set; }
        public int IdStaff { get; set; }
    
        public virtual Role Role { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
