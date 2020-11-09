using System;

namespace Domain
{
    public class UsersService
    {
        public CreatedUserDTO Create(string name, Profile profile)
        {
            var user = new User(name, profile);
            var createdUser = user.Validate();

            if (createdUser.isValid)
            {
                UsersRepository.Add(user);
                return new CreatedUserDTO(user.Id);
            }

            return new CreatedUserDTO(createdUser.errors);
        }
    }
}