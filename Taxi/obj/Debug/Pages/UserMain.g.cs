﻿#pragma checksum "..\..\..\Pages\UserMain.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AF92EE565DE148545BEE3CB3DDE94B9ED20EC2555C34D34E4C804E8BC63F2F9A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Taxi;


namespace Taxi {
    
    
    /// <summary>
    /// UserMain
    /// </summary>
    public partial class UserMain : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\Pages\UserMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RequestSearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\UserMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RequestLeastToMost;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\UserMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RequestMostToLeast;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\UserMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RequestDataGrid;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Pages\UserMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TaxiSearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Pages\UserMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton TaxiLeastToMost;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Pages\UserMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton TaxiMostToLeast;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\Pages\UserMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TaxiDataGrid;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\Pages\UserMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddRequestButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Taxi;component/pages/usermain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\UserMain.xaml"
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
            this.RequestSearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\Pages\UserMain.xaml"
            this.RequestSearchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RequestSearchTextBox_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RequestLeastToMost = ((System.Windows.Controls.RadioButton)(target));
            
            #line 37 "..\..\..\Pages\UserMain.xaml"
            this.RequestLeastToMost.Checked += new System.Windows.RoutedEventHandler(this.RequestLeastToMost_OnChecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RequestMostToLeast = ((System.Windows.Controls.RadioButton)(target));
            
            #line 39 "..\..\..\Pages\UserMain.xaml"
            this.RequestMostToLeast.Checked += new System.Windows.RoutedEventHandler(this.RequestMostToLeast_OnChecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RequestDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.TaxiSearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 76 "..\..\..\Pages\UserMain.xaml"
            this.TaxiSearchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TaxiSearchTextBox_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TaxiLeastToMost = ((System.Windows.Controls.RadioButton)(target));
            
            #line 78 "..\..\..\Pages\UserMain.xaml"
            this.TaxiLeastToMost.Checked += new System.Windows.RoutedEventHandler(this.TaxiLeastToMost_OnChecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TaxiMostToLeast = ((System.Windows.Controls.RadioButton)(target));
            
            #line 80 "..\..\..\Pages\UserMain.xaml"
            this.TaxiMostToLeast.Checked += new System.Windows.RoutedEventHandler(this.TaxiMostToLeast_OnChecked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TaxiDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 9:
            this.AddRequestButton = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\Pages\UserMain.xaml"
            this.AddRequestButton.Click += new System.Windows.RoutedEventHandler(this.AddRequestButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

