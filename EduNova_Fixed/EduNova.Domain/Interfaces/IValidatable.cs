using System.Collections.Generic;

namespace EduNova.Domain.Interfaces
{
    public interface IValidatable
    {
        List<string> Validate();
    }
}