# Sistema de Estacionamento

Este projeto é um sistema de estacionamento desenvolvido em C#. Foi proposto como desafio de projeto no Bootcamp da [DIO](https://www.dio.me/) em parceria com a XP Inc. Ele fornece uma interface de linha de comando para gerenciar veículos em um estacionamento, permitindo o cadastro, remoção e listagem de veículos, além de calcular o valor total do estacionamento com base nas horas de permanência.

## Funcionalidades

- **Configuração Inicial**: O usuário define o preço inicial e o preço por hora do estacionamento.
- **Menu Principal**: 
  - **Cadastrar Veículo**: Adiciona um veículo ao estacionamento com base na placa fornecida.
  - **Remover Veículo**: Remove um veículo e calcula o custo total com base nas horas de estacionamento.
  - **Listar Veículos**: Mostra todas as placas dos veículos atualmente no estacionamento.
  - **Encerrar**: Fecha o programa.

## Como Usar

1. **Execute o Programa**: Inicie o programa no ambiente de desenvolvimento ou na linha de comando.
2. **Configuração Inicial**:
   - Insira o preço inicial do estacionamento.
   - Insira o preço por hora.
3. **Interação com o Menu**:
   - **Cadastrar Veículo**: Insira a placa do veículo no formato `XXX-XXX` para adicionar um novo veículo.
   - **Remover Veículo**: Insira a placa do veículo para removê-lo. O programa calculará o valor total a ser pago.
   - **Listar Veículos**: Visualize todas as placas dos veículos cadastrados no estacionamento.
   - **Encerrar**: Finaliza a execução do programa.

## Estrutura do Código

- **Programa Principal**: 
  - Gerencia a interação com o usuário e exibe um menu com opções.
  - Chama as funções apropriadas para adicionar, remover ou listar veículos, ou encerra o programa.

- **Classe de Estacionamento**: 
  - Contém métodos para adicionar, remover e listar veículos.
  - Calcula o valor do estacionamento com base nas horas de permanência e no preço definido.

## Requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) para compilar e executar o código.

## Contribuições

Contribuições são bem-vindas! Para contribuir, obter mais informações ou fornecer feedback, sinta-se à vontade para entrar em contato pelo LinkedIn: [Wilson Lemos](https://www.linkedin.com/in/wil-lemos)

