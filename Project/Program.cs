// Nome de funções em PascalCase
void MensagemDeBoasVindas()
{
    Console.WriteLine(@"
╔═══╗─────────────╔═══╗──────────╔╗
║╔═╗║─────────────║╔═╗║──────────║║
║╚══╦══╦═╦══╦══╦═╗║╚══╦══╦╗╔╦═╗╔═╝║
╚══╗║╔═╣╔╣║═╣║═╣╔╗╬══╗║╔╗║║║║╔╗╣╔╗║
║╚═╝║╚═╣║║║═╣║═╣║║║╚═╝║╚╝║╚╝║║║║╚╝║
╚═══╩══╩╝╚══╩══╩╝╚╩═══╩══╩══╩╝╚╩══╝");
} // @: Verbatim Literal

void OpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para listar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a avaliação de uma banda");
    Console.WriteLine("Digite -1 para sair");
}

MensagemDeBoasVindas();
OpcoesDoMenu();