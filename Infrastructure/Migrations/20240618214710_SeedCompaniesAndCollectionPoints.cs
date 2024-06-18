using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompaniesAndCollectionPoints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "310c0400-8e8c-4ebb-a41a-ae3c652438dc");

            migrationBuilder.Sql(@"DELETE FROM ""Companies"" ");
            migrationBuilder.Sql(@"DELETE FROM ""CollectionPoints"" ");

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "AddressNumber", "Cep", "CepDeliveryEndRange", "CepDeliveryInitialRange", "Cnpj", "CollectionLine", "Name", "OwnerId", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Rua José Clemente Pereira, 440, Ipiranga, Belo Horizonte/MG", 440, "31160-160", "31164-160", "31156-160", "46.648.151/0001-51", 2, "Prodabel - Centro de Recondicionamento de Computadores", 1, "3277-4771" },
                    { 2, "PRAÇA RIO BRANCO, 100 - SEM COMPLEMENTO - CENTRO - 30110-002 - BELO HORIZONTE/MG", 100, "30110-002", "30114-002", "30106-002", "23.514.057/0001-04", 2, "PRAÇA RIO BRANCO, 100 - SEM COMPLEMENTO - CENTRO - 30110-002 - BELO HORIZONTE/MG", 1, "Não informado" },
                    { 3, "RUA DA BELGICA, 676 - LOJA 13 - GLORIA - CONTAGEM/MG", 676, "32340-003", "32344-003", "32336-003", "43.570.787/0001-30", 2, "CRJ SSISTEC LTDA ME", 1, "Não informado" },
                    { 4, "AV. PRES.ANTONIO CARLOS, 2030 - CACHOEIRINHA - BELO HORIZONTE/MG", 2030, "31130-122", "31134-122", "31126-122", "32.622.877/0001-00", 0, "ASSISTÊNCIA TÉCNICA ELETROGEL REFRIGERACAO LTDA", 1, "Não informado" },
                    { 5, "R. Rad. Ubaldo Ferreira, 20 - Castelo, Belo Horizonte - MG", 20, "31330-294", "31334-294", "31326-294", "57.698.273/0001-79", 0, "PROPAM", 1, "(31) 3277-7422" },
                    { 6, "Rua Oscár Castanheira, 112 - Dona Clara, Belo Horizonte - MG", 112, "31260-360", "31264-360", "31256-360", "13.214.175/0001-43", 0, "Hemar Ltda", 1, "(31) 3226-5024" },
                    { 7, "Av. Duque de Caxias, 810 - Esplanada da Estacao, Itabira - MG", 810, "35900-236", "35904-236", "35896-236", "13.101.937/0001-03", 0, "ACITA - ITABIRA", 1, "(31) 3831-2025" },
                    { 8, "Edifício Maletta |, R. da Bahia, 1148 - Sala 602 - Centro, Belo Horizonte - MG", 1148, "30160-011", "30164-011", "30156-011", "90.523.932/0001-01", 1, "AMI TECNO - AMI Informática e Tecnologia Ltda.", 1, "(31) 3213-2087" },
                    { 9, "R. Pouso Alegre, 2616 - Horto, Belo Horizonte - MG", 2616, "31010-514", "31014-514", "31006-514", "44.289.073/0001-10", 1, "Átria Informática", 1, "(31) 98457-5197" },
                    { 10, "Rua Professor José Vieira de Mendonça, 770 - Engenho Nogueira, Belo Horizonte - MG", 770, "31310-260", "31314-260", "31306-260", "72.643.472/0001-73", 1, "BH-TEC Parque Tecnológico", 1, "(31) 3401-1000" },
                    { 11, "R. Rad. Ubaldo Ferreira, 20 - Castelo, Belo Horizonte - MG", 20, "31330-294", "31334-294", "31326-294", "05.736.618/0001-38", 1, "CEA PROPAM", 1, "(31) 3364-3266" },
                    { 12, "Av. do Contorno, 8000 - Lourdes, Belo Horizonte - MG", 8000, "30110-932", "30114-932", "30106-932", "95.073.524/0001-19", 1, "Condomínio do Edifício Wall Street – Centro Empresarial", 1, "(31) 2535-7475" },
                    { 13, "R. Bernardo Guimarães, 3000 - Santo Agostinho, Belo Horizonte - MG", 3000, "30140-083", "30144-083", "30136-083", "47.175.895/0001-69", 3, "Ctrl+Play", 1, "(31) 3582-8726" },
                    { 14, "R. Canadá, 454 - Boa Vista, Patos de Minas - MG", 454, "38705-116", "38709-116", "38701-116", "01.750.374/0001-97", 2, "CVT PATOS DE MINAS", 1, "(34) 3822-9700" },
                    { 15, "Rua Venâncio Augusto Gomes, 50 - Maj. Lage de Cima, Itabira - MG", 50, "35900-842", "35904-842", "35896-842", "68.813.023/0001-59", 1, "Funcesi/Fundação Comunitária de Ensino Superior de Itabira - FUNCESI", 1, "(31) 3839-3600" },
                    { 16, "R. Padre Eustáquio, 443 - Carlos Prates, Belo Horizonte - MG", 20, "30710-580", "30714-580", "30706-580", "94.589.971/0001-62", 0, "Litium Informatica", 1, "(31) 3442-9571" }
                });

            migrationBuilder.InsertData(
                table: "CollectionPoints",
                columns: new[] { "Id", "Address", "Cep", "CompanyId", "Number" },
                values: new object[,]
                {
                    { 1, "Rua José Clemente Pereira, 440, Ipiranga, Belo Horizonte/MG", "31330-160", 1, 440 },
                    { 2, "PRAÇA RIO BRANCO, 100 - SEM COMPLEMENTO - CENTRO - BELO HORIZONTE/MG", "31330-002", 2, 100 },
                    { 3, "RUA DA BELGICA, 676 - LOJA 13 - GLORIA - CONTAGEM/MG", "31330-003", 3, 676 },
                    { 4, "AV. PRES.ANTONIO CARLOS, 2030 - CACHOEIRINHA - BELO HORIZONTE/MG", "31330-122", 4, 2030 },
                    { 5, "R. Rad. Ubaldo Ferreira, 20 - Castelo, Belo Horizonte - MG", "31330-294", 5, 20 },
                    { 6, "Rua Oscár Castanheira, 112 - Dona Clara, Belo Horizonte - MG", "31330-360", 6, 112 },
                    { 7, "Av. Duque de Caxias, 810 - Esplanada da Estacao, Itabira - MG", "31330-236", 7, 810 },
                    { 8, "Edifício Maletta |, R. da Bahia, 1148 - Sala 602 - Centro, Belo Horizonte - MG", "31330-011", 8, 1148 },
                    { 9, "R. Pouso Alegre, 2616 - Horto, Belo Horizonte - MG", "31310-514", 9, 2616 },
                    { 10, "Rua Professor José Vieira de Mendonça, 770 - Engenho Nogueira, Belo Horizonte - MG", "31310-260", 10, 770 },
                    { 11, "R. Rad. Ubaldo Ferreira, 20 - Castelo, Belo Horizonte - MG", "31330-294", 11, 20 },
                    { 12, "Av. do Contorno, 8000 - Lourdes, Belo Horizonte - MG", "31300-932", 12, 8000 },
                    { 13, "R. Bernardo Guimarães, 3000 - Santo Agostinho, Belo Horizonte - MG", "31330-083", 13, 3000 },
                    { 14, "R. Canadá, 454 - Boa Vista, Patos de Minas - MG", "31330-116", 14, 454 },
                    { 15, "Rua Venâncio Augusto Gomes, 50 - Maj. Lage de Cima, Itabira - MG", "31330-842", 15, 50 },
                    { 16, "R. Padre Eustáquio, 443 - Carlos Prates, Belo Horizonte - MG", "31330-580", 16, 443 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CollectionPoints",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CollectionPoints",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CollectionPoints",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CollectionPoints",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CollectionPoints",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CollectionPoints",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CollectionPoints",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CollectionPoints",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CollectionPoints",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CollectionPoints",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CollectionPoints",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CollectionPoints",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CollectionPoints",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CollectionPoints",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CollectionPoints",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CollectionPoints",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8bfbd40a-7ab8-41da-bbaa-c5392f7a231e");
        }
    }
}
