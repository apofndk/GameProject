﻿using GameProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
