using Bot_Leilao.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bot_Leilao.Domain
{
    [Table("Leiloes")]
    public class Leilao : BaseEntity<string>
    {
        public Leilao()
        {
            Id = Guid.NewGuid().ToString();
        }

        public DateTime Data { get; set; }
        public int QuantidadeLotes { get; set; }
    }
}
