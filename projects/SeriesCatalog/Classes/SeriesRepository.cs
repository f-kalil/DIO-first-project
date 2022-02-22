using SeriesCatalog.Interfaces;

namespace SeriesCatalog.Classes
{
    public class SeriesRepository : IRepository<Series>
    {
        private List<Series> SeriesList = new List<Series>();
        
        public void AddSeries(Series series)
        {
            SeriesList.Add(series);
        }

        public Series GetSeriesById(int Id)
        {
            return SeriesList[Id];
        }

        public void RemoveSeriesById(int Id)
        {
            SeriesList[Id].Delete();
        }

        public void UpdateSeries(int Id, Series series)
        {
            SeriesList[Id] = series;
        }

        public List<Series> ViewList()
        {
            return SeriesList;
        }
    }
}