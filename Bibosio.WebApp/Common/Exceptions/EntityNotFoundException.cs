namespace Bibosio.WebApp.Common.Exceptions
{
    public class EntityNotFoundException : ApplicationException
    {
        public EntityNotFoundException(string entity, object key) : base($"Entity {entity} ({key}) not found")
        { }
    }
}
