using System.Threading.Tasks;

namespace Com.Shamiraa.Service.Warehouse.Lib.Interfaces
{
    public interface ICreateable
    {
        Task<int> Create(object model);
    }
}
