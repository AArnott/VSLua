﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.LanguageServices.Lua.Shared;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Differencing;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;

namespace Microsoft.VisualStudio.LanguageServices.Lua.Formatting
{
    [Export(typeof(IWpfTextViewConnectionListener))]
    [ContentType(Constants.Language.Name)]
    [TextViewRole(PredefinedTextViewRoles.Interactive)]
    class WpfTextViewConnectionListener : IWpfTextViewConnectionListener
    {
        [Import]
        private ICore core;

        public void SubjectBuffersConnected(IWpfTextView textView, ConnectionReason reason, Collection<ITextBuffer> subjectBuffers)
        {
            Validation.Requires.NotNull(subjectBuffers, nameof(subjectBuffers));

            List<ITextBuffer> textBuffers = IgnoreLeftTextBufferInInlineDiffView(textView, subjectBuffers);

            if (textBuffers.Count == 0)
            {
                return;
            }

            TextView internalTextView = new TextView(textView, this.core);
            internalTextView.Connect(textBuffers[0]);
        }

        private static List<ITextBuffer> IgnoreLeftTextBufferInInlineDiffView(IWpfTextView textView, Collection<ITextBuffer> subjectBuffers)
        {
            List<ITextBuffer> textBuffers = new List<ITextBuffer>();
            bool isInlineDiffView = textView.Roles.Contains(DifferenceViewerRoles.InlineViewTextViewRole);

            foreach (ITextBuffer subjectBuffer in subjectBuffers)
            {
                if (!(isInlineDiffView && subjectBuffer != textView.TextDataModel.DocumentBuffer))
                {
                    textBuffers.Add(subjectBuffer);
                }
            }

            return textBuffers;
        }

        public void SubjectBuffersDisconnected(IWpfTextView textView, ConnectionReason reason, Collection<ITextBuffer> subjectBuffers)
        {
            Validation.Requires.NotNull(textView, nameof(textView));
            Validation.Requires.NotNull(subjectBuffers, nameof(subjectBuffers));

            List<ITextBuffer> textBuffers = IgnoreLeftTextBufferInInlineDiffView(textView, subjectBuffers);

            if (textBuffers.Count == 0)
            {
                return;
            }
        }
    }
}
