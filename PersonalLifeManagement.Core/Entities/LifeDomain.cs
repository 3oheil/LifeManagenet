namespace Domain.Entities
{
    public class LifeDomain : BaseEntity
    {
        public string Title { get; set; }
        public string? Color { get; set; }
        protected LifeDomain() { }

        public LifeDomain(string title, string? color)
        {
            Title = title;
            Color = color;
        }
    }
}
