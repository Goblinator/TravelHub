﻿#pragma checksum "..\..\..\Окна\Каталог_номеров.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FACA27DB56B14E0600E1678AAC535490DE21DB446EA1F7DDA15B6FD54066D879"
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
using TravelHub;


namespace TravelHub {
    
    
    /// <summary>
    /// Каталог_номеров
    /// </summary>
    public partial class Каталог_номеров : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Окна\Каталог_номеров.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView productsListView;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Окна\Каталог_номеров.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu Menu;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Окна\Каталог_номеров.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClearBasket;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Окна\Каталог_номеров.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Namesearch;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Окна\Каталог_номеров.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchInput;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Окна\Каталог_номеров.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBasket;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Окна\Каталог_номеров.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
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
            System.Uri resourceLocater = new System.Uri("/TravelHub;component/%d0%9e%d0%ba%d0%bd%d0%b0/%d0%9a%d0%b0%d1%82%d0%b0%d0%bb%d0%b" +
                    "e%d0%b3_%d0%bd%d0%be%d0%bc%d0%b5%d1%80%d0%be%d0%b2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Окна\Каталог_номеров.xaml"
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
            this.productsListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.Menu = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 3:
            
            #line 22 "..\..\..\Окна\Каталог_номеров.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ClearBasket = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\Окна\Каталог_номеров.xaml"
            this.ClearBasket.Click += new System.Windows.RoutedEventHandler(this.ClearBusket_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Namesearch = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.SearchInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\Окна\Каталог_номеров.xaml"
            this.SearchInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AddBasket = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Окна\Каталог_номеров.xaml"
            this.AddBasket.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Окна\Каталог_номеров.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.BackButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

