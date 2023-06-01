using Core.Entities.Abstract;

namespace Entities.Concrete;

public class Address : IEntity
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Neighborhood { get; set; } //mahalle

    public string Street { get; set; } //sokak

    public string ApartmentNo { get; set; }

    public string DoorNo { get; set; }

    public string Province { get; set; } //il

    public string District { get; set; } //ilce
}