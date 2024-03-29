﻿#pragma checksum "..\..\FullInfoWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5A3D16EAE82C8C42B2F7CE313221C5C263CF6E9C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using WeatherApp;


namespace WeatherApp {
    
    
    /// <summary>
    /// FullInfoWindow
    /// </summary>
    public partial class FullInfoWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\FullInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\FullInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock nightTemperature;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\FullInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock nightFeelsLike;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\FullInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock nightWindSpeed;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\FullInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock nightWindDirrection;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\FullInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock morningTemperature;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\FullInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock morningFeelsLike;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\FullInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock morningWindSpeed;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\FullInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock morningWindDirrection;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\FullInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock dayTemperature;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\FullInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock dayFeelsLike;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\FullInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock dayWindSpeed;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\FullInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock dayWindDirrection;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\FullInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock eveningTemperature;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\FullInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock eveningFeelsLike;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\FullInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock eveningWindSpeed;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\FullInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock eveningWindDirrection;
        
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
            System.Uri resourceLocater = new System.Uri("/WeatherApp;component/fullinfowindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FullInfoWindow.xaml"
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
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\FullInfoWindow.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.nightTemperature = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.nightFeelsLike = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.nightWindSpeed = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.nightWindDirrection = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.morningTemperature = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.morningFeelsLike = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.morningWindSpeed = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.morningWindDirrection = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.dayTemperature = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.dayFeelsLike = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.dayWindSpeed = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.dayWindDirrection = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            this.eveningTemperature = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 15:
            this.eveningFeelsLike = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 16:
            this.eveningWindSpeed = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 17:
            this.eveningWindDirrection = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

