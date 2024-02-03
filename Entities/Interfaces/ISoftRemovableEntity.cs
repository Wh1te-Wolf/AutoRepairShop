namespace AutoRepairShop.Entities.Interfaces
{
    public interface ISoftRemovableEntity : IEntity
    {
        public bool Removed { get; set; }
    }
}
