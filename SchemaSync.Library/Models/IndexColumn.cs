namespace SchemaSync.Library.Models
{
    public class IndexColumn
    {
        public string Name { get; set; }
        public SortDirection SortDirection { get; set; } = SortDirection.Ascending;
        public int Position { get; set; }

        public override bool Equals(object obj)
        {
            IndexColumn test = obj as IndexColumn;
            if (test != null)
            {
                return test.Name.ToLower().Equals(Name.ToLower()) && test.Position == Position && test.SortDirection == SortDirection;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.ToLower().GetHashCode() + Position.GetHashCode() + SortDirection.GetHashCode();
        }
    }
}
