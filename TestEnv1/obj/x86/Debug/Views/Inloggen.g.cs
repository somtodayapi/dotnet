﻿#pragma checksum "C:\Users\ckara\source\repos\SOM\dotnet\TestEnv1\Views\Inloggen.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "66ECA709BC1FEB61D6B7B570DB3D87C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestEnv1.Views
{
    partial class Inloggen : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBox_PlaceholderText(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.PlaceholderText = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_PasswordBox_Password(global::Windows.UI.Xaml.Controls.PasswordBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Password = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_PasswordBox_PlaceholderText(global::Windows.UI.Xaml.Controls.PasswordBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.PlaceholderText = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_ContentControl_Content(global::Windows.UI.Xaml.Controls.ContentControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Content = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedItem(global::Windows.UI.Xaml.Controls.Primitives.Selector obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.SelectedItem = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ComboBox_PlaceholderText(global::Windows.UI.Xaml.Controls.ComboBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.PlaceholderText = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Inloggen_obj9_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IInloggen_Bindings
        {
            private global::SOMTodayUWP.Models.Instellingen dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj9;
            private global::Windows.UI.Xaml.Controls.TextBlock obj10;

            public Inloggen_obj9_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 9: // Views\Inloggen.xaml line 102
                        this.obj9 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 10: // Views\Inloggen.xaml line 103
                        this.obj10 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
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

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
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
                            (this.obj9.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::SOMTodayUWP.Models.Instellingen) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IInloggen_Bindings

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
                    this.dataRoot = (global::SOMTodayUWP.Models.Instellingen)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::SOMTodayUWP.Models.Instellingen obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_naam(obj.naam, phase);
                    }
                }
            }
            private void Update_naam(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Inloggen.xaml line 103
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj10, obj, null);
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Inloggen_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IInloggen_Bindings
        {
            private global::TestEnv1.Views.Inloggen dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::Windows.UI.Xaml.Controls.TextBox obj4;
            private global::Windows.UI.Xaml.Controls.PasswordBox obj5;
            private global::Windows.UI.Xaml.Controls.CheckBox obj6;
            private global::Windows.UI.Xaml.Controls.Button obj7;
            private global::Windows.UI.Xaml.Controls.ComboBox obj8;
            private global::Windows.UI.Xaml.Controls.ComboBox obj11;
            private global::Windows.UI.Xaml.Controls.TextBlock obj12;
            private global::Windows.UI.Xaml.Controls.TextBlock obj13;
            private global::Windows.UI.Xaml.Controls.TextBlock obj14;
            private global::Windows.UI.Xaml.Controls.Button obj15;

            private Inloggen_obj1_BindingsTracking bindingsTracking;

            public Inloggen_obj1_Bindings()
            {
                this.bindingsTracking = new Inloggen_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // Views\Inloggen.xaml line 60
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 4: // Views\Inloggen.xaml line 61
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        break;
                    case 5: // Views\Inloggen.xaml line 68
                        this.obj5 = (global::Windows.UI.Xaml.Controls.PasswordBox)target;
                        (this.obj5).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.PasswordBox.PasswordProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.ViewModel.Password = this.obj5.Password;
                            }
                        });
                        break;
                    case 6: // Views\Inloggen.xaml line 76
                        this.obj6 = (global::Windows.UI.Xaml.Controls.CheckBox)target;
                        break;
                    case 7: // Views\Inloggen.xaml line 83
                        this.obj7 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 8: // Views\Inloggen.xaml line 94
                        this.obj8 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        (this.obj8).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedItemProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.ViewModel.SelectedComboboxItem = (global::SOMTodayUWP.Models.Instellingen)this.obj8.SelectedItem;
                            }
                        });
                        break;
                    case 11: // Views\Inloggen.xaml line 52
                        this.obj11 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    case 12: // Views\Inloggen.xaml line 36
                        this.obj12 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 13: // Views\Inloggen.xaml line 37
                        this.obj13 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 14: // Views\Inloggen.xaml line 38
                        this.obj14 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 15: // Views\Inloggen.xaml line 39
                        this.obj15 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    default:
                        break;
                }
            }

            // IInloggen_Bindings

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
                    this.dataRoot = (global::TestEnv1.Views.Inloggen)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::TestEnv1.Views.Inloggen obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::TestEnv1.ViewModel.LoginViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_OrLogin(obj.OrLogin, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_UsernameBox(obj.UsernameBox, phase);
                        this.Update_ViewModel_Password(obj.Password, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_PasswordBox(obj.PasswordBox, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_RememberMe(obj.RememberMe, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Login_button(obj.Login_button, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_SelectedComboboxItem(obj.SelectedComboboxItem, phase);
                        this.Update_ViewModel_Schools(obj.Schools, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_ChooseSchool(obj.ChooseSchool, phase);
                        this.Update_ViewModel_ChooseLang(obj.ChooseLang, phase);
                        this.Update_ViewModel_Title(obj.Title, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Sub(obj.Sub, phase);
                        this.Update_ViewModel_Paragraph(obj.Paragraph, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Button_read(obj.Button_read, phase);
                    }
                }
            }
            private void Update_ViewModel_OrLogin(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Inloggen.xaml line 60
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                }
            }
            private void Update_ViewModel_UsernameBox(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Inloggen.xaml line 61
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_PlaceholderText(this.obj4, obj, null);
                }
            }
            private void Update_ViewModel_Password(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Inloggen.xaml line 68
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_PasswordBox_Password(this.obj5, obj, null);
                }
            }
            private void Update_ViewModel_PasswordBox(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Inloggen.xaml line 68
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_PasswordBox_PlaceholderText(this.obj5, obj, null);
                }
            }
            private void Update_ViewModel_RememberMe(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Inloggen.xaml line 76
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentControl_Content(this.obj6, obj, null);
                }
            }
            private void Update_ViewModel_Login_button(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Inloggen.xaml line 83
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentControl_Content(this.obj7, obj, null);
                }
            }
            private void Update_ViewModel_SelectedComboboxItem(global::SOMTodayUWP.Models.Instellingen obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Inloggen.xaml line 94
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedItem(this.obj8, obj, null);
                }
            }
            private void Update_ViewModel_Schools(global::System.Collections.ObjectModel.ObservableCollection<global::SOMTodayUWP.Models.Instellingen> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_Schools(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Inloggen.xaml line 94
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj8, obj, null);
                }
            }
            private void Update_ViewModel_ChooseSchool(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Inloggen.xaml line 94
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ComboBox_PlaceholderText(this.obj8, obj, null);
                }
            }
            private void Update_ViewModel_ChooseLang(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Inloggen.xaml line 52
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ComboBox_PlaceholderText(this.obj11, obj, null);
                }
            }
            private void Update_ViewModel_Title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Inloggen.xaml line 36
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj12, obj, null);
                }
            }
            private void Update_ViewModel_Sub(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Inloggen.xaml line 37
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj13, obj, null);
                }
            }
            private void Update_ViewModel_Paragraph(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Inloggen.xaml line 38
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj14, obj, null);
                }
            }
            private void Update_ViewModel_Button_read(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Inloggen.xaml line 39
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentControl_Content(this.obj15, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class Inloggen_obj1_BindingsTracking
            {
                private global::System.WeakReference<Inloggen_obj1_Bindings> weakRefToBindingObj; 

                public Inloggen_obj1_BindingsTracking(Inloggen_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<Inloggen_obj1_Bindings>(obj);
                }

                public Inloggen_obj1_Bindings TryGetBindingObject()
                {
                    Inloggen_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_ViewModel_Schools(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    Inloggen_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::TestEnv1.ViewModel.LoginViewModel obj = sender as global::TestEnv1.ViewModel.LoginViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_UsernameBox(obj.UsernameBox, DATA_CHANGED);
                                bindings.Update_ViewModel_Password(obj.Password, DATA_CHANGED);
                                bindings.Update_ViewModel_RememberMe(obj.RememberMe, DATA_CHANGED);
                                bindings.Update_ViewModel_SelectedComboboxItem(obj.SelectedComboboxItem, DATA_CHANGED);
                                bindings.Update_ViewModel_Schools(obj.Schools, DATA_CHANGED);
                                bindings.Update_ViewModel_Sub(obj.Sub, DATA_CHANGED);
                                bindings.Update_ViewModel_Paragraph(obj.Paragraph, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "UsernameBox":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_UsernameBox(obj.UsernameBox, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Password":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Password(obj.Password, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "RememberMe":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_RememberMe(obj.RememberMe, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "SelectedComboboxItem":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_SelectedComboboxItem(obj.SelectedComboboxItem, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Schools":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Schools(obj.Schools, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Sub":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Sub(obj.Sub, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Paragraph":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Paragraph(obj.Paragraph, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::TestEnv1.ViewModel.LoginViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::TestEnv1.ViewModel.LoginViewModel obj)
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
                public void PropertyChanged_ViewModel_Schools(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    Inloggen_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::SOMTodayUWP.Models.Instellingen> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::SOMTodayUWP.Models.Instellingen>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_ViewModel_Schools(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    Inloggen_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::SOMTodayUWP.Models.Instellingen> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::SOMTodayUWP.Models.Instellingen>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::SOMTodayUWP.Models.Instellingen> cache_ViewModel_Schools = null;
                public void UpdateChildListeners_ViewModel_Schools(global::System.Collections.ObjectModel.ObservableCollection<global::SOMTodayUWP.Models.Instellingen> obj)
                {
                    if (obj != cache_ViewModel_Schools)
                    {
                        if (cache_ViewModel_Schools != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_Schools).PropertyChanged -= PropertyChanged_ViewModel_Schools;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_ViewModel_Schools).CollectionChanged -= CollectionChanged_ViewModel_Schools;
                            cache_ViewModel_Schools = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_Schools = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_Schools;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_ViewModel_Schools;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\Inloggen.xaml line 13
                {
                    this.ViewModel = (global::TestEnv1.ViewModel.LoginViewModel)(target);
                }
                break;
            case 4: // Views\Inloggen.xaml line 61
                {
                    this.LoginUsernameTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Views\Inloggen.xaml line 68
                {
                    this.LoginPasswordPasswordBox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 6: // Views\Inloggen.xaml line 76
                {
                    this.RememberMeCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 7: // Views\Inloggen.xaml line 83
                {
                    this.LoginButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 8: // Views\Inloggen.xaml line 94
                {
                    this.School = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 11: // Views\Inloggen.xaml line 52
                {
                    global::Windows.UI.Xaml.Controls.ComboBox element11 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ComboBox)element11).SelectionChanged += this.ComboBox_SelectionChanged;
                }
                break;
            case 15: // Views\Inloggen.xaml line 39
                {
                    this.ReadMore = (global::Windows.UI.Xaml.Controls.Button)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\Inloggen.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Inloggen_obj1_Bindings bindings = new Inloggen_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 9: // Views\Inloggen.xaml line 102
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element9 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    Inloggen_obj9_Bindings bindings = new Inloggen_obj9_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element9.DataContext);
                    element9.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element9, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element9, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

