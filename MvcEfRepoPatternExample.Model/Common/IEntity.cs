﻿namespace MvcEfRepoPatternExample.Model.Common
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
