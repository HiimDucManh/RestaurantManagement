﻿#pragma checksum "..\..\PrintBillWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "99EC999D717898BB58F6BC7CB729CC5A104BD56372272EAC9376A2A32279FEB2"
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
using QuanLyKhachSan.ViewModel;
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
    /// PrintBillWindow
    /// </summary>
    public partial class PrintBillWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\PrintBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal QuanLyKhachSan.PrintBillWindow printBillWindow;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\PrintBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid print;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\PrintBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock cusName;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\PrintBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock cusID;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\PrintBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock dateBill;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\PrintBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock invoiceNo;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\PrintBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listLV;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\PrintBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn nameCL;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\PrintBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn priceCL;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\PrintBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock price;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\PrintBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exit;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyKhachSan;component/printbillwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\PrintBillWindow.xaml"
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
            this.printBillWindow = ((QuanLyKhachSan.PrintBillWindow)(target));
            
            #line 13 "..\..\PrintBillWindow.xaml"
            this.printBillWindow.Loaded += new System.Windows.RoutedEventHandler(this.printBillWindow_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 16 "..\..\PrintBillWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.print = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.cusName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.cusID = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.dateBill = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.invoiceNo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.listLV = ((System.Windows.Controls.ListView)(target));
            return;
            case 9:
            this.nameCL = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 10:
            this.priceCL = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 11:
            this.price = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.exit = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\PrintBillWindow.xaml"
            this.exit.Click += new System.Windows.RoutedEventHandler(this.exit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

