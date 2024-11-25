namespace WorkerServer.Core.Entities;

public class AtualizacaoLog
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string LojaId { get; set; }
    public string PDVId { get; set; }
    public string Versao { get; set; }
    public string Status { get; set; }
    public DateTime DataHora { get; set; }
}
