namespace GmaoAssetManager.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string SerialNumber { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty; 
        public string Location { get; set; } = string.Empty;
        public EquipmentStatus Status { get; set; }
        public DateTime LastMaintained { get; set; }
        public DateTime NextMaintenanceDate { get; set; }
    }

    public enum EquipmentStatus
    {
        Active,       
        UnderRepair,  
        Maintenance,  
        Retired       
    }
}