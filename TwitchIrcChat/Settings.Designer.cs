﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TwitchIrcChat {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Hello")]
        public string Stuff {
            get {
                return ((string)(this["Stuff"]));
            }
            set {
                this["Stuff"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#000000")]
        public string BackgroundChatColor {
            get {
                return ((string)(this["BackgroundChatColor"]));
            }
            set {
                this["BackgroundChatColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#000000")]
        public string BackgroundUserColor {
            get {
                return ((string)(this["BackgroundUserColor"]));
            }
            set {
                this["BackgroundUserColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FFFFFF")]
        public string BackgroundTextBoxColor {
            get {
                return ((string)(this["BackgroundTextBoxColor"]));
            }
            set {
                this["BackgroundTextBoxColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FFFFFF")]
        public string TextColor {
            get {
                return ((string)(this["TextColor"]));
            }
            set {
                this["TextColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[hh:mm]")]
        public string DateFormat {
            get {
                return ((string)(this["DateFormat"]));
            }
            set {
                this["DateFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowJoinPart {
            get {
                return ((bool)(this["ShowJoinPart"]));
            }
            set {
                this["ShowJoinPart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FF90EE90")]
        public string JoinPartColor {
            get {
                return ((string)(this["JoinPartColor"]));
            }
            set {
                this["JoinPartColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#000000")]
        public string TextBoxTextColor {
            get {
                return ((string)(this["TextBoxTextColor"]));
            }
            set {
                this["TextBoxTextColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FlashOnUser {
            get {
                return ((bool)(this["FlashOnUser"]));
            }
            set {
                this["FlashOnUser"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool FlashOnText {
            get {
                return ((bool)(this["FlashOnText"]));
            }
            set {
                this["FlashOnText"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#FFFFFF")]
        public string UserColor {
            get {
                return ((string)(this["UserColor"]));
            }
            set {
                this["UserColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool KeepOnTop {
            get {
                return ((bool)(this["KeepOnTop"]));
            }
            set {
                this["KeepOnTop"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string MainWIndowPlacement {
            get {
                return ((string)(this["MainWIndowPlacement"]));
            }
            set {
                this["MainWIndowPlacement"] = value;
            }
        }
    }
}
