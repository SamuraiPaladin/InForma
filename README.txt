Passo a passo para usar banco de dados no projeto:

1 - Alterar as propriedades "Server" das connectionsStrings dos arquivos appsettings.js e DataContextFactory.cs, colocar nelas seu servidor de banco de dados local que você usa por exemplo:
(localDB)\\SQLEXPRESS

appsettings.js:
    "BANCO_DE_DADOS": "Server=(localdb)\\SQLEXPRESS;Database=Informa;Integrated Security=SSPI;persist security info=True;MultipleActiveResultSets=true;Encrypt=YES;TrustServerCertificate=TRUE"


DataContextFactory.cs: 
            optionsBuilder.UseSqlServer("Server=(localdb)\\SQLEXPRESS;Database=Informa;Integrated Security=SSPI;persist security info=True;MultipleActiveResultSets=true;Encrypt=YES;TrustServerCertificate=TRUE");

2 - Abrir a janela packge manager e executar os seguintes comandos:

dotnet tool install --global dotnet-ef

dotnet ef migrations add InitialCreate --project "C:\Projetos\TCC\InForma\InForma\Infra\Infra.csproj"

dotnet ef database update --project "C:\Projetos\TCC\InForma\InForma\Infra\Infra.csproj"