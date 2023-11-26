Console.WriteLine("Digite o número de pessoas votantes:");

int A = 0, B = 0, C = 0, vontantes = 0;

vontantes = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < vontantes; i++){
Console.WriteLine("Escolha um cadidato: A, B ou C");

    string voto = Console.ReadLine();
    switch (voto){
        case "A":
        A+=1;
        break;
        case "B":
        B+=1;
        break;
        case "C":
        C+=1;
        break;

        default:
        Console.WriteLine("Nenhum cadidado encontrado!");
        break;
    }

}
Console.WriteLine($"Resultado -  A:{A}  B:{B}  e   C:{C}");

if (A>B && A>C){
    Console.WriteLine("*****  O Candidato A é o vencedor!  ******");
}
else if (B>A && B>C){
    Console.WriteLine("*****  O Candidato B é o vencedor!  ******");
}
else{
    Console.WriteLine("*****  O Candidato C é o vencedor!  ******");
}
