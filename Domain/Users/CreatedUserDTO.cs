using System;
using System.Collections.Generic;

namespace Domain
{
    public class CreatedUserDTO
    {
        public Guid Id { get; set; }
        public IList<string> Errors { get; set; }
        public bool IsValid { get; set; } = false;

        public CreatedUserDTO(Guid id)
        {
            Id = id;
            IsValid = true;
        }

        public CreatedUserDTO(IList<string> errors)
        {
            Errors = errors;
        }
    }
}