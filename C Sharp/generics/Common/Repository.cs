using System.Collections.Generic;

namespace generics.Common
{
    class Repository<TValue> where TValue : IEntity
    {
        private List<TValue> _data;

        public void Add(TValue value)
        {
            if (value is not null)
                _data.Add(value);
        }

        public TValue GetAt(int index)
        {
            if (index < _data.Count && index >= 0)
                return _data[index];

            return default;
        }
    }
}
