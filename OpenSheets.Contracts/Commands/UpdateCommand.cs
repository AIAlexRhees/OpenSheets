﻿using System;

namespace OpenSheets.Contracts.Commands
{
    public class UpdateCommand<T> where T : class
    {
        public Guid ObjectId { get; set; }
        public Guid NewVersion { get; set; }
        public T Object { get; set; }
    }
}