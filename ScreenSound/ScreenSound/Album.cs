class Album
{
    private List<Musica> musicas = new List<Musica>();
    public String Nome { get; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public Album(string nome)
    {
        Nome = nome;
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"\nMúsicas do álbum {Nome}\n");

        foreach (var musica in musicas)
        {
            Console.WriteLine($"Músicas: {musica.Nome}");
        }

        Console.WriteLine($"\nPara ouvir esse álbum inteiro você precisa de {DuracaoTotal} segundos.\n");

    }
}