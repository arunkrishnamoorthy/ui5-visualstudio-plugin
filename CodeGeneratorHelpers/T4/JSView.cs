﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CodeGeneratorHelpers.T4
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\abdo\Documents\GitHub\SapUI5-VisualStudioPlugin\CodeGeneratorHelpers\T4\JSView.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class JSView : JSViewBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 8 "C:\Users\abdo\Documents\GitHub\SapUI5-VisualStudioPlugin\CodeGeneratorHelpers\T4\JSView.tt"

var isMobile = this.IsMobile;
var controllerName = this.ControllerName;

            
            #line default
            #line hidden
            
            #line 12 "C:\Users\abdo\Documents\GitHub\SapUI5-VisualStudioPlugin\CodeGeneratorHelpers\T4\JSView.tt"
if(isMobile){
            
            #line default
            #line hidden
            this.Write("sap.ui.jsview(\"");
            
            #line 13 "C:\Users\abdo\Documents\GitHub\SapUI5-VisualStudioPlugin\CodeGeneratorHelpers\T4\JSView.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controllerName));
            
            #line default
            #line hidden
            this.Write("\", {\r\n\r\n\t/** Specifies the Controller belonging to this View. \r\n\t* In the case th" +
                    "at it is not implemented, or that \"null\" is returned, this View does not have a " +
                    "Controller.\r\n\t* @memberOf ");
            
            #line 17 "C:\Users\abdo\Documents\GitHub\SapUI5-VisualStudioPlugin\CodeGeneratorHelpers\T4\JSView.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controllerName));
            
            #line default
            #line hidden
            this.Write("\r\n\t*/ \r\n\tgetControllerName : function() {\r\n\t\treturn \"");
            
            #line 20 "C:\Users\abdo\Documents\GitHub\SapUI5-VisualStudioPlugin\CodeGeneratorHelpers\T4\JSView.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controllerName));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t},\r\n\r\n\t/** Is initially called once after the Controller has been instantiat" +
                    "ed. It is the place where the UI is constructed. \r\n\t* Since the Controller is gi" +
                    "ven to this method, its event handlers can be attached right away. \r\n\t* @memberO" +
                    "f ");
            
            #line 25 "C:\Users\abdo\Documents\GitHub\SapUI5-VisualStudioPlugin\CodeGeneratorHelpers\T4\JSView.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controllerName));
            
            #line default
            #line hidden
            this.Write("\r\n\t*/ \r\n\tcreateContent : function(oController) {\r\n \t\treturn new sap.m.Page({\r\n\t\t\t" +
                    "title: \"Title\",\r\n\t\t\tcontent: [\r\n\t\t\t\r\n\t\t\t]\r\n\t\t});\r\n\t}\r\n\r\n});\r\n");
            
            #line 37 "C:\Users\abdo\Documents\GitHub\SapUI5-VisualStudioPlugin\CodeGeneratorHelpers\T4\JSView.tt"
}else{
            
            #line default
            #line hidden
            this.Write("sap.ui.jsview(\"");
            
            #line 38 "C:\Users\abdo\Documents\GitHub\SapUI5-VisualStudioPlugin\CodeGeneratorHelpers\T4\JSView.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controllerName));
            
            #line default
            #line hidden
            this.Write("\", {\r\n\r\n\t/** Specifies the Controller belonging to this View. \r\n\t* In the case th" +
                    "at it is not implemented, or that \"null\" is returned, this View does not have a " +
                    "Controller.\r\n\t* @memberOf ");
            
            #line 42 "C:\Users\abdo\Documents\GitHub\SapUI5-VisualStudioPlugin\CodeGeneratorHelpers\T4\JSView.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controllerName));
            
            #line default
            #line hidden
            this.Write("\r\n\t*/ \r\n\tgetControllerName : function() {\r\n\t\treturn \"");
            
            #line 45 "C:\Users\abdo\Documents\GitHub\SapUI5-VisualStudioPlugin\CodeGeneratorHelpers\T4\JSView.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controllerName));
            
            #line default
            #line hidden
            this.Write("\";\r\n\t},\r\n\r\n\t/** Is initially called once after the Controller has been instantiat" +
                    "ed. It is the place where the UI is constructed. \r\n\t* Since the Controller is gi" +
                    "ven to this method, its event handlers can be attached right away. \r\n\t* @memberO" +
                    "f ");
            
            #line 50 "C:\Users\abdo\Documents\GitHub\SapUI5-VisualStudioPlugin\CodeGeneratorHelpers\T4\JSView.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(controllerName));
            
            #line default
            #line hidden
            this.Write("\r\n\t*/ \r\n\tcreateContent : function(oController) {\r\n\r\n\t}\r\n});\r\n");
            
            #line 56 "C:\Users\abdo\Documents\GitHub\SapUI5-VisualStudioPlugin\CodeGeneratorHelpers\T4\JSView.tt"
}
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "C:\Users\abdo\Documents\GitHub\SapUI5-VisualStudioPlugin\CodeGeneratorHelpers\T4\JSView.tt"

private string _ControllerNameField;

/// <summary>
/// Access the ControllerName parameter of the template.
/// </summary>
private string ControllerName
{
    get
    {
        return this._ControllerNameField;
    }
}

private bool _IsMobileField;

/// <summary>
/// Access the IsMobile parameter of the template.
/// </summary>
private bool IsMobile
{
    get
    {
        return this._IsMobileField;
    }
}


/// <summary>
/// Initialize the template
/// </summary>
public virtual void Initialize()
{
    if ((this.Errors.HasErrors == false))
    {
bool ControllerNameValueAcquired = false;
if (this.Session.ContainsKey("ControllerName"))
{
    this._ControllerNameField = ((string)(this.Session["ControllerName"]));
    ControllerNameValueAcquired = true;
}
if ((ControllerNameValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("ControllerName");
    if ((data != null))
    {
        this._ControllerNameField = ((string)(data));
    }
}
bool IsMobileValueAcquired = false;
if (this.Session.ContainsKey("IsMobile"))
{
    this._IsMobileField = ((bool)(this.Session["IsMobile"]));
    IsMobileValueAcquired = true;
}
if ((IsMobileValueAcquired == false))
{
    object data = global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("IsMobile");
    if ((data != null))
    {
        this._IsMobileField = ((bool)(data));
    }
}


    }
}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class JSViewBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}