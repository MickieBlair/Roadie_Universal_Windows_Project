﻿#pragma checksum "C:\Users\blair\Desktop\Roadie_UWP_MLB\Roadie_UWP_MLB\Views\Vehicles_Insurance.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ACB079911239D72E389EF4D11EF8561E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Roadie_UWP_MLB.Views
{
    partial class Add_Edit_Vehicles : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\Vehicles_Insurance.xaml line 117
                {
                    this.PageContent = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 3: // Views\Vehicles_Insurance.xaml line 356
                {
                    this.InsuranceCount = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Views\Vehicles_Insurance.xaml line 367
                {
                    this.InsuranceCompany = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Views\Vehicles_Insurance.xaml line 375
                {
                    this.PolicyNumber = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Views\Vehicles_Insurance.xaml line 395
                {
                    this.ExpInsDatePicker = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                }
                break;
            case 7: // Views\Vehicles_Insurance.xaml line 400
                {
                    this.Ins_Status = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // Views\Vehicles_Insurance.xaml line 410
                {
                    this.Ins_Button_Panel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 9: // Views\Vehicles_Insurance.xaml line 416
                {
                    this.UpdateIns_Btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.UpdateIns_Btn).Click += this.UpdateIns_Btn_Click;
                }
                break;
            case 10: // Views\Vehicles_Insurance.xaml line 430
                {
                    this.Ins_Delete_Btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Ins_Delete_Btn).Click += this.Ins_Delete_Btn_Click;
                }
                break;
            case 11: // Views\Vehicles_Insurance.xaml line 126
                {
                    this.VehicleCount = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Views\Vehicles_Insurance.xaml line 135
                {
                    this.vehicle_list = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.vehicle_list).SelectionChanged += this.vehicle_list_SelectionChanged;
                }
                break;
            case 13: // Views\Vehicles_Insurance.xaml line 157
                {
                    this.Button_Panel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 14: // Views\Vehicles_Insurance.xaml line 204
                {
                    this.Status = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // Views\Vehicles_Insurance.xaml line 215
                {
                    this.grpArea = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 16: // Views\Vehicles_Insurance.xaml line 219
                {
                    this.Title = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // Views\Vehicles_Insurance.xaml line 237
                {
                    this.Description = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 18: // Views\Vehicles_Insurance.xaml line 257
                {
                    this.TagNumber = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 19: // Views\Vehicles_Insurance.xaml line 276
                {
                    this.NumberOfSeats = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 20: // Views\Vehicles_Insurance.xaml line 292
                {
                    this.AddSave_Btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AddSave_Btn).Click += this.Save_Click;
                }
                break;
            case 21: // Views\Vehicles_Insurance.xaml line 305
                {
                    this.SaveEdit_Btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SaveEdit_Btn).Click += this.SaveEdit_Btn_Click;
                }
                break;
            case 22: // Views\Vehicles_Insurance.xaml line 318
                {
                    this.Remove_Btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Remove_Btn).Click += this.Remove_Btn_Click;
                }
                break;
            case 23: // Views\Vehicles_Insurance.xaml line 331
                {
                    global::Windows.UI.Xaml.Controls.Button element23 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element23).Click += this.Cancel_Click;
                }
                break;
            case 24: // Views\Vehicles_Insurance.xaml line 163
                {
                    this.Add_Btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Add_Btn).Click += this.Add_Btn_Click;
                }
                break;
            case 25: // Views\Vehicles_Insurance.xaml line 177
                {
                    this.Edit_Btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Edit_Btn).Click += this.Edit_Btn_Click;
                }
                break;
            case 26: // Views\Vehicles_Insurance.xaml line 191
                {
                    this.Delete_Btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Delete_Btn).Click += this.Delete_Btn_Click;
                }
                break;
            case 28: // Views\Vehicles_Insurance.xaml line 21
                {
                    this.Menu = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 29: // Views\Vehicles_Insurance.xaml line 30
                {
                    this.Expanded = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 30: // Views\Vehicles_Insurance.xaml line 31
                {
                    this.Home_Btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Home_Btn).Click += this.Home_Btn_Click;
                }
                break;
            case 31: // Views\Vehicles_Insurance.xaml line 44
                {
                    this.UpdateProfile_Btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.UpdateProfile_Btn).Click += this.UpdateProfile_Btn_Click;
                }
                break;
            case 32: // Views\Vehicles_Insurance.xaml line 57
                {
                    this.Vehicles_Btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 33: // Views\Vehicles_Insurance.xaml line 68
                {
                    this.SearchForCarpool_Btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SearchForCarpool_Btn).Click += this.SearchForCarpool_Btn_Click;
                }
                break;
            case 34: // Views\Vehicles_Insurance.xaml line 80
                {
                    this.CreateCarpool_Btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.CreateCarpool_Btn).Click += this.CreateCarpool_Btn_Click;
                }
                break;
            case 35: // Views\Vehicles_Insurance.xaml line 93
                {
                    this.Logout_Btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Logout_Btn).Click += this.Logout_Btn_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

