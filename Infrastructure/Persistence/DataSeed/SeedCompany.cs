using Domain.Entities;

namespace Infrastructure.Persistence.DataSeed;

public static class SeedCompany
{
    public static List<Company> Seed()
    {
        return [
            new Company
            {
                Id = 1,
                Name = "Prodabel - Centro de Recondicionamento de Computadores",
                Cep = "31160-160",
                Address = "Rua José Clemente Pereira, 440, Ipiranga, Belo Horizonte/MG",
                AddressNumber = 440,
                CollectionLine = CollectionLine.Azul,
                Cnpj = "46.648.151/0001-51",
                CepDeliveryInitialRange = "31156-160",
                CepDeliveryEndRange = "31164-160",
                PhoneNumber = "3277-4771",
                OwnerId = 1
            },
            new Company
            {
                Id = 2,
                Name = "PRAÇA RIO BRANCO, 100 - SEM COMPLEMENTO - CENTRO - 30110-002 - BELO HORIZONTE/MG",
                Cep = "30110-002",
                Address = "PRAÇA RIO BRANCO, 100 - SEM COMPLEMENTO - CENTRO - 30110-002 - BELO HORIZONTE/MG",
                AddressNumber = 100,
                CollectionLine = CollectionLine.Azul,
                Cnpj = "23.514.057/0001-04",
                CepDeliveryInitialRange = "30106-002",
                CepDeliveryEndRange = "30114-002",
                PhoneNumber = "Não informado",
                OwnerId = 1
            },
            new Company
            {
                Id = 3,
                Name = "CRJ SSISTEC LTDA ME",
                Cep = "32340-003",
                Address = "RUA DA BELGICA, 676 - LOJA 13 - GLORIA - CONTAGEM/MG",
                AddressNumber = 676,
                CollectionLine = CollectionLine.Azul,
                Cnpj = "43.570.787/0001-30",
                CepDeliveryInitialRange = "32336-003",
                CepDeliveryEndRange = "32344-003",
                PhoneNumber = "Não informado",
                OwnerId = 1
            },
            new Company
            {
                Id = 4,
                Name = "ASSISTÊNCIA TÉCNICA ELETROGEL REFRIGERACAO LTDA",
                Cep = "31130-122",
                Address = "AV. PRES.ANTONIO CARLOS, 2030 - CACHOEIRINHA - BELO HORIZONTE/MG",
                AddressNumber = 2030,
                CollectionLine = CollectionLine.Verde,
                Cnpj = "32.622.877/0001-00",
                CepDeliveryInitialRange = "31126-122",
                CepDeliveryEndRange = "31134-122",
                PhoneNumber = "Não informado",
                OwnerId = 1
            },
            new Company
            {
                Id = 5,
                Name = "PROPAM",
                Cep = "31330-294",
                Address = "R. Rad. Ubaldo Ferreira, 20 - Castelo, Belo Horizonte - MG",
                AddressNumber = 20,
                CollectionLine = CollectionLine.Verde,
                Cnpj = "57.698.273/0001-79",
                CepDeliveryInitialRange = "31326-294",
                CepDeliveryEndRange = "31334-294",
                PhoneNumber = "(31) 3277-7422",
                OwnerId = 1
            },
            new Company
            {
                Id = 6,
                Name = "Hemar Ltda",
                Cep = "31260-360",
                Address = "Rua Oscár Castanheira, 112 - Dona Clara, Belo Horizonte - MG",
                AddressNumber = 112,
                CollectionLine = CollectionLine.Verde,
                Cnpj = "13.214.175/0001-43",
                CepDeliveryInitialRange = "31256-360",
                CepDeliveryEndRange = "31264-360",
                PhoneNumber = "(31) 3226-5024",
                OwnerId = 1
            },
            new Company
            {
                Id = 7,
                Name = "ACITA - ITABIRA",
                Cep = "35900-236",
                Address = "Av. Duque de Caxias, 810 - Esplanada da Estacao, Itabira - MG",
                AddressNumber = 810,
                CollectionLine = CollectionLine.Verde,
                Cnpj = "13.101.937/0001-03",
                CepDeliveryInitialRange = "35896-236",
                CepDeliveryEndRange = "35904-236",
                PhoneNumber = "(31) 3831-2025",
                OwnerId = 1
            },
            new Company
            {
                Id = 8,
                Name = "AMI TECNO - AMI Informática e Tecnologia Ltda.",
                Cep = "30160-011",
                Address = "Edifício Maletta |, R. da Bahia, 1148 - Sala 602 - Centro, Belo Horizonte - MG",
                AddressNumber = 1148,
                CollectionLine = CollectionLine.Marrom,
                Cnpj = "90.523.932/0001-01",
                CepDeliveryInitialRange = "30156-011",
                CepDeliveryEndRange = "30164-011",
                PhoneNumber = "(31) 3213-2087",
                OwnerId = 1
            },
            new Company
            {
                Id = 9,
                Name = "Átria Informática",
                Cep = "31010-514",
                Address = "R. Pouso Alegre, 2616 - Horto, Belo Horizonte - MG",
                AddressNumber = 2616,
                CollectionLine = CollectionLine.Marrom,
                Cnpj = "44.289.073/0001-10",
                CepDeliveryInitialRange = "31006-514",
                CepDeliveryEndRange = "31014-514",
                PhoneNumber = "(31) 98457-5197",
                OwnerId = 1
            },
            new Company
            {
                Id = 10,
                Name = "BH-TEC Parque Tecnológico",
                Cep = "31310-260",
                Address = "Rua Professor José Vieira de Mendonça, 770 - Engenho Nogueira, Belo Horizonte - MG",
                AddressNumber = 770,
                CollectionLine = CollectionLine.Marrom,
                Cnpj = "72.643.472/0001-73",
                CepDeliveryInitialRange = "31306-260",
                CepDeliveryEndRange = "31314-260",
                PhoneNumber = "(31) 3401-1000",
                OwnerId = 1
            },
            new Company
            {
                Id = 11,
                Name = "CEA PROPAM",
                Cep = "31330-294",
                Address = "R. Rad. Ubaldo Ferreira, 20 - Castelo, Belo Horizonte - MG",
                AddressNumber = 20,
                CollectionLine = CollectionLine.Marrom,
                Cnpj = "05.736.618/0001-38",
                CepDeliveryInitialRange = "31326-294",
                CepDeliveryEndRange = "31334-294",
                PhoneNumber = "(31) 3364-3266",
                OwnerId = 1
            },
            new Company
            {
                Id = 12,
                Name = "Condomínio do Edifício Wall Street – Centro Empresarial",
                Cep = "30110-932",
                Address = "Av. do Contorno, 8000 - Lourdes, Belo Horizonte - MG",
                AddressNumber = 8000,
                CollectionLine = CollectionLine.Marrom,
                Cnpj = "95.073.524/0001-19",
                CepDeliveryInitialRange = "30106-932",
                CepDeliveryEndRange = "30114-932",
                PhoneNumber = "(31) 2535-7475",
                OwnerId = 1
            },
            new Company
            {
                Id = 13,
                Name = "Ctrl+Play",
                Cep = "30140-083",
                Address = "R. Bernardo Guimarães, 3000 - Santo Agostinho, Belo Horizonte - MG",
                AddressNumber = 3000,
                CollectionLine = CollectionLine.Branco,
                Cnpj = "47.175.895/0001-69",
                CepDeliveryInitialRange = "30136-083",
                CepDeliveryEndRange = "30144-083",
                PhoneNumber = "(31) 3582-8726",
                OwnerId = 1
            },
            new Company
            {
                Id = 14,
                Name = "CVT PATOS DE MINAS",
                Cep = "38705-116",
                Address = "R. Canadá, 454 - Boa Vista, Patos de Minas - MG",
                AddressNumber = 454,
                CollectionLine = CollectionLine.Azul,
                Cnpj = "01.750.374/0001-97",
                CepDeliveryInitialRange = "38701-116",
                CepDeliveryEndRange = "38709-116",
                PhoneNumber = "(34) 3822-9700",
                OwnerId = 1
            },
            new Company
            {
                Id = 15,
                Name = "Funcesi/Fundação Comunitária de Ensino Superior de Itabira - FUNCESI",
                Cep = "35900-842",
                Address = "Rua Venâncio Augusto Gomes, 50 - Maj. Lage de Cima, Itabira - MG",
                AddressNumber = 50,
                CollectionLine = CollectionLine.Marrom,
                Cnpj = "68.813.023/0001-59",
                CepDeliveryInitialRange = "35896-842",
                CepDeliveryEndRange = "35904-842",
                PhoneNumber = "(31) 3839-3600",
                OwnerId = 1
            },
            new Company
            {
                Id = 16,
                Name = "Litium Informatica",
                Cep = "30710-580",
                Address = "R. Padre Eustáquio, 443 - Carlos Prates, Belo Horizonte - MG",
                AddressNumber = 20,
                CollectionLine = CollectionLine.Verde,
                Cnpj = "94.589.971/0001-62",
                CepDeliveryInitialRange = "30706-580",
                CepDeliveryEndRange = "30714-580",
                PhoneNumber = "(31) 3442-9571",
                OwnerId = 1
            }
        ];
    }
}