﻿#pragma checksum "..\..\..\Sides Wind Menu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "682A5D0EFA624D61C074D94EECACA22C195917F1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using WAWA_ORDER;


namespace WAWA_ORDER {
    
    
    /// <summary>
    /// Sides_Wind_Menu
    /// </summary>
    public partial class Sides_Wind_Menu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Sides Wind Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lstvSide_menu;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Sides Wind Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstSide_Receipt;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Sides Wind Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRemove_Side_Item;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Sides Wind Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose_side;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Sides Wind Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCalcSideWin1;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Sides Wind Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgSide1;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Sides Wind Menu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgSide2;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WAWA ORDER;V1.0.0.0;component/sides%20wind%20menu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Sides Wind Menu.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lstvSide_menu = ((System.Windows.Controls.ListView)(target));
            
            #line 10 "..\..\..\Sides Wind Menu.xaml"
            this.lstvSide_menu.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lstvBreakfast_menu_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lstSide_Receipt = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.btnRemove_Side_Item = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Sides Wind Menu.xaml"
            this.btnRemove_Side_Item.Click += new System.Windows.RoutedEventHandler(this.btnRemove_Item_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnClose_side = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Sides Wind Menu.xaml"
            this.btnClose_side.Click += new System.Windows.RoutedEventHandler(this.btnClose_side_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnCalcSideWin1 = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Sides Wind Menu.xaml"
            this.btnCalcSideWin1.Click += new System.Windows.RoutedEventHandler(this.btnCalcSideWin1_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.imgSide1 = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.imgSide2 = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
