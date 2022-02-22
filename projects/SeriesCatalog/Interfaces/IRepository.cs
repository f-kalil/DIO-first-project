namespace SeriesCatalog.Interfaces
{
    public interface IRepository<T>
    {
        void AddSeries(T series);
        void RemoveSeriesById(int Id);
        void UpdateSeries(int Id, T series);
        T GetSeriesById(int Id);
        List<T> ViewList();
    }
}