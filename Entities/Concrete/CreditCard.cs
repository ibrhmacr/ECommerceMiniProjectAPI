using Core.Entities.Abstract;

namespace Entities.Concrete;

public class CreditCard : IEntity
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string CardName { get; set; }

    public string CardNumber { get; set; }

    public DateTime ExpirationDate { get; set; }

    public string Cvc { get; set; }
}