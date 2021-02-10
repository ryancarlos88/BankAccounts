Para executar o projeto:

1. Clone o projeto desde repositório.
2. Abra a solution na raiz do projeto com o Visual Studio
3. Compile o projeto (para restaurar as dependências)
4. Crie um arquivo .mdf para ser usado como banco de dados localdb e o referencie na connectionString que está no arquivo appsettings.json (dentro do projeto Web).
5. Execute um Update-Database (pode ser no Package Manager Console) para rodar as migrations, criar a tabela e executar o seed.
6. Rode a aplicação (F5 para rodar com debug ou Ctrl+F5 para rodar sem)


No momento estou enviado apenas a api com o teste pois estou desenvolvendo o front ainda.
