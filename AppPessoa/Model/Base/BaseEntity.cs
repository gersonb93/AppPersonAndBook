using System.ComponentModel.DataAnnotations.Schema;

namespace AppPessoa.Model.Base
{
    public class BaseEntity
    {
        
        [Column("id")]
        public long Id { get; set; }
    }
}
