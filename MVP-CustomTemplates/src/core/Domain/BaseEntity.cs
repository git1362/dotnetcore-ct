using MongoDB.Bson.Serialization.Attributes;

namespace Domain
{
    public abstract class BaseEntity<T>
    {
        public T? Id { get; set; }
    }
}
