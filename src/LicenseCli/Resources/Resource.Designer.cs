﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LicenseCli.Resources {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LicenseCli.Resources.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
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
        ///   查找类似 作者 的本地化字符串。
        /// </summary>
        internal static string Author_Description {
            get {
                return ResourceManager.GetString("Author.Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 许可证ID 的本地化字符串。
        /// </summary>
        internal static string LicenseId {
            get {
                return ResourceManager.GetString("LicenseId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 许可证名称 的本地化字符串。
        /// </summary>
        internal static string LicenseName {
            get {
                return ResourceManager.GetString("LicenseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 创建许可证 的本地化字符串。
        /// </summary>
        internal static string New_Description {
            get {
                return ResourceManager.GetString("New.Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 忽略模板中的可选部分 的本地化字符串。
        /// </summary>
        internal static string NoOptional_Description {
            get {
                return ResourceManager.GetString("NoOptional.Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 将许可证写入到此处 的本地化字符串。
        /// </summary>
        internal static string Output_Description {
            get {
                return ResourceManager.GetString("Output.Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 打印宽度 的本地化字符串。
        /// </summary>
        internal static string PrintWidth_Description {
            get {
                return ResourceManager.GetString("PrintWidth.Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 安静模式，不会打印输出 的本地化字符串。
        /// </summary>
        internal static string Quiet_Description {
            get {
                return ResourceManager.GetString("Quiet.Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 许可证创建实用工具 的本地化字符串。
        /// </summary>
        internal static string Root_Description {
            get {
                return ResourceManager.GetString("Root.Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 在 spdx.org 中搜索许可证 的本地化字符串。
        /// </summary>
        internal static string Search_Description {
            get {
                return ResourceManager.GetString("Search.Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 SPDX 表达式 的本地化字符串。
        /// </summary>
        internal static string SPDXExpression_Description {
            get {
                return ResourceManager.GetString("SPDXExpression.Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 SPDX 表达式（模糊匹配） 的本地化字符串。
        /// </summary>
        internal static string SPDXLike_Description {
            get {
                return ResourceManager.GetString("SPDXLike.Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 许可证变量 的本地化字符串。
        /// </summary>
        internal static string Variables_Description {
            get {
                return ResourceManager.GetString("Variables.Description", resourceCulture);
            }
        }
    }
}
