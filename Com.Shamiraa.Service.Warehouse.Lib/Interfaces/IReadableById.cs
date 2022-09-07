using System.Threading.Tasks;

namespace Com.Shamiraa.Service.Warehouse.Lib.Interfaces
{
    public interface IReadByIdable<TModel>
    {
        Task<TModel> ReadById(int id);
    }
}
