namespace QuestaoUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new(1, "Pafuncio", "00012345678", "2577798", "Ciência da Computação", 3);
            Professor professor = new(1, "Angonese", "11111111111", 12500, "DACOM");
            FuncionarioAdministrativo funcionarioAdministrativo = new(1, "Agripino", "938289890", 3000, "NUAPE");

            aluno.MostrarDetalhes();
            professor.MostrarDetalhes();
            funcionarioAdministrativo.MostrarDetalhes();
        }
    }
}
