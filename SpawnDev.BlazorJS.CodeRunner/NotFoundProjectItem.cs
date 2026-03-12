namespace SpawnDev.BlazorJS.CodeRunner
{
    using Microsoft.AspNetCore.Razor.Language;
    using System;
    using System.IO;

    internal class NotFoundProjectItem : RazorProjectItem
    {
        public NotFoundProjectItem(string basePath, string path)
        {
            BasePath = basePath;
            FilePath = path;
        }

        public override string BasePath { get; }

        public override string FilePath { get; }

        public override bool Exists => false;

        public override string PhysicalPath => throw new NotSupportedException();

        public override Stream Read() => throw new NotSupportedException();
    }
}