﻿/*
 * Criado por SharpDevelop.
 * Usuário: Kenia Teixeira
 * Data: 03/02/2025
 * Hora: 07:55
*/
using System;
namespace ListaAtividade04{
	class ListaDeAtividade{
		public static void Main(string[] args){
			int sair = 1;
			
			while(sair == 1){
			Console.WriteLine("\n\n ------ LISTA 04 ------- \nEscolha a atividade: \nA - B - C - D - E - F - G - H \nI - J - K - L - M - N - O \n   PRESIONE S PARA SAIR");
			char x = Convert.ToChar(Console.ReadLine());
			char escolha = char.ToLower(x);
			switch(escolha){
					case 'a':
					/*Escreva um programa que pergunte ao usuário sua idade e se tem carteira de
					motorista. Se o usuário tiver mais de 18 anos e possuir carteira de motorista,
					o programa deve imprimir "Você pode dirigir".*/
						questaoA();
					break;
					
					case 'b':
					/*Escreva um programa que pergunte ao usuário se ele deseja comprar um
					carro novo e se tem dinheiro suficiente para isso. Se o usuário quiser
					comprar um carro novo e tiver dinheiro suficiente, o programa deve
					imprimir "Parabéns, você pode comprar um carro novo!"*/
						questaoB();
						break;
					
					case 'c':
					/*Escreva um programa que pergunte ao usuário se ele possui um diploma de
					ensino superior e se tem mais de 21 anos. Se o usuário possuir um diploma
					de ensino superior e tiver mais de 21 anos, o programa deve imprimir
					"Parabéns, você está qualificado para a vaga!".*/
						questaoC();
						break;
					
					case 'd':
					/*Escreva um programa que pergunte ao usuário se ele é assinante de um
					serviço de streaming e se já assistiu a uma série específica. Se o usuário for
					assinante e já tiver assistido à série, o programa deve imprimir "Ótimo, agora
					você pode assistir à nova temporada!".*/
						questaoD();
						break;
						
					case 'e':
					/*Escreva um programa que solicite ao usuário o seu nome e idade. O
					programa deve verificar se o nome possui mais de 3 caracteres e se a idade é
					maior ou igual a 18 anos. Se ambas as condições forem verdadeiras, o
					programa deve imprimir "Acesso permitido". Caso contrário, deve imprimir "Acesso negado".*/
						questaoE();
						break;
					case 'f':
					/*Escreva um programa que pergunte ao usuário se ele deseja adicionar açúcar
					ou leite ao seu café. Se o usuário responder que deseja adicionar açúcar OU
					leite, o programa deve imprimir a mensagem "Café com adicional preparado!"*/
						questaoF();
						break;
						
					case 'g':
					/*Crie um programa que solicite ao usuário um número inteiro e verifique se
					ele é divisível por 3 OU por 5. Se o número for divisível por 3 OU por 5, o
					programa deve imprimir a mensagem "O número é divisível por 3 ou por 5!"*/
						questaoG();
						break;
						
					case 'h':
					/*Escreva um programa que pergunte ao usuário se ele deseja comprar um
					produto. Se o usuário responder "sim" OU "s", o programa deve imprimir a
					mensagem "Obrigado pela compra!"..*/
						questaoH();
						break;
						
					case 'i':
					/*Crie um programa que solicite ao usuário o seu nome e verifique se ele é
					igual a "Wilson" OU "Gloria". Se o nome for igual a "Wilson" OU "Gloria",
					o programa deve imprimir a mensagem "Olá, bem-vindo(a) de volta!"..*/
						questaoI();
						break;
						
					case 'j':
					/*Escreva um programa que solicite ao usuário um número inteiro e verifique
					se ele é maior do que 10 OU menor do que 0. Se o número for maior do que
					10 OU menor do que 0, o programa deve imprimir a mensagem "Número
					inválido!".*/
						questaoJ();
						break;
						
					case 'k':
					/*Escreva um programa que pergunte ao usuário se ele não é um robô. Se a
					resposta for negativa, o programa deve imprimir "Por favor, prove que você
					não é um robô".*/
						questaoK();
						break;
					
					case 'l':
					/*Crie um programa que peça ao usuário para digitar um número e verifique se
					ele não é igual a zero. Se a condição for verdadeira, o programa deve
					imprimir "O número é diferente de zero".*/
						questaoL();
						break;
						
					case 'm':
					/*Escreva um programa que pergunte ao usuário se ele não é um membro
					inativo de um clube. Se a resposta for negativa, o programa deve imprimir
					"Por favor, atualize sua inscrição para continuar usufruindo dos benefícios
					do clube".*/
						questaoM();
						break;
						
					case 'n':
					/*Crie um programa que peça ao usuário para digitar uma palavra e verifique
					se ela não é vazia. Se a condição for verdadeira, o programa deve imprimir
					"A palavra não é vazia"*/
						questaoN();
						break;
						
					case 'o':
					/*Escreva um programa que pergunte ao usuário se ele não deseja cancelar
					uma operação. Se a resposta for negativa, o programa deve imprimir "Por
					favor, confirme o cancelamento da operação".*/
						questaoO();
						break;
						
					case 's':
					sair = 0;
					break;
					
					default:
						Console.WriteLine("Opção Invalida!!");
					break;
					}	
			}
			
			Console.Write("Precione qualquer tecla para continuar . . . ");
			Console.ReadKey(true);
		}
		
