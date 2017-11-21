namespace MiniApps.Core.Interface
{
    public interface IEntityMapping<TEntity>
    {
        void  Configure(TEntity builder);
    }
}
