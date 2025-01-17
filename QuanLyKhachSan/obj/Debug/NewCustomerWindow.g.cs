﻿#pragma checksum "..\..\NewCustomerWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "487FB9C9BD940866ECE55DC0A133805C73C8DB594812854D5C99537A64E32D13"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using QuanLyKhachSan;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interactivity;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace QuanLyKhachSan {
    
    
    /// <summary>
    /// NewCustomerWindow
    /// </summary>
    public partial class NewCustomerWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\NewCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal QuanLyKhachSan.NewCustomerWindow newCustomerWindow;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\NewCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CusName;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\NewCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CusIdentity;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\NewCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Phone;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\NewCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Birthday;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\NewCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnMale;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\NewCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnFemale;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\NewCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Nationality;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\NewCustomerWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Career;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/QuanLyKhachSan;component/newcustomerwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewCustomerWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.newCustomerWindow = ((QuanLyKhachSan.NewCustomerWindow)(target));
            return;
            case 2:
            this.CusName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.CusIdentity = ((System.Windows.Controls.TextBox)(target));
            
            #line 76 "..\..\NewCustomerWindow.xaml"
            this.CusIdentity.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputt);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Phone = ((System.Windows.Controls.TextBox)(target));
            
            #line 93 "..\..\NewCustomerWindow.xaml"
            this.Phone.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PreviewTextInputt);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Birthday = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.btnMale = ((System.Windows.Controls.RadioButton)(target));
            
            #line 129 "..\..\NewCustomerWindow.xaml"
            this.btnMale.Click += new System.Windows.RoutedEventHandler(this.btnMale_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnFemale = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.Nationality = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Career = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 184 "..\..\NewCustomerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 196 "..\..\NewCustomerWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

