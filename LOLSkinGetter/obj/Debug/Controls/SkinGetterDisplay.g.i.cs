﻿#pragma checksum "..\..\..\Controls\SkinGetterDisplay.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A4CB06FEDF18C61FEB509FDCD3F0B1DC49F3D7CD3A12541554B4720C67A3F1CB"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Ay.Framework.WPF.MVC.AyMarkupExtension;
using LOLSkinGetter;
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


namespace LOLSkinGetter {
    
    
    /// <summary>
    /// SkinGetterDisplay
    /// </summary>
    public partial class SkinGetterDisplay : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\Controls\SkinGetterDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel sp_pagination;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Controls\SkinGetterDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image leftOpr;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Controls\SkinGetterDisplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image rightOpr;
        
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
            System.Uri resourceLocater = new System.Uri("/LOLSkinGetter;component/controls/skingetterdisplay.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\SkinGetterDisplay.xaml"
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
            this.sp_pagination = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.leftOpr = ((System.Windows.Controls.Image)(target));
            
            #line 91 "..\..\..\Controls\SkinGetterDisplay.xaml"
            this.leftOpr.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.leftOpr_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rightOpr = ((System.Windows.Controls.Image)(target));
            
            #line 99 "..\..\..\Controls\SkinGetterDisplay.xaml"
            this.rightOpr.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.rightOpr_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
