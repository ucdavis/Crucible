﻿using Microsoft.AspNetCore.Authorization;

namespace CruSibyl.Web.Middleware;

public class VerifyRoleAccess : IAuthorizationRequirement
{
    public readonly string[] RoleStrings;

    public VerifyRoleAccess(params string[] roleStrings)
    {
        RoleStrings = roleStrings;
    }
}

