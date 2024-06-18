using Domain.Entities;

namespace Infrastructure.Persistence.DataSeed;

public static class SeedCollectionPoints
{
    public static List<CollectionPoint> Seed()
    {
        return
        [
            new CollectionPoint
            {
                Id = 1,
                Cep = "31160-160",
                Address = "Rua José Clemente Pereira, 440, Ipiranga, Belo Horizonte/MG",
                Number = 440,
                CompanyId = 1
            },
            new CollectionPoint
            {
                Id = 2,
                Cep = "30110-002",
                Address = "PRAÇA RIO BRANCO, 100 - SEM COMPLEMENTO - CENTRO - BELO HORIZONTE/MG",
                Number = 100,
                CompanyId = 2
            },
            new CollectionPoint
            {
                Id = 3,
                Cep = "32340-003",
                Address = "RUA DA BELGICA, 676 - LOJA 13 - GLORIA - CONTAGEM/MG",
                Number = 676,
                CompanyId = 3
            },
            new CollectionPoint
            {
                Id = 4,
                Cep = "31130-122",
                Address = "AV. PRES.ANTONIO CARLOS, 2030 - CACHOEIRINHA - BELO HORIZONTE/MG",
                Number = 2030,
                CompanyId = 4
            },
            new CollectionPoint
            {
                Id = 5,
                Cep = "31330-294",
                Address = "R. Rad. Ubaldo Ferreira, 20 - Castelo, Belo Horizonte - MG",
                Number = 20,
                CompanyId = 5
            },
            new CollectionPoint
            {
                Id = 6,
                Cep = "31260-360",
                Address = "Rua Oscár Castanheira, 112 - Dona Clara, Belo Horizonte - MG",
                Number = 112,
                CompanyId = 6
            },
            new CollectionPoint
            {
                Id = 7,
                Cep = "35900-236",
                Address = "Av. Duque de Caxias, 810 - Esplanada da Estacao, Itabira - MG",
                Number = 810,
                CompanyId = 7
            },
            new CollectionPoint
            {
                Id = 8,
                Cep = "30160-011",
                Address = "Edifício Maletta |, R. da Bahia, 1148 - Sala 602 - Centro, Belo Horizonte - MG",
                Number = 1148,
                CompanyId = 8
            },
            new CollectionPoint
            {
                Id = 9,
                Cep = "31010-514",
                Address = "R. Pouso Alegre, 2616 - Horto, Belo Horizonte - MG",
                Number = 2616,
                CompanyId = 9
            },
            new CollectionPoint
            {
                Id = 10,
                Cep = "31310-260",
                Address = "Rua Professor José Vieira de Mendonça, 770 - Engenho Nogueira, Belo Horizonte - MG",
                Number = 770,
                CompanyId = 10
            },
            new CollectionPoint
            {
                Id = 11,
                Cep = "31330-294",
                Address = "R. Rad. Ubaldo Ferreira, 20 - Castelo, Belo Horizonte - MG",
                Number = 20,
                CompanyId = 11
            },
            new CollectionPoint
            {
                Id = 12,
                Cep = "30110-932",
                Address = "Av. do Contorno, 8000 - Lourdes, Belo Horizonte - MG",
                Number = 8000,
                CompanyId = 12
            },
            new CollectionPoint
            {
                Id = 13,
                Cep = "30140-083",
                Address = "R. Bernardo Guimarães, 3000 - Santo Agostinho, Belo Horizonte - MG",
                Number = 3000,
                CompanyId = 13
            },
            new CollectionPoint
            {
                Id = 14,
                Cep = "38705-116",
                Address = "R. Canadá, 454 - Boa Vista, Patos de Minas - MG",
                Number = 454,
                CompanyId = 14
            },
            new CollectionPoint
            {
                Id = 15,
                Cep = "35900-842",
                Address = "Rua Venâncio Augusto Gomes, 50 - Maj. Lage de Cima, Itabira - MG",
                Number = 50,
                CompanyId = 15
            },
            new CollectionPoint
            {
                Id = 16,
                Cep = "30710-580",
                Address = "R. Padre Eustáquio, 443 - Carlos Prates, Belo Horizonte - MG",
                Number = 443,
                CompanyId = 16
            }
        ];
    }
}