# TesteCervantes
Este projeto é uma aplicação desktop desenvolvida com C# (Windows Forms) conectada a um banco de dados PostgreSQL. A aplicação permite realizar operações de cadastro, edição, exclusão e listagem de registros(CRUD). 

### Criação das tabelas
- Verifique se você possui o PostgreSQL instalado na sua máquina.
- Conecte-se ao banco de dados pelo PgAdmin ou terminal.
- Execute o arquivo `cadastro_db.sql` para criação das tabelas:

```bash
psql -U seu_usuario -d seu_banco_de_dados -a -f cadastro_db.sql
```

## Como usar

1. Clone este repositório.
2. Abra o projeto no Visual Studio.
3. Atualize a `connectionString` com os dados do seu banco.
4. Compile e execute a aplicação.
