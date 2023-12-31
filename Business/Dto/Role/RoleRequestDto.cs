﻿using Business.Dto.Claim;

namespace Business.Dto.Role;

public class RoleRequestDto
{
    public string Name { get; set; }
    public List<ClaimDto> Claims { get; set; }
}
