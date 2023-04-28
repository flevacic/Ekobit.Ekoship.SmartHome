using System.ComponentModel.DataAnnotations;

namespace Ekobit.Ekoship.SmartHome.Data.Models
{
    public class Device
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public float CurrentValue { get; set; }
        public DateTime LastUpdated { get; set; }
        public int DeviceTypeId { get; set; }
        public int UnitId { get; set; }
        public int HomeId { get; set; }

        public virtual DeviceType DeviceType { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual Home Home { get; set; }

    }
}
