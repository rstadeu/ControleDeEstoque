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
    
    public partial class Fornecedor
    {
        public long FornecedorID { get; set; }
        public string NomeFornecedor { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public Nullable<long> Numero { get; set; }
        public string Complemento { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }
        public string Ramal { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public long IsActive { get; set; }
    }
}
