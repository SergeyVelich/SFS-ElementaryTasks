﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task2_EnvelopesAnalysis.Resources {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class MessagesResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MessagesResources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Task2_EnvelopesAnalysis.Resources.MessagesResources", typeof(MessagesResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
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
        ///   Ищет локализованную строку, похожую на Envelope Analyzer.
        /// </summary>
        internal static string ApplicationName {
            get {
                return ResourceManager.GetString("ApplicationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Do you want to continue? (yes/y).
        /// </summary>
        internal static string AskContunue {
            get {
                return ResourceManager.GetString("AskContunue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Enter height and width for {0} envelope:.
        /// </summary>
        internal static string AskInputEnvelope {
            get {
                return ResourceManager.GetString("AskInputEnvelope", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Enter height:.
        /// </summary>
        internal static string AskInputHeight {
            get {
                return ResourceManager.GetString("AskInputHeight", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Enter width:.
        /// </summary>
        internal static string AskInputWidth {
            get {
                return ResourceManager.GetString("AskInputWidth", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Invalid argument 1..
        /// </summary>
        internal static string ErrorInvalidArgument1 {
            get {
                return ResourceManager.GetString("ErrorInvalidArgument1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на The application responds if you can put one envelope in another.
        ///
        ///Parameters:
        ///    - required:
        ///        none
        ///    - optional:
        ///        none.
        /// </summary>
        internal static string Instruction {
            get {
                return ResourceManager.GetString("Instruction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на The second envelope can&apos;t be inserted in the first.
        /// </summary>
        internal static string ResultNegative {
            get {
                return ResourceManager.GetString("ResultNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на The second envelope can be inserted in the first.
        /// </summary>
        internal static string ResultPositive {
            get {
                return ResourceManager.GetString("ResultPositive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на yes.
        /// </summary>
        internal static string Yes {
            get {
                return ResourceManager.GetString("Yes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на y.
        /// </summary>
        internal static string YesShort {
            get {
                return ResourceManager.GetString("YesShort", resourceCulture);
            }
        }
    }
}
