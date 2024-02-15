
namespace Web.Api.Domain.Entities
{
    public class PickupDTO
    {
        public int NumberId { get; set; }
        public string Location { get; set; }
        public string Tipevehicle { get; set; }
        public DateTime Dateini { get; set; }
        public DateTime Datend { get; set; }
    }
}
