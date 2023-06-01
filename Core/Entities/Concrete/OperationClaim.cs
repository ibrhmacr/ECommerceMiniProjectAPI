using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Core.Entities.Concrete;

public class OperationClaim : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
}