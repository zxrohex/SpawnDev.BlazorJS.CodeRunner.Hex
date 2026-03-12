namespace SpawnDev.BlazorJS.CodeRunner
{
    using Microsoft.CodeAnalysis;
    using System.Collections.Generic;
    using System.Reflection;

    public class CompileToAssemblyResult
    {
        public bool Compiled => AssemblyBytes != null && AssemblyBytes.Length > 0;
        public Compilation Compilation { get; set; }
        public IEnumerable<CompilationDiagnostic> Diagnostics { get; set; } = [];
        public byte[]? AssemblyBytes { get; set; }
        private Assembly? _Assembly = null;
        public Assembly? LoadAssembly()
        {
            _Assembly ??= AssemblyBytes == null ? null : AppDomain.CurrentDomain.Load(AssemblyBytes);
            return _Assembly;
        }
    }
}
