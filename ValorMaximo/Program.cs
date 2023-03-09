int voto = 0;

int votantes = 0;

int candidatos = 0;

List<int> votosAcomulados = new List<int>();

Console.WriteLine("Dame el numero de candidatos");

candidatos = int.Parse(Console.ReadLine());

Console.WriteLine("Dame el numero de votantes");

votantes = int.Parse(Console.ReadLine());

for (int i = 0; i < votantes; i++)

{

    Console.WriteLine("¿Porque candidato vas a votar?");

    voto = int.Parse(Console.ReadLine());



    votosAcomulados.Add(voto);

}

for (int i = 1; i <= candidatos; i++)

{

    Console.WriteLine("votos para el candidato  " + i + " tiene " + votosAcomulados.Where(x => x == i).Count());

}

Console.ReadLine();