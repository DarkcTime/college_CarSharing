﻿#pragma checksum "..\..\..\..\View\Admin\Statistick.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "58B62A9A311BE9E032F120E8208280CA372ED236EA848495A65B19BC28DAD3C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CarSharing.View.Admin;
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


namespace CarSharing.View.Admin {
    
    
    /// <summary>
    /// Statistick
    /// </summary>
    public partial class Statistick : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\View\Admin\Statistick.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtNumberRent;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\View\Admin\Statistick.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtSumMonth;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\View\Admin\Statistick.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtDateStart;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\View\Admin\Statistick.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtDateEnd;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\View\Admin\Statistick.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtSum;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\View\Admin\Statistick.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ListRentForStatistick;
        
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
            System.Uri resourceLocater = new System.Uri("/CarSharing;component/view/admin/statistick.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Admin\Statistick.xaml"
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
            this.TxtNumberRent = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.TxtSumMonth = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TxtDateStart = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TxtDateEnd = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TxtSum = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.ListRentForStatistick = ((System.Windows.Controls.DataGrid)(target));
            
            #line 49 "..\..\..\..\View\Admin\Statistick.xaml"
            this.ListRentForStatistick.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectRentForStatistick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

