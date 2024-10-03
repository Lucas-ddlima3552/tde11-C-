using System.Security.AccessControl;

Carro carro1 = new Carro("Toyota", "Corolla",2013, 4);
carro1.Ligar();
carro1.abrirPortaMalas();
carro1.ExibirInformacoes();
carro1.Desligar();

Moto moto1 = new Moto("Honda", "Bis", 2013, true);
moto1.Ligar();
moto1.DarGrau();
moto1.ExibirInformacoes();
moto1.Desligar();


