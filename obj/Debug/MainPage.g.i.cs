﻿#pragma checksum "C:\Users\chubas\documents\visual studio 2010\Projects\GitRoar\GitRoar\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D4FD5D161AD5D2827175B863249611D4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace GitRoar {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.TextBox usernameTextbox;
        
        internal System.Windows.Controls.TextBox repositoryTextbox;
        
        internal System.Windows.Controls.Button trackRepoButton;
        
        internal System.Windows.Controls.Button seeTrackedReposButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/GitRoar;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.usernameTextbox = ((System.Windows.Controls.TextBox)(this.FindName("usernameTextbox")));
            this.repositoryTextbox = ((System.Windows.Controls.TextBox)(this.FindName("repositoryTextbox")));
            this.trackRepoButton = ((System.Windows.Controls.Button)(this.FindName("trackRepoButton")));
            this.seeTrackedReposButton = ((System.Windows.Controls.Button)(this.FindName("seeTrackedReposButton")));
        }
    }
}

