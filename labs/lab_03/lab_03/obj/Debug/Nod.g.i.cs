﻿#pragma checksum "..\..\Nod.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EDF8CFB029303AA32399139BA68424916E44A9F1"
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
using lab_03;


namespace lab_03 {
    
    
    /// <summary>
    /// Nod
    /// </summary>
    public partial class Nod : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\Nod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox forTwoFirst;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Nod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox forTwoSecond;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Nod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelForTwo;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Nod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonForTwo;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Nod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox forThreeFirst;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Nod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox forThreeSecond;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Nod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox forThreeThird;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Nod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelForThree;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Nod.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonForThree;
        
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
            System.Uri resourceLocater = new System.Uri("/lab_03;component/nod.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Nod.xaml"
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
            this.forTwoFirst = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.forTwoSecond = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.labelForTwo = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.buttonForTwo = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\Nod.xaml"
            this.buttonForTwo.Click += new System.Windows.RoutedEventHandler(this.buttonForTwo_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.forThreeFirst = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.forThreeSecond = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.forThreeThird = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.labelForThree = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.buttonForThree = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\Nod.xaml"
            this.buttonForThree.Click += new System.Windows.RoutedEventHandler(this.buttonForThree_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

