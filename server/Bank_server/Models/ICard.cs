﻿namespace Bank_server.Models
{
    public interface ICard
    {
        string CardNum { get; set; }
        string Pin { get; set; }
        decimal Balance { get; set; }
        User CardUser { get; set; }
    }
}
