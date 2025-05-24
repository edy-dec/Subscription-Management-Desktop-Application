using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Serializable]
public class Abonament
{
    public string TipAbonament { get; set; }
    public string TipPachet { get; set; }
    public string Revista { get; set; }
    public string Status { get; set; }
    public DateTime DataStart { get; set; }
    public DateTime DataEnd { get; set; }
    public int OrderId { get; set; }
    public DateTime DataOrder { get; set; }
    public string DinImport { get; set; }
    public int UserId { get; set; }
}

