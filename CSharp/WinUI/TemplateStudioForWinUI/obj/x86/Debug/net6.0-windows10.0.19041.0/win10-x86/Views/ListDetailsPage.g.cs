﻿#pragma checksum "Q:\C#\WinUI\TemplateStudioForWinUI\Views\ListDetailsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5161F30FFB2008C7D016FDD3555CA05063837F2DD22D3B6228517B49E362789C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TemplateStudioForWinUI.Views
{
    partial class ListDetailsPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Microsoft.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_CommunityToolkit_WinUI_UI_Controls_ListDetailsView_SelectedItem(global::CommunityToolkit.WinUI.UI.Controls.ListDetailsView obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedItem = value;
            }
            public static void Set_Microsoft_UI_Xaml_Controls_FontIcon_Glyph(global::Microsoft.UI.Xaml.Controls.FontIcon obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Glyph = value ?? global::System.String.Empty;
            }
            public static void Set_Microsoft_UI_Xaml_Automation_AutomationProperties_Name(global::Microsoft.UI.Xaml.DependencyObject obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                global::Microsoft.UI.Xaml.Automation.AutomationProperties.SetName(obj, value);
            }
            public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(global::Microsoft.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ListDetailsPage_obj6_Bindings :
            global::Microsoft.UI.Xaml.IDataTemplateExtension,
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IListDetailsPage_Bindings
        {
            private global::TemplateStudioForWinUI.Core.Models.SampleOrder dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj6;
            private global::Microsoft.UI.Xaml.Controls.FontIcon obj7;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj8;
            private global::Microsoft.UI.Xaml.Controls.TextBlock obj9;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj7GlyphDisabled = false;
            private static bool isobj7NameDisabled = false;
            private static bool isobj8TextDisabled = false;
            private static bool isobj9TextDisabled = false;

            public ListDetailsPage_obj6_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 22 && columnNumber == 21)
                {
                    isobj7GlyphDisabled = true;
                }
                else if (lineNumber == 23 && columnNumber == 21)
                {
                    isobj7NameDisabled = true;
                }
                else if (lineNumber == 28 && columnNumber == 32)
                {
                    isobj8TextDisabled = true;
                }
                else if (lineNumber == 29 && columnNumber == 32)
                {
                    isobj9TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6: // Views\ListDetailsPage.xaml line 13
                        this.obj6 = new global::System.WeakReference(global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target));
                        break;
                    case 7: // Views\ListDetailsPage.xaml line 18
                        this.obj7 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.FontIcon>(target);
                        break;
                    case 8: // Views\ListDetailsPage.xaml line 28
                        this.obj8 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    case 9: // Views\ListDetailsPage.xaml line 29
                        this.obj9 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            public void DataContextChangedHandler(global::Microsoft.UI.Xaml.FrameworkElement sender, global::Microsoft.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Microsoft.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj6.Target as global::Microsoft.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_(global::WinRT.CastExtensions.As<global::TemplateStudioForWinUI.Core.Models.SampleOrder>(item), 1 << phase);
            }

            public void Recycle()
            {
            }

            // IListDetailsPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::TemplateStudioForWinUI.Core.Models.SampleOrder>(newDataRoot);
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::TemplateStudioForWinUI.Core.Models.SampleOrder obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Symbol(obj.Symbol, phase);
                        this.Update_SymbolName(obj.SymbolName, phase);
                        this.Update_Company(obj.Company, phase);
                        this.Update_Status(obj.Status, phase);
                    }
                }
            }
            private void Update_Symbol(global::System.Char obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ListDetailsPage.xaml line 18
                    if (!isobj7GlyphDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_FontIcon_Glyph(this.obj7, obj.ToString(), null);
                    }
                }
            }
            private void Update_SymbolName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ListDetailsPage.xaml line 18
                    if (!isobj7NameDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Automation_AutomationProperties_Name(this.obj7, obj, null);
                    }
                }
            }
            private void Update_Company(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ListDetailsPage.xaml line 28
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj, null);
                    }
                }
            }
            private void Update_Status(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ListDetailsPage.xaml line 29
                    if (!isobj9TextDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(this.obj9, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ListDetailsPage_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IListDetailsPage_Bindings
        {
            private global::TemplateStudioForWinUI.Views.ListDetailsPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::CommunityToolkit.WinUI.UI.Controls.ListDetailsView obj11;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj11ItemsSourceDisabled = false;
            private static bool isobj11SelectedItemDisabled = false;

            private ListDetailsPage_obj1_BindingsTracking bindingsTracking;

            public ListDetailsPage_obj1_Bindings()
            {
                this.bindingsTracking = new ListDetailsPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 69 && columnNumber == 13)
                {
                    isobj11ItemsSourceDisabled = true;
                }
                else if (lineNumber == 73 && columnNumber == 13)
                {
                    isobj11SelectedItemDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 11: // Views\ListDetailsPage.xaml line 62
                        this.obj11 = global::WinRT.CastExtensions.As<global::CommunityToolkit.WinUI.UI.Controls.ListDetailsView>(target);
                        this.bindingsTracking.RegisterTwoWayListener_11(this.obj11);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IListDetailsPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::TemplateStudioForWinUI.Views.ListDetailsPage>(newDataRoot);
                    return true;
                }
                return false;
            }

            public void Activated(object obj, global::Microsoft.UI.Xaml.WindowActivatedEventArgs data)
            {
                this.Initialize();
            }

            public void Loading(global::Microsoft.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::TemplateStudioForWinUI.Views.ListDetailsPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::TemplateStudioForWinUI.ViewModels.ListDetailsViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_SampleItems(obj.SampleItems, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Selected(obj.Selected, phase);
                    }
                }
            }
            private void Update_ViewModel_SampleItems(global::System.Collections.ObjectModel.ObservableCollection<global::TemplateStudioForWinUI.Core.Models.SampleOrder> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\ListDetailsPage.xaml line 62
                    if (!isobj11ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj11, obj, null);
                    }
                }
            }
            private void Update_ViewModel_Selected(global::TemplateStudioForWinUI.Core.Models.SampleOrder obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\ListDetailsPage.xaml line 62
                    if (!isobj11SelectedItemDisabled)
                    {
                        XamlBindingSetters.Set_CommunityToolkit_WinUI_UI_Controls_ListDetailsView_SelectedItem(this.obj11, obj, null);
                    }
                }
            }
            private void UpdateTwoWay_11_SelectedItem()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.ViewModel != null)
                        {
                            this.dataRoot.ViewModel.Selected = (global::TemplateStudioForWinUI.Core.Models.SampleOrder)this.obj11.SelectedItem;
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ListDetailsPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<ListDetailsPage_obj1_Bindings> weakRefToBindingObj; 

                public ListDetailsPage_obj1_BindingsTracking(ListDetailsPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ListDetailsPage_obj1_Bindings>(obj);
                }

                public ListDetailsPage_obj1_Bindings TryGetBindingObject()
                {
                    ListDetailsPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    ListDetailsPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::TemplateStudioForWinUI.ViewModels.ListDetailsViewModel obj = sender as global::TemplateStudioForWinUI.ViewModels.ListDetailsViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_Selected(obj.Selected, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Selected":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Selected(obj.Selected, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::TemplateStudioForWinUI.ViewModels.ListDetailsViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::TemplateStudioForWinUI.ViewModels.ListDetailsViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
                public void RegisterTwoWayListener_11(global::CommunityToolkit.WinUI.UI.Controls.ListDetailsView sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::CommunityToolkit.WinUI.UI.Controls.ListDetailsView.SelectedItemProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_11_SelectedItem();
                        }
                    });
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 10: // Views\ListDetailsPage.xaml line 61
                {
                    this.ContentArea = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 11: // Views\ListDetailsPage.xaml line 62
                {
                    this.ListDetailsViewControl = global::WinRT.CastExtensions.As<global::CommunityToolkit.WinUI.UI.Controls.ListDetailsView>(target);
                    ((global::CommunityToolkit.WinUI.UI.Controls.ListDetailsView)this.ListDetailsViewControl).ViewStateChanged += this.OnViewStateChanged;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\ListDetailsPage.xaml line 1
                {                    
                    global::Microsoft.UI.Xaml.Controls.Page element1 = (global::Microsoft.UI.Xaml.Controls.Page)target;
                    ListDetailsPage_obj1_Bindings bindings = new ListDetailsPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 6: // Views\ListDetailsPage.xaml line 13
                {                    
                    global::Microsoft.UI.Xaml.Controls.Grid element6 = (global::Microsoft.UI.Xaml.Controls.Grid)target;
                    ListDetailsPage_obj6_Bindings bindings = new ListDetailsPage_obj6_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element6.DataContext);
                    element6.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Microsoft.UI.Xaml.DataTemplate.SetExtensionInstance(element6, bindings);
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element6, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

