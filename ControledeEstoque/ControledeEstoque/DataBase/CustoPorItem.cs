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
    
    public partial class CustoPorItem
    {
        public long CustoID { get; set; }
        public long ProdutoID { get; set; }
        public long OrderID { get; set; }
        public double Custo { get; set; }
        public string Observacao { get; set; }
        public string NotaFiscal { get; set; }
    }
}
