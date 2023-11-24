﻿using ExerciciosRefatoracao.Dominio;
using ExerciciosRefatoracao.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.UI
{
    public class CadastroPJ
    {
        ClienteRepository _repository;
        public CadastroPJ(ClienteRepository repository) { this._repository = repository; }
        public void Load()
        {
            {
                Cliente cli = new Cliente();

                Console.Write("Nº CNPJ: ");
                cli.CNPJ = Console.ReadLine();

                Console.Write("Razão Social: ");
                cli.Nome = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("********* Informe abaixo o Endereço de Cobrança **************");
                Console.Write("Logradouro: ");
                string logradouro = Console.ReadLine();
                Console.Write("Número: ");
                string numero = Console.ReadLine();
                Console.Write("Complemento: ");
                string complemento = Console.ReadLine();
                Console.Write("Bairro: ");
                string bairro = Console.ReadLine();
                Console.Write("CEP: ");
                string CEP = Console.ReadLine();
                Console.Write("Municipio: ");
                string municipio = Console.ReadLine();
                Console.Write("UF: ");
                string UF = Console.ReadLine();

                cli.SetEnderecoCobranca(logradouro, numero, complemento, bairro, CEP, municipio, UF);

                Console.WriteLine("");
                Console.WriteLine("********* Informe abaixo o Endereço de Entrega **************");

                Console.WriteLine("Logradouro: ");
                logradouro = Console.ReadLine();
                Console.Write("Número: ");
                numero = Console.ReadLine();
                Console.Write("Complemento: ");
                complemento = Console.ReadLine();
                Console.Write("Bairro: ");
                bairro = Console.ReadLine();
                Console.Write("CEP: ");
                CEP = Console.ReadLine();
                Console.Write("Municipio: ");
                municipio = Console.ReadLine();
                Console.Write("UF: ");
                UF = Console.ReadLine();

                cli.SetEnderecoEntrega(logradouro, numero, complemento, bairro, CEP, municipio, UF);

                Console.WriteLine("");
                Console.WriteLine("********* Informe abaixo o Endereço de Faturamento **************");
                Console.WriteLine("Logradouro: ");
                logradouro = Console.ReadLine();
                Console.Write("Número: ");
                numero = Console.ReadLine();
                Console.Write("Complemento: ");
                complemento = Console.ReadLine();
                Console.Write("Bairro: ");
                bairro = Console.ReadLine();
                Console.Write("CEP: ");
                CEP = Console.ReadLine();
                Console.Write("Municipio: ");
                municipio = Console.ReadLine();
                Console.Write("UF: ");
                UF = Console.ReadLine();

                cli.SetEnderecoFaturamento(logradouro, numero, complemento, bairro, CEP, municipio, UF);

                Console.WriteLine("Salvar Cliente (S/N)?");

                string op = Console.ReadLine();

                if (op.Equals("S"))
                {
                    _repository.Add(cli);
                    Console.WriteLine("Cadastro PJ salvo com sucesso !!");
                }

            }
        }
    }
}
