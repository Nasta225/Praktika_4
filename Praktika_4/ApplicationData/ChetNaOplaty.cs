//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Praktika_4.ApplicationData
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChetNaOplaty
    {
        public int id { get; set; }
        public int articul { get; set; }
        public string tovar { get; set; }
        public int kolichestvo { get; set; }
        public decimal chena { get; set; }
        public string stavka { get; set; }
        public decimal symmaNDS { get; set; }
        public decimal symma { get; set; }
    
        public virtual OthetPoOplate OthetPoOplate { get; set; }
        public virtual PostoialciGivushieSeichasVGostinice PostoialciGivushieSeichasVGostinice { get; set; }
    }
}
