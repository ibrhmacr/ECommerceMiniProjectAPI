using Core.Entities.Abstract;

namespace Entities.DTOs;

public class EmailDto : IDto
{
    public string To { get; set; }

    public string Subject { get; set; }

    public string Body { get; set; }
}