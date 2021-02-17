using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductsDDD.Domain.Shared.Exceptions
{
    public class ValidationException : Exception
    {
        public List<ValidationResult> ValidationResults { get; set; }

        public ValidationException(List<ValidationResult> validationResults)
        {
            ValidationResults = validationResults;
        }
    }
}