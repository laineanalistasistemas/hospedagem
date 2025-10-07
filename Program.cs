using SistemaHospedagem.Models;

Console.WriteLine("🏨 Bem-vindo ao Sistema de Hospedagem!");

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 120M);

Reserva reserva = new Reserva(diasReservados: 12);
reserva.CadastrarSuite(suite);

List<Pessoa> hospedes = new List<Pessoa>
{
    new Pessoa(nome: "Regilaine", sobrenome: "Souza"),
    new Pessoa(nome: "Daniel", sobrenome: "Ferreira")
};

reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"
Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total da reserva: R$ {reserva.CalcularValorDiaria():F2}");
