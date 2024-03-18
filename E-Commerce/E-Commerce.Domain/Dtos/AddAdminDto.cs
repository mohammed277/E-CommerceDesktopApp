using E_Commerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Dtos
{
    public class AddAdminDto:AddUserDto
    {
        public UserRole Role { get; set; } = UserRole.Admin;
    }
}
