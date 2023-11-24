using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRefatoracao.Dominio
{
    public class Cliente
    {

        public string RazaoSocial { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public string CNPJ { get; set; }

        public string EndEntregaLogradouro { get; private set; }
        public string EndEntregaNumero { get; private set; }
        public string EndEntregaComplemento { get; private set; }
        public string EndEntregaBairro { get; private set; }
        public string EndEntregaCEP { get; private set; }
        public string EndEntregaMunicipio { get; private set; }
        public string EndEntregaUF { get; private set; }

        public string EndCobrancaLogradouro { get; private set; }
        public string EndCobrancaNumero { get; private set; }
        public string EndCobrancaComplemento { get; private set; }
        public string EndCobrancaBairro { get; private set; }
        public string EndCobrancaCEP { get; private set; }
        public string EndCobrancaMunicipio { get; private set; }
        public string EndCobrancaUF { get; private set; }

        public string EndFaturamentoLogradouro { get; private set; }
        public string EndFaturamentoNumero { get; private set; }
        public string EndFaturamentoComplemento { get; private set; }
        public string EndFaturamentoBairro { get; private set; }
        public string EndFaturamentoCEP { get; private set; }
        public string EndFaturamentoMunicipio { get; private set; }
        public string EndFaturamentoUF { get; private set; }

        public string GetTextoEnderecoCobranca()
        {
            return $"Endereço Cobrança: {EndCobrancaLogradouro} {EndCobrancaNumero} {EndCobrancaComplemento} - {EndCobrancaBairro} - CEP {EndCobrancaCEP} - {EndCobrancaMunicipio} - {EndCobrancaUF}";
        }

        public string GetTextoEnderecoEntrega()
        {
            return $"Endereço Entrega: {EndEntregaLogradouro} {EndEntregaNumero} {EndEntregaComplemento} - {EndEntregaBairro} - CEP {EndEntregaCEP} - {EndEntregaMunicipio} - {EndEntregaUF}";
        }

        public string GetTextoEnderecoFaturamento()
        {
            return $"Endereço Faturamento: {EndFaturamentoLogradouro} {EndFaturamentoNumero} {EndFaturamentoComplemento} - {EndFaturamentoBairro} - CEP {EndFaturamentoCEP} - {EndFaturamentoMunicipio} - {EndFaturamentoUF}";
        }


        public void SetEnderecoFaturamento(string endFaturamentoLogradouro, string endFaturamentoNumero, string endFaturamentoComplemento, string endFaturamentoBairro, string endFaturamentoCEP, string endFaturamentoMunicipio, string endFaturamentoUF)
        {
            EndFaturamentoLogradouro = endFaturamentoLogradouro;
            EndFaturamentoNumero = endFaturamentoNumero;
            EndFaturamentoComplemento = endFaturamentoComplemento;
            EndFaturamentoBairro = endFaturamentoBairro;
            EndFaturamentoCEP = endFaturamentoCEP;
            EndFaturamentoMunicipio = endFaturamentoMunicipio;
            EndFaturamentoUF = endFaturamentoUF;
        }

        public void SetEnderecoEntrega(string endEntregaLogradouro, string endEntregaNumero, string endEntregaComplemento, string endEntregaBairro, string endEntregaCEP, string endEntregaMunicipio, string endEntregaUF)
        {
            EndEntregaLogradouro = endEntregaLogradouro;
            EndEntregaNumero = endEntregaNumero;
            EndEntregaComplemento = endEntregaComplemento;
            EndEntregaBairro = endEntregaBairro;
            EndEntregaCEP = endEntregaCEP;
            EndEntregaMunicipio = endEntregaMunicipio;
            EndEntregaUF = endEntregaUF;
        }

        public void SetEnderecoCobranca(string endCobrancaLogradouro, string endCobrancaNumero, string endCobrancaComplemento, string endCobrancaBairro, string endCobrancaCEP, string endCobrancaMunicipio, string endCobrancaUF)
        {
            EndCobrancaLogradouro = endCobrancaLogradouro;
            EndCobrancaNumero = endCobrancaNumero;
            EndCobrancaComplemento = endCobrancaComplemento;
            EndCobrancaBairro = endCobrancaBairro;
            EndCobrancaCEP = endCobrancaCEP;
            EndCobrancaMunicipio = endCobrancaMunicipio;
            EndCobrancaUF = endCobrancaUF;
        }


        public override string ToString()
        {
            return "===Dados do Cliente===\n" +
                   $"CPF: {this.CPF}\n" +
                   $"Nome: {this.Nome}\n" +
                   $"{this.GetTextoEnderecoCobranca()}\n"  +
                   $"{this.GetTextoEnderecoEntrega()}\n" +
                   $"{this.GetTextoEnderecoFaturamento()}";
        }

    }
    
}
