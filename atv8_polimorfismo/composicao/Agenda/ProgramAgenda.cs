using composicao.Agenda;
using composicao.Agenda.Agenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composicao.Agenda
{
    public class ProgramAgenda
    {
        public static void Main()
        {
            Evento evento1 = new Evento("Evento1", new DateTime(2001, 1, 1, 0, 0, 0), "Local1");
            EventoPessoal eventoPessoal = new EventoPessoal(evento1, "João e Maria da Silva");
            eventoPessoal.MostrarDetalhes();

            Evento evento2 = new Evento("Evento2", new DateTime(2001, 1, 1, 0, 0, 0), "Local2");
            EventoProfissional eventoProfissional = new EventoProfissional(evento2, "Empresa1");
            eventoProfissional.MostrarDetalhes();

            Evento evento3 = new Evento("Evento3", new DateTime(2001, 1, 1, 0, 0, 0), "Local3");
            EventoSocial eventoSocial = new EventoSocial(evento3, "Vestimenta1");
            eventoSocial.MostrarDetalhes();
        }
    }
}
