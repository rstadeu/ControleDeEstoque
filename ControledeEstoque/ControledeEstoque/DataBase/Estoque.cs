//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControledeEstoque.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estoque
    {
        public long EstoqueID { get; set; }
        public long StockID { get; set; }
        public long LocationID { get; set; }
        public long ProductID { get; set; }
        public long ProductQtd { get; set; }
        public string Date { get; set; }
    }
}
