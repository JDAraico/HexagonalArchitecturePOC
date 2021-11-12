using System.ComponentModel.DataAnnotations;

namespace HexagonalArchTest.DomainApi
{
    public class BaseEntity<TKey>
    {
        [Key]
        public TKey Id { get; set; }
    }
}
