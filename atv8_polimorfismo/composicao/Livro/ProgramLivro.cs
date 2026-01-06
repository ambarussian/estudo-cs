using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace composicao.Livro
{
    public class ProgramLivro
    {
        public static void Main()
        {
            Livro livro = new Livro(1, "Caim");
            Autor autor = new Autor(livro, 1, "Saramago");
            Categoria categoria = new Categoria(livro, "Ficção Histórica, Ficção Religiosa");
            autor.MostrarDetalhes();
            categoria.MostrarDetalhes();
        }
    }
}
