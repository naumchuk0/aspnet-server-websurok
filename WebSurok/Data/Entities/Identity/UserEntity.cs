﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebSurok.Data.Entities.Identity
{
    public class UserEntity : IdentityUser<long>
    {
        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        [StringLength(100)]
        public string Image { get; set; }
        public virtual ICollection<UserRoleEntity> UserRoles { get; set; }
        public virtual ICollection<CategoryEntity> Categories { get; set; }
    }
}
