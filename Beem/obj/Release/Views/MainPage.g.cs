﻿#pragma checksum "C:\Users\Dennis\Documents\GitHub\beem\Beem\Views\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CF9ACB3E329D3EC28B362B33B5A4547B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Live.Controls;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
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


namespace Beem.Views {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Live.Controls.SignInButton btnSignIn;
        
        internal System.Windows.Controls.Grid grdLoading;
        
        internal Microsoft.Phone.Controls.PivotItem pvtRecorded;
        
        internal System.Windows.Controls.Grid grdUpload;
        
        internal Microsoft.Phone.Shell.ApplicationBar appBar;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnRefreshStationList;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnNowPlaying;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem btnAbout;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem btnSettings;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Beem;component/Views/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.btnSignIn = ((Microsoft.Live.Controls.SignInButton)(this.FindName("btnSignIn")));
            this.grdLoading = ((System.Windows.Controls.Grid)(this.FindName("grdLoading")));
            this.pvtRecorded = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("pvtRecorded")));
            this.grdUpload = ((System.Windows.Controls.Grid)(this.FindName("grdUpload")));
            this.appBar = ((Microsoft.Phone.Shell.ApplicationBar)(this.FindName("appBar")));
            this.btnRefreshStationList = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnRefreshStationList")));
            this.btnNowPlaying = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnNowPlaying")));
            this.btnAbout = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("btnAbout")));
            this.btnSettings = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("btnSettings")));
        }
    }
}

