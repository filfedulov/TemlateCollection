
namespace Eleven_collection_.TestCollectionDirectory.OperationsDirectory
{
    public interface IOperationsCollections<T>
    {
        T Find();
        T Add();
        T Delete();
        T Print();
    }
}