			static void questaoA(){
				Console.WriteLine("\n ------- QUESTAO A ------- \n");
				Console.Write("Quantos anos você tem? (Responda com sim ou nao): ");
				int idade = Convert.ToInt32(Console.ReadLine());
				Console.Write("Você tem carteira de motorista? (Responda com sim ou nao): ");
				string dirige = Console.ReadLine();
				if(idade >= 18 && dirige.ToLower() == "sim"){
					Console.WriteLine("Voce pode dirigir!");
				}else{
					Console.WriteLine("Voce não pode dirigir!");
				}
			
			}
		
			static void questaoB(){
				Console.WriteLine(" \n------- QUESTAO B ------- \n");
				Console.Write("Você deseja comprar um carro novo? (Responda com sim ou nao): ");
				string comprarCarro = Console.ReadLine();
				Console.Write("Você tem dinheiro suficiente? (Responda com sim ou nao): ");
				string dinheiro = Console.ReadLine();
				if(comprarCarro.ToLower() == "sim" && dinheiro.ToLower() == "sim"){
					Console.WriteLine("Parabéns! você pode comprar um carro novo");
				}

			}
			
			static void questaoC(){
				Console.WriteLine(" \n------- QUESTAO C ------- \n");
				Console.Write("Voce possui diploma de ensino superior? (Responda com sim ou nao): ");
				string diploma = Console.ReadLine();
				Console.Write("Quantos anos voce tem? ");
				int idade = Convert.ToInt32(Console.ReadLine());
				if(diploma.ToLower() == "sim" && idade >= 21){
					Console.WriteLine("Parabéns, você esta qualificado para a vaga!");
				}
			}
			
			static void questaoD(){
				Console.WriteLine(" \n------- QUESTAO D ------- \n");
				Console.Write("Você é assinante? (Responda com sim ou nao): ");
				string assinatura = Console.ReadLine();
				Console.Write("Você ja assistiu a série 'Loki'? (Responda com sim ou nao): ");
				string serie = Console.ReadLine();
				if(assinatura.ToLower() == "sim" && serie.ToLower() == "sim"){
					Console.WriteLine("Ótimo, agora você pode assistir à nova temporada!");
				}
			}
			
