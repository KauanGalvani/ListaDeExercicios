while (true)
{
    

    
    string? devContinuar = Console.ReadLine(); 

    if (devContinuar?.ToUpper() == "Y")
    {
        continue;
    }
    else
    {
        Console.WriteLine("Seu programa será finalzado, Pressione ENTER para fechar a pagina");
        break;
    }
}