﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TAlex.BeautifulFractals.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(TAlex.Common.Configuration.XmlSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Fractals.xml")]
        public string FractalsCollectionPath {
            get {
                return ((string)(this["FractalsCollectionPath"]));
            }
            set {
                this["FractalsCollectionPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(TAlex.Common.Configuration.XmlSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RandomOrder {
            get {
                return ((bool)(this["RandomOrder"]));
            }
            set {
                this["RandomOrder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(TAlex.Common.Configuration.XmlSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ExitOnMouseMove {
            get {
                return ((bool)(this["ExitOnMouseMove"]));
            }
            set {
                this["ExitOnMouseMove"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(TAlex.Common.Configuration.XmlSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("00:00:03")]
        public global::System.TimeSpan Delay {
            get {
                return ((global::System.TimeSpan)(this["Delay"]));
            }
            set {
                this["Delay"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(TAlex.Common.Configuration.XmlSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowFractalCaptions {
            get {
                return ((bool)(this["ShowFractalCaptions"]));
            }
            set {
                this["ShowFractalCaptions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(TAlex.Common.Configuration.XmlSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#ff1e90ff")]
        public global::TAlex.BeautifulFractals.Rendering.Color Background_FirstColor {
            get {
                return ((global::TAlex.BeautifulFractals.Rendering.Color)(this["Background_FirstColor"]));
            }
            set {
                this["Background_FirstColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(TAlex.Common.Configuration.XmlSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#ff000000")]
        public global::TAlex.BeautifulFractals.Rendering.Color Background_SecondColor {
            get {
                return ((global::TAlex.BeautifulFractals.Rendering.Color)(this["Background_SecondColor"]));
            }
            set {
                this["Background_SecondColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(TAlex.Common.Configuration.XmlSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Arial")]
        public string Caption_FontFamily {
            get {
                return ((string)(this["Caption_FontFamily"]));
            }
            set {
                this["Caption_FontFamily"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(TAlex.Common.Configuration.XmlSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12")]
        public double Caption_FontSize {
            get {
                return ((double)(this["Caption_FontSize"]));
            }
            set {
                this["Caption_FontSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsProviderAttribute(typeof(TAlex.Common.Configuration.XmlSettingsProvider))]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#ff000000")]
        public global::TAlex.BeautifulFractals.Rendering.Color Caption_FontColor {
            get {
                return ((global::TAlex.BeautifulFractals.Rendering.Color)(this["Caption_FontColor"]));
            }
            set {
                this["Caption_FontColor"] = value;
            }
        }
    }
}
