﻿using System.ComponentModel.Composition;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using Microsoft.VisualStudio.LanguageServices.Lua.Shared;
using Microsoft.VisualStudio.PlatformUI;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace Microsoft.VisualStudio.LanguageServices.Lua.Classifications
{
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.Colourization.GlobalName)]
    [Name("LuaGlobalClassificationFormat")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Reviewed.")]
    internal sealed class GlobalIdentifierClassificationFormat : ClassificationFormatDefinition
    {
        internal GlobalIdentifierClassificationFormat()
        {
            this.DisplayName = Constants.Colourization.GlobalDisplayName;

            this.ForegroundColor = Colors.LightSalmon;
            this.ForegroundBrush = SystemColors.WindowTextBrush;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.Colourization.LocalName)]
    [Name("LuaLocalClassificationFormat")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Reviewed.")]
    internal sealed class LocalIdentifierClassificationFormat : ClassificationFormatDefinition
    {
        internal LocalIdentifierClassificationFormat()
        {
            this.DisplayName = Constants.Colourization.LocalDisplayName;

            this.ForegroundColor = (Color)ColorConverter.ConvertFromString("#16D1AC");
            this.ForegroundBrush = SystemColors.WindowTextBrush;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    // [ClassificationType(ClassificationTypeNames = Constants.Colourization.ParamName)]
    [ClassificationType(ClassificationTypeNames = "LuaParamClassificationFormat")]
    [Name("LuaParamClassificationFormat")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Reviewed.")]
    internal sealed class ParamIdentifierClassificationFormat : ClassificationFormatDefinition
    {
        internal ParamIdentifierClassificationFormat()
        {
            this.DisplayName = Constants.Colourization.ParamDisplayName;
            // this.ForegroundColor = Color.FromArgb(0xFF, 0x00, 0x00, 0xFF);
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = Constants.Colourization.FieldName)]
    [Name("LuaFieldClassificationFormat")]
    [UserVisible(true)]
    [Order(Before = Priority.Default)]
    [SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "Reviewed.")]
    internal sealed class FieldClassificationFormat : ClassificationFormatDefinition
    {
        internal FieldClassificationFormat()
        {
            this.DisplayName = Constants.Colourization.FieldDisplayName;

            this.ForegroundColor = (Color)ColorConverter.ConvertFromString("#CCCC00");
            this.ForegroundBrush = SystemColors.WindowTextBrush;
        }
    }
}
