namespace notes
{
    public class NoteSettings
    {
        public string Name { get; set; } = "notes";
        public string Description { get; set; } = "A short description of the note";
        public string Owner { get; set; } = "The Owner";
        public int PostsPerPage { get; set; } = 2;
        public int CommentsCloseAfterDays { get; set; } = 10;
    }
}
