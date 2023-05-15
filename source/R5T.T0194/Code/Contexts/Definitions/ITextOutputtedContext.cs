using System;

using R5T.T0137;
using R5T.T0159;


namespace R5T.T0194
{
    /// <summary>
    /// Attributed base context for contexts providing a text output.
    /// </summary>
    [ContextTypeMarker]
    public interface ITextOutputtedContext : IContextDefinitionMarker
    {
        public ITextOutput TextOutput { get; }
    }
}
