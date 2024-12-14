namespace Screensound.Modelos;

internal class Avaliacao {
    public Avaliacao(int nota)
    {
        Nota = nota;
    }
    public int Nota { get; }
    public static Avaliacao Parse(string text)
    {
       int nota = int.Parse(text);
       return new Avaliacao(nota);
    }
}