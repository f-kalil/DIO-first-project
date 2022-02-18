namespace SeriesCatalog
{
    public class Series: Base
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        private bool IsDeleted { get; set; }

        public Series(double Rating, string Title, string Genre)
        {
            this.Rating = Rating;
            this.Title = Title;
            this.Genre = Genre;
            this.IsDeleted = IsDeleted;
        }

        public string Stringify()
        {
            string text = @$"
            Gênero:     Título:     Avaliação:
            {this.Genre}     {this.Title}     {this.Rating}";
            return text;
        }

        public int GetId()
        {
            return this.Id;
        }

        public bool GetDeletedBool()
        {
            return this.IsDeleted;
        }

        public void Delete()
        {
            this.IsDeleted = true;
        }
    }
}