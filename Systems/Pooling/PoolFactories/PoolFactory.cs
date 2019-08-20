namespace DK.Systems.Pooling
{
    internal abstract class PoolFactory
    {
        protected const int defaultInitCApasity = 10;

        internal virtual object CreatePool(object instance, int initialCapacity = defaultInitCApasity)
        {
            throw new System.NotImplementedException();
        }

        internal virtual Pool<T> CreatePool<T>(int initialCapacity = defaultInitCApasity) where T: IPoolable, new()
        {
            throw new System.NotImplementedException();
        }

        internal virtual Pool<T> CreatePool<T>(object instance, int initialCapacity = defaultInitCApasity) where T : IPoolable, new()
        {
            throw new System.NotImplementedException();
        }
    }
}
