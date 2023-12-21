﻿namespace WebApi8.FisstApp.Models.Interfacess
{
    public interface IAuditable
    {
        DateTime? CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}
