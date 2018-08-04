﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalDotNetSite.Models
{
    public interface ISkillsRepository
    {
        //get all the skills from the DB
        IEnumerable<Skill> Skills { get; }

        Skill getSkillByName(string name);
    }
}
