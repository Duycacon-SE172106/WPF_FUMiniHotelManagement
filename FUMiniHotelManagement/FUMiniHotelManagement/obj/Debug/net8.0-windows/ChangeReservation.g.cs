﻿#pragma checksum "..\..\..\ChangeReservation.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D119580DA65F9DB1B052FEF0DF62F0652FCB1C58"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FUMiniHotelManagement;
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


namespace FUMiniHotelManagement {
    
    
    /// <summary>
    /// ChangeReservation
    /// </summary>
    public partial class ChangeReservation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\..\ChangeReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearch;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\ChangeReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbRoomNumber;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\ChangeReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCustomerId;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\ChangeReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txtBookingDate;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\ChangeReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txtStartDate;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\ChangeReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker txtEndDate;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\ChangeReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtActualPrice;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\ChangeReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTotalPrice;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\ChangeReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\ChangeReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\ChangeReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDelete;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\ChangeReservation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FUMiniHotelManagement;component/changereservation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ChangeReservation.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtSearch = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            
            #line 44 "..\..\..\ChangeReservation.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbRoomNumber = ((System.Windows.Controls.ComboBox)(target));
            
            #line 47 "..\..\..\ChangeReservation.xaml"
            this.cmbRoomNumber.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbRoomNumber_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtCustomerId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtBookingDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.txtStartDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 56 "..\..\..\ChangeReservation.xaml"
            this.txtStartDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.txtStartDate_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtEndDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 59 "..\..\..\ChangeReservation.xaml"
            this.txtEndDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.txtEndDate_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.txtActualPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtTotalPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\ChangeReservation.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.UpdateButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\ChangeReservation.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.btnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\ChangeReservation.xaml"
            this.btnDelete.Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\ChangeReservation.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.CancelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

