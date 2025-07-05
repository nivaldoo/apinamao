# API na mão

Minimal API com o mínimo de arquivos.

## Tecnologias Utilizadas

- .NET 8

## Pré-requisitos

Antes de rodar o projeto, tenha certeza de que você tem as seguintes ferramentas instaladas:

- [.NET SDK](https://dotnet.microsoft.com/download)

## Como Rodar o Projeto

1. **Clone o repositório**
   ```bash
   git clone https://github.com/nivaldoo/apinamao

2. **Abra um prompt e execute (pode ser cmd ou powershell)**
   ```bash
   cd apinamao
   ```
   ```bash
   dotnet run
   ```
3. **Abra outro prompt**
   ```bash
   curl http://localhost:5000 -v
   ```
   ```bash
   curl http://localhost:5000 -H "Content-Type: application/json" -d "\"Teste"\" -v
   ```