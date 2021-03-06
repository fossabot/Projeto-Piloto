﻿using Semp.Infrastructure.Models;
using System.Collections.Generic;

namespace Semp.Module.Cms.Models
{
    public class Menu : Entity
    {
        public Menu()
        {

        }

        public Menu(long id)
        {
            Id = id;
        }

        public string Name { get; set; }

        public bool IsPublished { get; set; }

        public bool IsSystem { get; set; }

        public IList<MenuItem> MenuItems { get; protected set; } = new List<MenuItem>();
    }
}
