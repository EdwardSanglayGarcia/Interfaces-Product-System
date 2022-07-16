using ProductSystemLibrary.Interfaces;

namespace ProductSystemLibrary.Actions
{
    public interface IActions
    {
        List<IDefaultProduct> AddSampleData();
        void GenerateCSV(List<IDefaultProduct> products);
        void DisplayConsoleData(List<IDefaultProduct> products);
    }
}
