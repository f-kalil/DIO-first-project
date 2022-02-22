namespace SeriesCatalog.Classes
{
    public class Series: Base
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        private bool IsDeleted { get; set; }

        public Series(int id, double Rating, string Title, string Genre)
        {
            this.Id = id;
            this.Rating = Rating;
            this.Title = Title;
            this.Genre = Genre;
            this.IsDeleted = false;
        }

        public string Stringify()
        {
            string text = @$"
            Id: {this.Id}

            Título: {this.Title}

            Gênero: {this.Genre}

            Avaliação: {this.Rating}
            ";

            return text;
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