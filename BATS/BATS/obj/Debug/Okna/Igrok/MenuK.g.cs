﻿#pragma checksum "..\..\..\..\Okna\Igrok\MenuK.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EE4C73D8CA3BE54EB17A980AA8C22381E37017287E7531942B95708B39CA7EE0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BATS;
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


namespace BATS {
    
    
    /// <summary>
    /// MenuK
    /// </summary>
    public partial class MenuK : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Okna\Igrok\MenuK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Kabinet;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Okna\Igrok\MenuK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Matchi;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Okna\Igrok\MenuK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Vihod;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\Okna\Igrok\MenuK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Turnir;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\Okna\Igrok\MenuK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Soobsheniya;
        
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
            System.Uri resourceLocater = new System.Uri("/BATS;component/okna/igrok/menuk.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Okna\Igrok\MenuK.xaml"
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
            
            #line 8 "..\..\..\..\Okna\Igrok\MenuK.xaml"
            ((BATS.MenuK)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Kabinet = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\Okna\Igrok\MenuK.xaml"
            this.Kabinet.Click += new System.Windows.RoutedEventHandler(this.Kabinet_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Matchi = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\Okna\Igrok\MenuK.xaml"
            this.Matchi.Click += new System.Windows.RoutedEventHandler(this.Matchi_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Vihod = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\Okna\Igrok\MenuK.xaml"
            this.Vihod.Click += new System.Windows.RoutedEventHandler(this.Vihod_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Turnir = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\Okna\Igrok\MenuK.xaml"
            this.Turnir.Click += new System.Windows.RoutedEventHandler(this.Turnir_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Soobsheniya = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\Okna\Igrok\MenuK.xaml"
            this.Soobsheniya.Click += new System.Windows.RoutedEventHandler(this.Soobsheniya_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

