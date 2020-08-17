namespace LearnHub.Entities
{
    public class UserNotes:BaseEntity
    {
        public string Note { get; set; }
        public int EntityID { get; set; }
        public  EntityType EntityType { get; set; } 
    }
}