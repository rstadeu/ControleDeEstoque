﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ControleEstoqueEntities1 : DbContext
    {
        public ControleEstoqueEntities1()
            : base("name=ControleEstoqueEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Allocation> Allocations { get; set; }
        public virtual DbSet<BaixaOrdem> BaixaOrdems { get; set; }
        public virtual DbSet<CustoPorItem> CustoPorItems { get; set; }
        public virtual DbSet<Estoque> Estoques { get; set; }
        public virtual DbSet<Fornecedor> Fornecedors { get; set; }
        public virtual DbSet<Kit> Kits { get; set; }
        public virtual DbSet<KitChanged> KitChangeds { get; set; }
        public virtual DbSet<KitList> KitLists { get; set; }
        public virtual DbSet<MaterialSubType> MaterialSubTypes { get; set; }
        public virtual DbSet<MaterialType> MaterialTypes { get; set; }
        public virtual DbSet<MeasureUnit> MeasureUnits { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<ProductChanged> ProductChangeds { get; set; }
        public virtual DbSet<Produto> Produtoes { get; set; }
        public virtual DbSet<ProdutoFornecedor> ProdutoFornecedors { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Transferencia> Transferencias { get; set; }
        public virtual DbSet<PrecoProduto> PrecoProdutos { get; set; }
        public virtual DbSet<OrderProductsCheck> OrderProductsChecks { get; set; }
    }
}
