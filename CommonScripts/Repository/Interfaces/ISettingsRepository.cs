﻿using CommonScripts.Model.Base;
using System.Collections.Generic;

namespace CommonScripts.Repository.Interfaces
{
    public interface ISettingsRepository
    {
        bool SaveScripts(List<ScriptAbs> scripts);
        List<ScriptAbs> GetScripts();
    }
}
