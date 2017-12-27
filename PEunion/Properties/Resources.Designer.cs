﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PEunion.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PEunion.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] BytecodeApi {
            get {
                object obj = ResourceManager.GetObject("BytecodeApi", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Copyright (c) 2017, bytecode77
        ///All rights reserved.
        ///
        ///Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
        ///
        /// • Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
        ///
        /// • Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provi [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FileLicense {
            get {
                return ResourceManager.GetString("FileLicense", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] FileManifestAsInvoker {
            get {
                object obj = ResourceManager.GetObject("FileManifestAsInvoker", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] FileManifestNone {
            get {
                object obj = ResourceManager.GetObject("FileManifestNone", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] FileManifestRequireAdministrator {
            get {
                object obj = ResourceManager.GetObject("FileManifestRequireAdministrator", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windows Registry Editor Version 5.00
        ///
        ///[HKEY_CLASSES_ROOT\.peu]
        ///@=&quot;peufile&quot;
        ///
        ///[HKEY_CLASSES_ROOT\peufile]
        ///@=&quot;PEunion Project Files&quot;
        ///
        ///[HKEY_CLASSES_ROOT\peufile\DefaultIcon]
        ///@=&quot;{IconPath}&quot;
        ///
        ///[HKEY_CLASSES_ROOT\peufile\shell]
        ///
        ///[HKEY_CLASSES_ROOT\peufile\shell\open]
        ///
        ///[HKEY_CLASSES_ROOT\peufile\shell\open\command]
        ///@=&quot;\&quot;{ApplicationPath}\&quot; \&quot;%1\&quot;&quot;.
        /// </summary>
        internal static string FileRegisterExtension {
            get {
                return ResourceManager.GetString("FileRegisterExtension", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] FileShellIcon {
            get {
                object obj = ResourceManager.GetObject("FileShellIcon", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*{PREPROCESSOR}*/
        ///
        ///using Microsoft.Win32;
        ///using System;
        ///using System.Diagnostics;
        ///using System.IO;
        ///using System.IO.Compression;
        ///using System.Linq;
        ///using System.Net;
        ///using System.Reflection;
        ///using System.Runtime.InteropServices;
        ///using System.Security.Cryptography;
        ///using System.Threading;
        ///using System.Windows.Forms;
        ////*{ASSEMBLYINFO}*/
        ///class __Program__
        ///{
        ///	static object[] __Items__ = new object[]
        ///	{
        ////*{ITEMS}*/	};
        ///
        ///	static void Main()
        ///	{
        ///#if ENABLE_DELETEZONEID
        ///		try
        ///		{
        ///			__F_Delet [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string FileStub {
            get {
                return ResourceManager.GetString("FileStub", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconAbout {
            get {
                object obj = ResourceManager.GetObject("IconAbout", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconAddFiles {
            get {
                object obj = ResourceManager.GetObject("IconAddFiles", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconAddMessageBox {
            get {
                object obj = ResourceManager.GetObject("IconAddMessageBox", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconAddUrl {
            get {
                object obj = ResourceManager.GetObject("IconAddUrl", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconArrowDown {
            get {
                object obj = ResourceManager.GetObject("IconArrowDown", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconArrowUp {
            get {
                object obj = ResourceManager.GetObject("IconArrowUp", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconBuild {
            get {
                object obj = ResourceManager.GetObject("IconBuild", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconBytecode77 {
            get {
                object obj = ResourceManager.GetObject("IconBytecode77", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconClearRecents {
            get {
                object obj = ResourceManager.GetObject("IconClearRecents", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconCode {
            get {
                object obj = ResourceManager.GetObject("IconCode", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconDelete {
            get {
                object obj = ResourceManager.GetObject("IconDelete", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconDirectory {
            get {
                object obj = ResourceManager.GetObject("IconDirectory", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconError {
            get {
                object obj = ResourceManager.GetObject("IconError", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconExit {
            get {
                object obj = ResourceManager.GetObject("IconExit", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconFiles {
            get {
                object obj = ResourceManager.GetObject("IconFiles", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconGitHub {
            get {
                object obj = ResourceManager.GetObject("IconGitHub", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconInfoIcon {
            get {
                object obj = ResourceManager.GetObject("IconInfoIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconInformation {
            get {
                object obj = ResourceManager.GetObject("IconInformation", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconMessageBox {
            get {
                object obj = ResourceManager.GetObject("IconMessageBox", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconMissingFile {
            get {
                object obj = ResourceManager.GetObject("IconMissingFile", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconNew {
            get {
                object obj = ResourceManager.GetObject("IconNew", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconOpen {
            get {
                object obj = ResourceManager.GetObject("IconOpen", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconOpenProjectFolder {
            get {
                object obj = ResourceManager.GetObject("IconOpenProjectFolder", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconOutputBinary {
            get {
                object obj = ResourceManager.GetObject("IconOutputBinary", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconSave {
            get {
                object obj = ResourceManager.GetObject("IconSave", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconStartup {
            get {
                object obj = ResourceManager.GetObject("IconStartup", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconUacOverlay {
            get {
                object obj = ResourceManager.GetObject("IconUacOverlay", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconUrl {
            get {
                object obj = ResourceManager.GetObject("IconUrl", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap IconWarning {
            get {
                object obj = ResourceManager.GetObject("IconWarning", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ImageAboutBanner {
            get {
                object obj = ResourceManager.GetObject("ImageAboutBanner", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ImageDragDrop {
            get {
                object obj = ResourceManager.GetObject("ImageDragDrop", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ImageMessageBoxConfirmation {
            get {
                object obj = ResourceManager.GetObject("ImageMessageBoxConfirmation", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ImageMessageBoxError {
            get {
                object obj = ResourceManager.GetObject("ImageMessageBoxError", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ImageMessageBoxInformation {
            get {
                object obj = ResourceManager.GetObject("ImageMessageBoxInformation", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ImageMessageBoxWarning {
            get {
                object obj = ResourceManager.GetObject("ImageMessageBoxWarning", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ImageMissingIcon {
            get {
                object obj = ResourceManager.GetObject("ImageMissingIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap ImageSplashScreen {
            get {
                object obj = ResourceManager.GetObject("ImageSplashScreen", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
