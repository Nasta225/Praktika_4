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
    
    public partial class OthetPoOplate
    {
        public int id { get; set; }
        public string familia { get; set; }
        public int name { get; set; }
        public string otchestvo { get; set; }
        public string kategoria { get; set; }
        public System.DateTime datavezda { get; set; }
        public System.DateTime dataviezda { get; set; }
        public decimal summa { get; set; }
        public decimal oplacheno { get; set; }
    
        public virtual ChetNaOplaty ChetNaOplaty { get; set; }
        public virtual PostoialciGivushieSeichasVGostinice PostoialciGivushieSeichasVGostinice { get; set; }
    }
}
