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
    
    public partial class PostoialciGivushieSeichasVGostinice
    {
        public int id { get; set; }
        public string etag { get; set; }
        public int nomer { get; set; }
        public string kategoria { get; set; }
        public string familia { get; set; }
        public string name { get; set; }
        public string otchestvo { get; set; }
        public System.DateTime vezd { get; set; }
        public System.DateTime viezd { get; set; }
    
        public virtual ChetNaOplaty ChetNaOplaty { get; set; }
        public virtual GraficYborkiNomerov GraficYborkiNomerov { get; set; }
        public virtual nomer_fond nomer_fond { get; set; }
        public virtual OthetPoOplate OthetPoOplate { get; set; }
        public virtual OthetPoSostoianiuNomernogoFonda OthetPoSostoianiuNomernogoFonda { get; set; }
    }
}
