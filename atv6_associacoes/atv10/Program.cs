namespace atv10
{
    public class Paciente
    {
        public string Nome { get; set; }
        public string Doenca { get; set; }

        public Paciente(string nome, string doenca)
        {
            Nome = nome;
            Doenca = doenca;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Doença: {Doenca}";
        }
    }
    //---------------------------------------------------------------
    public class Hospital
    {
        private List<Paciente> pacientes;
        public Hospital()
        {
            pacientes = new List<Paciente>();
        }

        public void AdmitirPaciente(Paciente paciente)
        {
            pacientes.Add(paciente);
            Console.WriteLine($"Paciente admitido: {paciente}");
        }

        public void DarAltaPaciente(Paciente paciente)
        {
            if (pacientes.Remove(paciente))
            {
                Console.WriteLine($"Paciente recebeu alta: {paciente}");
            }
            else
            {
                Console.WriteLine("Paciente não encontrado no hospital.");
            }
        }

        public void ListarPacientes()
        {
            Console.WriteLine("Pacientes no hospital:");
            foreach (var paciente in pacientes)
            {
                Console.WriteLine(paciente);
            }
        }
    }
    //---------------------------------------------------------------
    public class Program
    {
        public static void Main()
        {
            Hospital hospital = new Hospital();

            Paciente paciente1 = new Paciente("Maria da Silva", "Gripe");
            Paciente paciente2 = new Paciente("João dos Santos", "Anemia");

            hospital.AdmitirPaciente(paciente1);
            hospital.AdmitirPaciente(paciente2);
            hospital.ListarPacientes();
            hospital.DarAltaPaciente(paciente1);
            hospital.ListarPacientes();
        }
    }
}