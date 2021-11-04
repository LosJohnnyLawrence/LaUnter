using Microsoft.EntityFrameworkCore;
using System;

namespace CAECE.JL.Unter.Server.Datos
{
    public class ContextoDatosUnter: DbContext
    {
        public ContextoDatosUnter()
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Mozo> Mozos { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Plato> Platos { get; set; }
        public DbSet<Bebida> Bebidas { get; set; }
        public DbSet<Promocion> Promocioness { get; set; }
        public DbSet<Sector> Sectores { get; set; }
        public DbSet<Seleccion> Cambios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

    }
}
