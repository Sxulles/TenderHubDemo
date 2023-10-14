﻿using System.ComponentModel.DataAnnotations;

namespace Backend.Model.Auth
{
    public record RegistrationResponse(string Email, string Username, bool Success);
}
