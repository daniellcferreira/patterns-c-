using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ada.DesignPatterns.Criacionais.Prototype
{
    public interface ICloneable
    {
        ICloneable Clone();
    }

    // Classe concreta Documento
    public class Documento : ICloneable
    {
        public string Titulo { get; set; }
        public string Conteudo { get; set; }

        public Documento(string titulo, string conteudo)
        {
            Titulo = titulo;
            Conteudo = conteudo;
        }

        // Implementando o método Clone
        public ICloneable Clone()
        {
            return new Documento(Titulo, Conteudo);
        }

        public void Print()
        {
            Console.WriteLine($"Titulo: {Titulo}\nConteudo: {Conteudo}");
        }
    }
}