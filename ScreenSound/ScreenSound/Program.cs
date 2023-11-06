/*
Musica musica1 = new Musica();
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 270;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;
Console.WriteLine(musica2.Disponivel);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
*/

/*
Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();

/*
Podcast podcast1 = new Podcast("Uso de classes no C#", "Lana Andrade")
{

};

podcast1.ExibirDetalhes();
*/


Episodio ep1 = new("Uso de classes no C#", 1, 45);
ep1.AdicionarConvidados("Jonny Greenwood");
ep1.AdicionarConvidados("Ed O'brien");

Episodio ep2 = new("Interpolação no C#", 2, 23);
ep2.AdicionarConvidados("Thom Yorke");

Podcast podcast = new Podcast("Aperfeiçoando o C#", "Lana Andrade");
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep1);
podcast.ExibirDetalhes();