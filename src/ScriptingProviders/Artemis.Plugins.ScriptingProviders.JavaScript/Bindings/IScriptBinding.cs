﻿using Jint;

namespace Artemis.Plugins.ScriptingProviders.JavaScript.Bindings
{
    public interface IScriptBinding
    {
        void Initialize(Engine engine);
        string? GetDeclaration();
    }
}