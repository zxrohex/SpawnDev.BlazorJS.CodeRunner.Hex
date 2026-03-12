namespace SpawnDev.BlazorJS.CodeRunner
{
    using Microsoft.AspNetCore.Razor.Language;
    using System.Collections.Generic;

    internal class CompileToCSharpResult
    {
        public RazorProjectItem ProjectItem { get; set; }

        public string Code { get; set; }

        public string FilePath { get; set; }

        public IEnumerable<CompilationDiagnostic> Diagnostics { get; set; } = [];
    }
}
