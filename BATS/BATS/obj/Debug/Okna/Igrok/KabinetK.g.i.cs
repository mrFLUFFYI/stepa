﻿#pragma checksum "..\..\..\..\Okna\Igrok\KabinetK.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4720339BF539CEC2D4A18963CD5D89C28A4765211BA497A2B0FBEA169C791F53"
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
    /// KabinetK
    /// </summary>
    public partial class KabinetK : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Okna\Igrok\KabinetK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Vihod;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Okna\Igrok\KabinetK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid table;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Okna\Igrok\KabinetK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button izmenit;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Okna\Igrok\KabinetK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginTxt;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Okna\Igrok\KabinetK.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ParolTxt;
        
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
            System.Uri resourceLocater = new System.Uri("/BATS;component/okna/igrok/kabinetk.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Okna\Igrok\KabinetK.xaml"
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
            
            #line 8 "..\..\..\..\Okna\Igrok\KabinetK.xaml"
            ((BATS.KabinetK)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 8 "..\..\..\..\Okna\Igrok\KabinetK.xaml"
            ((BATS.KabinetK)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Vihod = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\..\Okna\Igrok\KabinetK.xaml"
            this.Vihod.Click += new System.Windows.RoutedEventHandler(this.Vihod_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.table = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.izmenit = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\Okna\Igrok\KabinetK.xaml"
            this.izmenit.Click += new System.Windows.RoutedEventHandler(this.izmenit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LoginTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 62 "..\..\..\..\Okna\Igrok\KabinetK.xaml"
            this.LoginTxt.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Txt2_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ParolTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 63 "..\..\..\..\Okna\Igrok\KabinetK.xaml"
            this.ParolTxt.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Txt2_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

