﻿#pragma checksum "..\..\..\View\CustomerAdminWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1F586CA18DD768817497D6EEEC4669FF4FE7AEF4AFF38D3DF6A30E4E96657687"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using WPF_Project;
using WPF_Project.Converters;
using WPF_Project.Model;
using WPF_Project.ViewModel;


namespace WPF_Project {
    
    
    /// <summary>
    /// CustomerAdminWindow
    /// </summary>
    public partial class CustomerAdminWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\View\CustomerAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFilter;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\View\CustomerAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView trvCustomers;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\View\CustomerAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label nameLabel;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\View\CustomerAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameText;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\View\CustomerAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SurnameLabel;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\View\CustomerAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox surnameText;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\View\CustomerAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label mailLabel;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\View\CustomerAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox mailText;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\View\CustomerAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCustomer;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\View\CustomerAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbCustomer;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\View\CustomerAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCarBrand;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\View\CustomerAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbCarBrand;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\View\CustomerAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCarModel;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\View\CustomerAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textCarModel;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\View\CustomerAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCarPlate;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\View\CustomerAdminWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textCarPlate;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF-Project;component/view/customeradminwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\CustomerAdminWindow.xaml"
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
            this.txtFilter = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.trvCustomers = ((System.Windows.Controls.TreeView)(target));
            return;
            case 3:
            this.nameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.nameText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.SurnameLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.surnameText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.mailLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.mailText = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.lblCustomer = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.cmbCustomer = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.lblCarBrand = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.cmbCarBrand = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            this.lblCarModel = ((System.Windows.Controls.Label)(target));
            return;
            case 14:
            this.textCarModel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.lblCarPlate = ((System.Windows.Controls.Label)(target));
            return;
            case 16:
            this.textCarPlate = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

