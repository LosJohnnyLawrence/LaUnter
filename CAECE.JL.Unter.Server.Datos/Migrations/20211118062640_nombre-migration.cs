using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CAECE.JL.Unter.Server.Datos.Migrations
{
    public partial class nombremigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoMesas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoMesas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadosPreparacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosPreparacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mozos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaEntrada = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mozos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sectores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mesas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CantComensales = table.Column<int>(type: "int", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mesas_EstadoMesas_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "EstadoMesas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mesas_Sectores_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TurnoMozos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dia = table.Column<int>(type: "int", nullable: false),
                    InicioTurno = table.Column<TimeSpan>(type: "time", nullable: false),
                    FinTurno = table.Column<TimeSpan>(type: "time", nullable: false),
                    MozoId = table.Column<int>(type: "int", nullable: true),
                    SectorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TurnoMozos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TurnoMozos_Mozos_MozoId",
                        column: x => x.MozoId,
                        principalTable: "Mozos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TurnoMozos_Sectores_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MesaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Mesas_MesaId",
                        column: x => x.MesaId,
                        principalTable: "Mesas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Estadias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MesaId = table.Column<int>(type: "int", nullable: true),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MozoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Estadias_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estadias_Mesas_MesaId",
                        column: x => x.MesaId,
                        principalTable: "Mesas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estadias_Mozos_MozoId",
                        column: x => x.MozoId,
                        principalTable: "Mozos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesaId = table.Column<int>(type: "int", nullable: true),
                    Notas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MozoId = table.Column<int>(type: "int", nullable: true),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaUltimaModificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadiaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Estadias_EstadiaId",
                        column: x => x.EstadiaId,
                        principalTable: "Estadias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_EstadosPreparacion_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "EstadosPreparacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Mesas_MesaId",
                        column: x => x.MesaId,
                        principalTable: "Mesas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pedidos_Mozos_MozoId",
                        column: x => x.MozoId,
                        principalTable: "Mozos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RestriccionAlimentarias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BebidaId = table.Column<int>(type: "int", nullable: true),
                    PlatoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestriccionAlimentarias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bebida",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bebida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bebida_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Plato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plato_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Selecciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    EstadoId = table.Column<int>(type: "int", nullable: true),
                    PedidoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Selecciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Selecciones_EstadosPreparacion_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "EstadosPreparacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Selecciones_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: true),
                    PlatoId = table.Column<int>(type: "int", nullable: true),
                    SeleccionId = table.Column<int>(type: "int", nullable: true),
                    SeleccionId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Plato_PlatoId",
                        column: x => x.PlatoId,
                        principalTable: "Plato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Selecciones_SeleccionId",
                        column: x => x.SeleccionId,
                        principalTable: "Selecciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Selecciones_SeleccionId1",
                        column: x => x.SeleccionId1,
                        principalTable: "Selecciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MotivoDevoluciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PedidoId = table.Column<int>(type: "int", nullable: true),
                    SeleccionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotivoDevoluciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MotivoDevoluciones_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MotivoDevoluciones_Selecciones_SeleccionId",
                        column: x => x.SeleccionId,
                        principalTable: "Selecciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingrediente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CantidadStock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingrediente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingrediente_Item_Id",
                        column: x => x.Id,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bebida_CategoriaId",
                table: "Bebida",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_MesaId",
                table: "Clientes",
                column: "MesaId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadias_ClienteId",
                table: "Estadias",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadias_MesaId",
                table: "Estadias",
                column: "MesaId");

            migrationBuilder.CreateIndex(
                name: "IX_Estadias_MozoId",
                table: "Estadias",
                column: "MozoId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemId",
                table: "Item",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_PlatoId",
                table: "Item",
                column: "PlatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_SeleccionId",
                table: "Item",
                column: "SeleccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_SeleccionId1",
                table: "Item",
                column: "SeleccionId1");

            migrationBuilder.CreateIndex(
                name: "IX_Mesas_EstadoId",
                table: "Mesas",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mesas_SectorId",
                table: "Mesas",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_MotivoDevoluciones_PedidoId",
                table: "MotivoDevoluciones",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_MotivoDevoluciones_SeleccionId",
                table: "MotivoDevoluciones",
                column: "SeleccionId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EstadiaId",
                table: "Pedidos",
                column: "EstadiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EstadoId",
                table: "Pedidos",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_MesaId",
                table: "Pedidos",
                column: "MesaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_MozoId",
                table: "Pedidos",
                column: "MozoId");

            migrationBuilder.CreateIndex(
                name: "IX_Plato_CategoriaId",
                table: "Plato",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_RestriccionAlimentarias_BebidaId",
                table: "RestriccionAlimentarias",
                column: "BebidaId");

            migrationBuilder.CreateIndex(
                name: "IX_RestriccionAlimentarias_PlatoId",
                table: "RestriccionAlimentarias",
                column: "PlatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Selecciones_EstadoId",
                table: "Selecciones",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Selecciones_ItemId",
                table: "Selecciones",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Selecciones_PedidoId",
                table: "Selecciones",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_TurnoMozos_MozoId",
                table: "TurnoMozos",
                column: "MozoId");

            migrationBuilder.CreateIndex(
                name: "IX_TurnoMozos_SectorId",
                table: "TurnoMozos",
                column: "SectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_RestriccionAlimentarias_Bebida_BebidaId",
                table: "RestriccionAlimentarias",
                column: "BebidaId",
                principalTable: "Bebida",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RestriccionAlimentarias_Plato_PlatoId",
                table: "RestriccionAlimentarias",
                column: "PlatoId",
                principalTable: "Plato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bebida_Item_Id",
                table: "Bebida",
                column: "Id",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Plato_Item_Id",
                table: "Plato",
                column: "Id",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Selecciones_Item_ItemId",
                table: "Selecciones",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plato_Categorias_CategoriaId",
                table: "Plato");

            migrationBuilder.DropForeignKey(
                name: "FK_Plato_Item_Id",
                table: "Plato");

            migrationBuilder.DropForeignKey(
                name: "FK_Selecciones_Item_ItemId",
                table: "Selecciones");

            migrationBuilder.DropTable(
                name: "Ingrediente");

            migrationBuilder.DropTable(
                name: "MotivoDevoluciones");

            migrationBuilder.DropTable(
                name: "RestriccionAlimentarias");

            migrationBuilder.DropTable(
                name: "TurnoMozos");

            migrationBuilder.DropTable(
                name: "Bebida");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Plato");

            migrationBuilder.DropTable(
                name: "Selecciones");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Estadias");

            migrationBuilder.DropTable(
                name: "EstadosPreparacion");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Mozos");

            migrationBuilder.DropTable(
                name: "Mesas");

            migrationBuilder.DropTable(
                name: "EstadoMesas");

            migrationBuilder.DropTable(
                name: "Sectores");
        }
    }
}
