﻿using JetBrains.Application;
using JetBrains.ReSharper.Feature.Services.QuickFixes;
using JetBrains.ReSharper.Intentions.CSharp.QuickFixes;
using JetBrains.ReSharper.Psi.CSharp.Tree;

namespace XmlDocInspections.Plugin.Highlighting
{
    [ShellComponent]
    internal class XmlDocInspectionsQuickFixRegistrarComponent
    {
        public XmlDocInspectionsQuickFixRegistrarComponent(IQuickFixes table)
        {
            table.RegisterQuickFix<MissingXmlDocHighlighting>(
#if RS20183
                null,
#else
                default(JetBrains.Lifetimes.Lifetime),
#endif
                h => CreateAddDocCommentFix(h.HighlightingNode), typeof(AddDocCommentFix));
        }

        private static AddDocCommentFix CreateAddDocCommentFix(ICSharpDeclaration declaration) => new AddDocCommentFix(declaration);
    }
}
