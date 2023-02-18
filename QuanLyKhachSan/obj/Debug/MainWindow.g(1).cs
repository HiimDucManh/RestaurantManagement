﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D59D52EF3EF79D5CCEC35F7CCB8ECB3BED233C4850457D1D97FCAE832A7AE467"
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
using QuanLyKhachSan.UserControlQL;
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal QuanLyKhachSan.MainWindow Mainwindow;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Main;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainContentWindow;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMenu;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOpenMenu;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCloseMenu;
        
        #line default
        #line hidden
        
        
        #line 139 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewMenu;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyKhachSan;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.Mainwindow = ((QuanLyKhachSan.MainWindow)(target));
            return;
            case 2:
            
            #line 61 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Move_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 90 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonMinimize_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 93 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonMaximize_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 96 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonClose_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Main = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.MainContentWindow = ((System.Windows.Controls.Frame)(target));
            return;
            case 8:
            this.GridMenu = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.ButtonOpenMenu = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\MainWindow.xaml"
            this.ButtonOpenMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonOpenMenu_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ButtonCloseMenu = ((System.Windows.Controls.Button)(target));
            
            #line 133 "..\..\MainWindow.xaml"
            this.ButtonCloseMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonCloseMenu_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ListViewMenu = ((System.Windows.Controls.ListView)(target));
            return;
            case 12:
            
            #line 142 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.btnroomDoubleClick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 148 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.btncustomerDoubleClick);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 154 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.btnemployeesDoubleClick);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 166 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListViewItem)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.btnReportDoubleClick);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 179 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.ListView)(target)).MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.btnUserDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
