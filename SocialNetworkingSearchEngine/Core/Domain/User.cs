﻿namespace Core.Domain
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Name { get; set; }     
    }
}