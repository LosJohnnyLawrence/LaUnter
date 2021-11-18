using Microsoft.EntityFrameworkCore;
using System;

namespace CAECE.JL.Unter.Server.Datos
{
    public class ContextoDatosUnter : DbContext
    {
        public ContextoDatosUnter(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item> ItemsMenu { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Mozo> Mozos { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Plato> Platos { get; set; }
        public DbSet<Bebida> Bebidas { get; set; }
        public DbSet<Sector> Sectores { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Estadia> Estadias { get; set; }
        public DbSet<EstadoMesa> EstadoMesas { get; set; }
        public DbSet<EstadoPreparacion> EstadosPreparacion { get; set; }
        public DbSet<RestriccionAlimentaria> RestriccionAlimentarias { get; set; }
        public DbSet<Seleccion> Selecciones { get; set; }
        public DbSet<TurnoMozo> TurnoMozos { get; set; }
        public DbSet<MotivoDevolucion> MotivoDevoluciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<Ingrediente>().HasBaseType<Item>();
            modelBuilder.Entity<Bebida>().HasBaseType<Item>();
            modelBuilder.Entity<Plato>();


            base.OnModelCreating(modelBuilder);

        }

    }

   
}
