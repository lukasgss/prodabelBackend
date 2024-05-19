# Back end
Recicla BHTech

Trabalho Interdisciplinar de Aplicações Distribuídas 
Professor: Pedro Silva Alves
Pontifícia Universidade Católica de Minas Gerais

Alunos:
Lucas Gomes Silva
Janaina Vasconcelos Alves
Victor Geovane Morais Silva
Pedro Miguel Moraes Durço


## Como clonar para ambiente local

- Instale o [PostgreSQL 16](https://www.postgresql.org/download/)
- Instale o [.NET 8](https://dotnet.microsoft.com/pt-br/download/dotnet/8.0)
- Clone o projeto na sua máquina com o comando:
```bash
git clone git@github.com:lukasgss/prodabelBackend.git
```

## Configurar o banco local

- No arquivo *appSettings.Development.json*, está definida a connection string do banco:
![image](https://github.com/lukasgss/prodabelBackend/assets/69154977/ea05ea89-781e-4e1c-b38f-2b297b7ffcbc)
- Após a instalação do PostgreSQL, você terá definido uma senha para o usuário *postgres*. Deve ser alterado o valor de *Password* no arquivo de appSettings pelo valor que foi definida a senha anteriormente
- Com isso, entre na pasta de *Infrastructure* pelo explorador de arquivos, clique com o botão direito e clique na opção de **Abrir janela do Powershell aqui** ou **Abrir janela de comando aqui**
![image](https://github.com/lukasgss/prodabelBackend/assets/69154977/be8e7b6d-201b-4434-96b4-7993f7ef948f)

- Ao abrir o prompt de comando ou Powershell na pasta de **Infrastructure**, basta rodar o comando
```bash
dotnet ef -s ../Api/Api.csproj database update
```
- Com isso, o banco local será criado:
![image](https://github.com/lukasgss/prodabelBackend/assets/69154977/3bff46ed-547a-4d5b-a735-1eb55b3f5442)



## Executar projeto

- Para rodar o projeto, caso utilizem o Visual Studio, basta abrir o projeto e clicar em play. Como o Visual Studio é muito pesado e acaba travando a máquina, recomendo rodarem por meio do terminal com as seguintes instruções:

### Executar projeto pelo terminal
- Vá até a pasta em que o projeto está pelo explorador de arquivos, entre na pasta **Api** e clique com o botão direito no explorador de arquivos. Com isso, serão exibidas as opções disponíveis, e uma delas é a de abrir a janela de PowerShell ou do prompt de comando.

![image](https://github.com/lukasgss/prodabelBackend/assets/69154977/995d11ad-d59e-4183-83c6-e1b301df2672)

- Ao abrir em qualquer um dos dois, seja prompt de comando ou PowerShell, basta rodar o comando:

```bash
dotnet run
```

- Com isso, o back end estará rodando em sua máquina local na porta 5080 e é possível fazer os testes e as integrações:
![image](https://github.com/lukasgss/prodabelBackend/assets/69154977/3aa0e930-1df8-4ac6-aee9-252c09638c26)
