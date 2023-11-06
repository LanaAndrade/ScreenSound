﻿class Episodio
{
    private List<string> convidados = new List<string>();
    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao}min) - Convidados: {String.Join(", ", convidados)}";
    public string Titulo { get; }

    public Episodio(string titulo, int ordem, int duracao)
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
    }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}