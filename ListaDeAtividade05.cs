﻿/*
 * Usuário: Kenia Teixeira
 * Data: 01/02/2025
 * Hora: 10:32
*/
 
using System;
namespace ListaAtividade05{
	class ListaDeAtividade{
		public static void Main(string[] args){
			int sair = 1;
			
			while(sair == 1){
			Console.WriteLine(" \n\n ------ LISTA 05 ------- \nEscolha a atividade: A - B - C - D - E - F - G - H - I - J \n   PRESIONE S PARA SAIR");
			char x = Convert.ToChar(Console.ReadLine());
			char escolha = char.ToLower(x);
			switch(escolha){
					case 'a':
                    /*Verifique se um número é par ou ímpar.*/
						questaoA();
					break;
					
					case 'b':
                    /*Encontre o maior entre dois números.*/
						questaoB();
						break;
					
					case 'c':
					/*Verifique se uma lista está vazia.*/
                    	questaoC();
						break;
					
					case 'd':
					/*Verifique se uma string está vazia.*/
                    	questaoD();
						break;
						
					case 'e':
                    /*Verifique se uma condição é verdadeira.*/
						questaoE();
						break;
					case 'f':
					/*Calcule o valor absoluto de um número.*/	
                        questaoF();
						break;
						
					case 'g':
					/*Verifique se um número é positivo, negativo ou zero.*/	
                        questaoG();
						break;
						
					case 'h':
					/*Converta uma string em um número.*/	
                        questaoH();
						break;
						
					case 'i':
					/*Verifique se um número é divisível por outro.*/	
                        questaoI();
						break;
						
					case 'j':
					/*Verifique se uma variável é nula ou não.*/	
                        questaoJ();
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
				Console.WriteLine(" -------- QUESTAO A --------");
                Console.Write("Digite um numero: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x%2==0 ? "Par": "Impar" );
			}
		
			static void questaoB(){
				Console.WriteLine(" -------- QUESTAO B --------");
                Console.Write("Digite o primeiro numero: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o segundo numero: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x>y ? x + " maior que " + y :  y + " maior que " + x);
			}
			
			static void questaoC(){
				Console.WriteLine(" -------- QUESTAO C --------");
                List<int> numeros = new List<int>();

                Console.WriteLine("Deseja adicionar um numero na lista? (Sim ou Nao)\n");
                string opcao = Console.ReadLine();

                while(opcao.ToLower() == "sim"){
                    Console.Write("Digite um valor: ");
                    numeros.Add(Convert.ToInt32(Console.ReadLine()));

                    Console.WriteLine("Deseja adicionar mais valores? ");
                    opcao = Console.ReadLine();
                }

                Console.WriteLine(numeros.Count == 0 ? "Lista vazia" : "Lista NAO esta vazia");
			}
			
			static void questaoD(){
				Console.WriteLine(" -------- QUESTAO D --------");
                Console.Write("Digite uma palavra: ");
                string palavra = Console.ReadLine();
                Console.WriteLine(palavra == ""? "String vazia" : "String nao esta vazia");
			}
			
			static void questaoE(){
				Console.WriteLine(" -------- QUESTAO E --------");
                Console.Write("Digite true para verdadeiro \nDigite false para falso: ");
                bool verifica = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine(verifica ? "Verdadeiro" : "Falso");
			}
			
			static void questaoF(){
				Console.WriteLine(" -------- QUESTAO F --------");
                Console.Write("Digite um valor: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(x < 0 ? Math.Abs(x) : x);
			}
		
			static void questaoG(){
				Console.WriteLine(" -------- QUESTAO G --------");
                Console.Write("Digite um valor: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(x == 0 ? "Zero" : (x < 0 ? "Negativo" : "Positivo"));
			}
		
			static void questaoH(){
				Console.WriteLine(" -------- QUESTAO H --------");
                Console.Write("Digite valores numericos: ");
                string transformar = Console.ReadLine();
                int numero = transformar.All(char.IsDigit)? Convert.ToInt32(transformar) : -1;
                Console.WriteLine(numero != -1 ? "Valor digitado: " + numero : "O valor digitado não é numerico");
			}
		
			static void questaoI(){
				Console.WriteLine(" -------- QUESTAO I --------");
				Console.Write("Digite o primeiro valor: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(x%y == 0 ? "E divisivel" : "Nao é divisivel");
			}
		
			static void questaoJ(){
				Console.WriteLine(" -------- QUESTAO J --------");
                string valorNulo = null;

                Console.WriteLine(string.IsNullOrEmpty(valorNulo) ? "Valor nulo" : "Nao é nula");
			}

	}
}