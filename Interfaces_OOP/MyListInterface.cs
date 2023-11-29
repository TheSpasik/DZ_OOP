

namespace Interfaces_OOP
{
    public interface ICollection
    {
        int Count { get; }

        void Add(object item);
        void Clear();
        bool Contains(object item);
        bool Remove(object item);
    }

    public interface IList : ICollection
    {
        object this[int index] { get; set; }
        int IndexOf(object item);
        void Insert(int index, object item);
        void RemoveAt(int index);
    }
}
