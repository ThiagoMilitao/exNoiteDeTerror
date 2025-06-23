string[] mesNome = {
    "O Zumbi",        // Janeiro
    "O Assassino",    // Fevereiro
    "O Psicopata",    // Março
    "O Alienígena",   // Abril
    "O Carniceiro",   // Maio
    "O Matador",      // Junho
    "O Vampiro",      // Julho
    "O Maluco",       // Agosto
    "O Vingador",     // Setembro
    "O Monstro",      // Outubro
    "O Bruxo",        // Novembro
    "O Demônio"       // Dezembro
};

string[] diaNome = {
    "Endiabrado",      // 1
    "Radioativo",      // 2
    "Endemoniado",     // 3
    "Vermelho",        // 4
    "Possuído",        // 5
    "Macabro",         // 6
    "Sombrio",         // 7
    "Sem Cabeça",      // 8
    "Desconhecido",    // 9
    "Inconsciente",    // 10
    "Oculto",          // 11
    "Esquecido",       // 12
    "Lúgubre",         // 13
    "Invocado",        // 14
    "Caído",           // 15
    "Costurado",       // 16
    "Amaldiçoado",     // 17
    "Anormal",         // 18
    "Perturbado",      // 19
    "Sanguinário",     // 20
    "Tenebroso",       // 21
    "Imortal",         // 22
    "Ressuscitado",    // 23
    "do Pântano",      // 24
    "da Encruzilhada", // 25
    "do Porão",        // 26
    "do Velho Poço",   // 27
    "sem Perdão",      // 28
    "do Cemitério",    // 29
    "da Meia-Noite",   // 30
    "da Lua Cheia"     // 31
};


string dNome, mNome;
Console.WriteLine("--- Noite de Terror ---");

int dia;
while (true)
{
    Console.Write("Qual o dia de nascimento da vítima (1 a 31): ");
    if (int.TryParse(Console.ReadLine(), out dia) && dia >= 1 && dia <= 31)
        break;
    Console.WriteLine("Dia inválido. Tente novamente.");
}

int mes;
while (true)
{
    Console.Write("Qual o mês de nascimento da vítima (1 a 12): ");
    if (int.TryParse(Console.ReadLine(), out mes) && mes >= 1 && mes <= 12)
        break;
    Console.WriteLine("Mês inválido. Tente novamente.");
}

dNome = diaNome[dia - 1];
mNome = mesNome[mes - 1];

Console.WriteLine();
Console.Write($"Cuidado com o {mNome} {dNome}!");