			static void questaoE(){
				Console.WriteLine(" \n------- QUESTAO E ------- \n");
				Console.Write("Digite seu nome: ");
				string nome = Console.ReadLine();
				Console.Write("Quantos anos voce tem? ");
				int idade = Convert.ToInt32(Console.ReadLine());
				if(nome.Length > 3 && idade >= 18){
					Console.WriteLine("Acesso permitido!");
				}else{
					Console.WriteLine("Acesso negado");
				}
			}
			
			static void questaoF(){
				Console.WriteLine(" \n------- QUESTAO F ------- \n");
				Console.Write("Você deseja adicionar açucar ou leite no seu café? ");
				string adicional = Console.ReadLine();
				if(adicional.ToLower() == "acucar" || adicional.ToLower() == "açucar" || adicional.ToLower() == "leite"){
					Console.WriteLine("Café com adicional preparado!");
				}
			}
		
			static void questaoG(){
				Console.WriteLine(" \n------- QUESTAO G ------- \n");
				Console.Write("Digite um numero: ");
				int x = Convert.ToInt32(Console.ReadLine());
				if(x % 3 == 0 || x % 5 == 0){
					Console.WriteLine("É divisivel por 3 ou por 5");
				}else {
					Console.WriteLine("Nao é divisivel por 3 ou por 5");
				}
			}
		
			static void questaoH(){
				Console.WriteLine(" \n------- QUESTAO H ------- \n");
				Console.WriteLine("Você deseja comprar um produto? ");
				string desejo = Console.ReadLine();
				if(desejo.ToLower() == "sim" || desejo.ToLower() == "s"){
					Console.WriteLine("Obrigada pela compra!");
				}
			}
		
			static void questaoI(){
				Console.WriteLine(" \n------- QUESTAO I ------- \n");
				Console.Write("Digite seu nome: ");
				string nome = Console.ReadLine();
				if(nome.ToLower() == "wilson" || nome.ToLower() == "gloria"){
					Console.WriteLine("Olá, bem-vindo(a) de volta!!");
				}
			}
		
			static void questaoJ(){
				Console.WriteLine(" \n------- QUESTAO J ------- \n");
				Console.Write("Digite um valor: ");
				int x = Convert.ToInt32(Console.ReadLine());
				if(x > 10 || x < 0){
					Console.WriteLine("Número inválido");
				}	
			}
		
			static void questaoK(){
				Console.WriteLine(" \n------- QUESTAO K ------- \n");
				Console.Write("Você é um robô ? ");
				string verifica = Console.ReadLine();
				if(verifica.ToLower() == "nao" || verifica.ToLower() == "não"){
					Console.WriteLine("Por favor, Prover que você não é um robô");
				}
			}
		
			static void questaoL(){
				Console.WriteLine(" \n------- QUESTAO L ------- \n");
				Console.Write("Digite um numero: ");
				int x = Convert.ToInt32(Console.ReadLine());
				if(x != 0){
					Console.WriteLine("O número é diferente de zero!");
				}

			}
		
			static void questaoM(){
				Console.WriteLine(" \n------- QUESTAO M ------- \n");
				Console.Write("Você não é um membro inativo? ");
				string verifica = Console.ReadLine();
				if(verifica.ToLower() == "nao" || verifica.ToLower() == "não"){
					Console.WriteLine("Por favor, atualize sua inscrição para continuar usufruindo dos benefícios do clube");
				}
			}
		
			static void questaoN(){
				Console.WriteLine(" \n------- QUESTAO N ------- \n");
				Console.Write("Digite uma palavra: ");
				string verifica = Console.ReadLine();
				if(verifica != ""){
					Console.WriteLine("A palavra não é vazia");
				}
			}
		
			static void questaoO(){
				Console.WriteLine(" \n------- QUESTAO O ------- \n");
				Console.Write("Você deseja cancelar a operação? ");
				string verifica = Console.ReadLine();
				if(verifica.ToLower() == "nao" || verifica.ToLower() == "não"){
					Console.WriteLine("Por favor, confirme o cancelamento da operação");
				}	
			}
	}
}