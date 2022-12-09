using System.Collections.Generic;

namespace  dotnetedit.Data.Interfaces
{
    public interface IGet<T,TKey> where T : class
    {
        T Get(TKey id) ;
    }
}
