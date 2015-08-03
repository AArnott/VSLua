﻿using System;
using System.ComponentModel.Composition;
using LanguageService;
using Microsoft.VisualStudio.Editor;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace Microsoft.VisualStudio.LanguageServices.Lua.Shared
{
    [Export(typeof(ICore))]
    internal class Core : ICore
    {
        [Import]
        private GlobalEditorOptions globalEditorOptions;

        [Import]
        private IVsEditorAdaptersFactoryService editorAdaptersFactory;

        [Import]
        private SVsServiceProvider serviceProvider;

        private SourceTextCache sourceTextCache;
        private LuaFeatureContainer featureContainer;
        private Formatting.UserSettings userSettings;

        public GlobalEditorOptions GlobalEditorOptions
        {
            get
            {
                return this.globalEditorOptions;
            }
        }

        public IVsEditorAdaptersFactoryService EditorAdaptersFactory
        {
            get
            {
                return this.editorAdaptersFactory;
            }
        }

        public SourceTextCache SourceTextCache
        {
            get
            {
                return this.sourceTextCache != null ? this.sourceTextCache : (this.sourceTextCache = new SourceTextCache());
            }
        }

        public LuaFeatureContainer FeatureContainer
        {
            get
            {
                if (this.featureContainer == null)
                {
                    this.featureContainer = new LuaFeatureContainer();
                }

                return this.featureContainer;
            }
        }

        public Formatting.UserSettings FormattingUserSettings
        {
            get
            {
                if (this.userSettings == null)
                {
                    var shell = this.serviceProvider.GetService(typeof(SVsShell)) as IVsShell;
                    Assumes.Present(shell);
                    Guid guid = Guids.Package;
                    IVsPackage package;
                    ErrorHandler.ThrowOnFailure(shell.LoadPackage(ref guid, out package));
                    LuaLanguageServicePackage luaPackage = (LuaLanguageServicePackage)package;
                    this.userSettings = luaPackage.FormattingUserSettings;
                }

                return this.userSettings;
            }
        }
    }
}
