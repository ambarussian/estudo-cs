using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composicao.Agenda
{
    namespace Agenda
    {
        public class Evento(string titulo, DateTime data, string local)
        {
            public string Titulo { get; set; } = titulo;
            public DateTime Data { get; set; } = data;
            public string Local { get; set; } = local;

            public virtual void MostrarDetalhes()
            {
                Console.WriteLine($"Evento: {Titulo}");
                Console.WriteLine($"Data: {Data}, em {Local}");
            }
        }
    }
}
