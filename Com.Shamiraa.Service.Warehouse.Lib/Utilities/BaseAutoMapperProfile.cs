using AutoMapper;

namespace Com.Shamiraa.Service.Warehouse.Lib.Utilities
{
    public class BaseAutoMapperProfile : Profile
    {
        public BaseAutoMapperProfile()
        {
            //RecognizePrefixes("_");
            RecognizeAlias("_id", "Id");
        }
    }
}
