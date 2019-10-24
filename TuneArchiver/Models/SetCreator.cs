using System.Collections.Generic;
using System.Linq;
using TuneArchiver.Interfaces;

namespace TuneArchiver.Models {
    class SetCreator : ISetCreator {
        private const long  cDvd9Size = 4692251770;

        public IEnumerable<IEnumerable<T>> GetPowerSet<T>( List<T> list ) {
            return from m in Enumerable.Range( 0, 1 << list.Count )
                select
                    from i in Enumerable.Range( 0, list.Count )
                    where ( m & ( 1 << i )) != 0
                    select list[i];
        }
    }
}
