namespace PracticeDapperApp.Services
{
    public interface IDataMapper<TModel, TDataEntity>
    {
        TModel MapFrom(TDataEntity dataEntity);
        TDataEntity MapTo(TModel model);
    }
}
