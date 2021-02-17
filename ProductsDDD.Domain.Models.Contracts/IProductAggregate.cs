using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsDDD.Domain.Models.Contracts
{
    public interface IAggregate
    {
        bool Validate(out List<ValidationResult> validationInfos);
    }
}