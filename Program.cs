﻿// See https://aka.ms/new-console-template for more information
using DesafioFundamentos.Models;
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento. \n" +
"Digite o preço de partida do estacionamento:");
precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);


// MENU
bool exibirMenu = true;

while (exibirMenu) {
    Console.Clear();
    opcaoMenu();
    switch(Console.ReadLine()){
        case "1":
            es.AdicionarVeiculos();
            break;
        case "2":
            es.RemoverVeiculo();
            break;
        case "3":
            es.ListarVeiculos();
            break;
        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    };
  Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
};

Console.WriteLine("O programa se encerrou");

void opcaoMenu(){
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");
}