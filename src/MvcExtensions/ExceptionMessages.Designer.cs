﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcExtensions {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ExceptionMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MvcExtensions.ExceptionMessages", typeof(ExceptionMessages).Assembly);
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
        ///   Looks up a localized string similar to Activation error occurred while trying to get all instances of type {0}..
        /// </summary>
        internal static string ActivateAllExceptionMessage {
            get {
                return ResourceManager.GetString("ActivateAllExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Activation error occurred while trying to get instance of type {0}, key &quot;{1}&quot;..
        /// </summary>
        internal static string ActivationExceptionMessage {
            get {
                return ResourceManager.GetString("ActivationExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot apply email when there is an active expression..
        /// </summary>
        internal static string CannotApplyEmailWhenThereIsAnActiveExpression {
            get {
                return ResourceManager.GetString("CannotApplyEmailWhenThereIsAnActiveExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot apply url when there is an active expression..
        /// </summary>
        internal static string CannotApplyUrlWhenThereIsAnActiveExpression {
            get {
                return ResourceManager.GetString("CannotApplyUrlWhenThereIsAnActiveExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; cannot be null..
        /// </summary>
        internal static string CannotBeNull {
            get {
                return ResourceManager.GetString("CannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot have more than one model binder &quot;{0}&quot; for the same model type &quot;{1}&quot;..
        /// </summary>
        internal static string CannotHaveMoreThanOneModelBinderForTheSameModelType {
            get {
                return ResourceManager.GetString("CannotHaveMoreThanOneModelBinderForTheSameModelType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You cannot include if you have already specified exclude..
        /// </summary>
        internal static string ExcludeAlreadyExists {
            get {
                return ResourceManager.GetString("ExcludeAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incorrect type, it must be descended of &quot;{0}&quot;..
        /// </summary>
        internal static string IncorrectTypeMustBeDescended {
            get {
                return ResourceManager.GetString("IncorrectTypeMustBeDescended", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid action invoker type. Type must implement &quot;IActionInvoker&quot;..
        /// </summary>
        internal static string InvalidActionInvokerTypeTypeMustImplementIActionInvoker {
            get {
                return ResourceManager.GetString("InvalidActionInvokerTypeTypeMustImplementIActionInvoker", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid controller type. Type must be a inherited from &quot;Controller&quot;..
        /// </summary>
        internal static string InvalidControllerTypeTypeMustBeAInheritedFromController {
            get {
                return ResourceManager.GetString("InvalidControllerTypeTypeMustBeAInheritedFromController", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid email address format..
        /// </summary>
        internal static string InvalidEmailAddressFormat {
            get {
                return ResourceManager.GetString("InvalidEmailAddressFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid url format..
        /// </summary>
        internal static string InvalidUrlFormat {
            get {
                return ResourceManager.GetString("InvalidUrlFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; is not a &quot;{1}&quot; type..
        /// </summary>
        internal static string IsNotATargetType {
            get {
                return ResourceManager.GetString("IsNotATargetType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This request has been blocked because sensitive information could be disclosed to third party web sites when this is used in a GET request. To allow GET requests, set JsonRequestBehavior to AllowGet..
        /// </summary>
        internal static string JsonGet {
            get {
                return ResourceManager.GetString("JsonGet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;{0}&quot; must be a valid class..
        /// </summary>
        internal static string MustBeAValidClass {
            get {
                return ResourceManager.GetString("MustBeAValidClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Responder with the same type &quot;{0}&quot; already exists..
        /// </summary>
        internal static string SameResponderExists {
            get {
                return ResourceManager.GetString("SameResponderExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The expression must be a valid controller action..
        /// </summary>
        internal static string TheExpressionMustBeAValidControllerAction {
            get {
                return ResourceManager.GetString("TheExpressionMustBeAValidControllerAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property {0}.{1} could not be found..
        /// </summary>
        internal static string ThePropertyNameOfTypeCouldNotBeFound {
            get {
                return ResourceManager.GetString("ThePropertyNameOfTypeCouldNotBeFound", resourceCulture);
            }
        }
    }
}
