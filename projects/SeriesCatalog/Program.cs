using SeriesCatalog.Classes;

SeriesRepository repo = new SeriesRepository();

Console.WriteLine("Seja bem vindo ao catálogo de séries, a Netflix versão CLI :)");

string UserResponse = UserInput().ToUpper();

while(UserResponse != "X")
{
    switch (UserResponse)
    {
        case "1":

            Console.WriteLine("\nAdicionar série \n");
            Console.WriteLine("Informe a avaliação da nova série: ");
            double RatingAdd = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Informe o título da nova série: ");
            string TitleAdd = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Informe o gênero da nova série: ");
            string GenreAdd = Console.ReadLine();
            Console.WriteLine();

            Series ToAdd = new Series(id: repo.ViewList().Count(), RatingAdd, TitleAdd, GenreAdd);
            repo.AddSeries(ToAdd);
            break;

        case "2":

            Console.WriteLine("Remover série \n");
            Console.WriteLine("Informe o Id da série a ser removida: ");
            int IdRemove = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            repo.RemoveSeriesById(IdRemove);
            Console.WriteLine("Série removida com sucesso");
            break;

        case "3":

            Console.WriteLine("Obter informações sobre a série \n");
            Console.WriteLine("Informe o Id da série a ser visualizada: ");
            int IdView = int.Parse(Console.ReadLine());

            Console.WriteLine(repo.GetSeriesById(IdView).Stringify());
            break;

        case "4":

            Console.WriteLine("Atualizar série \n");
            Console.WriteLine("Informe o Id da série a ser atualizada: ");
            int IdUpdate = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Informe a nova avaliação da série: ");
            double RatingUpdate = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Informe o novo título da série: ");
            string TitleUpdate = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Informe o novo gênero da série: ");
            string GenreUpdate = Console.ReadLine();
            Console.WriteLine();

            Series ToUpdate = new Series(id: IdUpdate,RatingUpdate, TitleUpdate, GenreUpdate);

            repo.UpdateSeries(IdUpdate, ToUpdate);
            break;

        case "5":

            foreach (Series series in repo.ViewList())
            {
                if(!series.GetDeletedBool())
                {
                    Console.WriteLine(series.Stringify());
                }
            }
            break;

        case "CLS":

            Console.Clear();
            break;

        default:

            throw new ArgumentOutOfRangeException("\n Opção inválida");
    }

    UserResponse = UserInput();
}

string UserInput()
		{
            string PromptUser = @"
            Digite a função que deseja executar:

            1-    Adicionar série
            2-    Remover série
            3-    Obter informações sobre a série
            4-    Atualizar série
            5-    Ver lista das séries
            cls - Limpar Tela
            X -   Sair
            ";

			Console.WriteLine(PromptUser);
			string opcaoUsuario = Console.ReadLine().ToUpper();
			return opcaoUsuario;
		}