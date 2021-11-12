
namespace HexagonalArchTest.DomainApi.Model
{
    public class Organization : BaseEntity<int>
    {
        public string Name { get; set; }
        public string State { get; set; }
        public int NCESID { get; set; }
        public int UID { get; set; }
        public int SiteCode { get; set; }
        public string Status { get; set; }
    }
}
