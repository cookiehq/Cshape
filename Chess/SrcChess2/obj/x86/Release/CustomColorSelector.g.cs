﻿#pragma checksum "..\..\..\CustomColorSelector.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9BAB59CEE0CDEC4B2B2DA9D5791EE9E16EF9D480"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using SrcChess2;
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


namespace SrcChess2 {
    
    
    /// <summary>
    /// ColorPicker
    /// </summary>
    public partial class ColorPicker : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\CustomColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander epDefaultcolor;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\CustomColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox DefaultPicker;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\CustomColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander epCustomcolor;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\CustomColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\CustomColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas CanColor;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\CustomColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse EpPointer;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\CustomColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAlpha;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\CustomColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtR;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\CustomColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtG;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\CustomColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtB;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\CustomColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAll;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\CustomColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblPreview;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\CustomColorSelector.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider SdA;
        
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
            System.Uri resourceLocater = new System.Uri("/SrcChess2;component/customcolorselector.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CustomColorSelector.xaml"
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
            this.epDefaultcolor = ((System.Windows.Controls.Expander)(target));
            
            #line 9 "..\..\..\CustomColorSelector.xaml"
            this.epDefaultcolor.PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.epDefaultcolor_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DefaultPicker = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.epCustomcolor = ((System.Windows.Controls.Expander)(target));
            
            #line 25 "..\..\..\CustomColorSelector.xaml"
            this.epCustomcolor.Expanded += new System.Windows.RoutedEventHandler(this.epCustomcolor_Expanded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.CanColor = ((System.Windows.Controls.Canvas)(target));
            return;
            case 6:
            this.EpPointer = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 7:
            this.txtAlpha = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtR = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtG = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.txtB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.txtAll = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.lblPreview = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.SdA = ((System.Windows.Controls.Slider)(target));
            
            #line 90 "..\..\..\CustomColorSelector.xaml"
            this.SdA.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.SdA_ValueChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

