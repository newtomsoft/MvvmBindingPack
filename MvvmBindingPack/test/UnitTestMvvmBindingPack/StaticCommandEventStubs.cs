﻿// 
//  MVVM-WPF-NetCore Markup Binding Extensions.
//  Copyright © 2013-2014 Alexander Paskhin /paskhin@hotmail.co.uk/ All rights reserved.
// 
//
// Licensed under the Apache License, Version 2.0 (the "License"); you
// may not use this file except in compliance with the License. You may
// obtain a copy of the License at  http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or
// implied. See the License for the specific language governing permissions
// and limitations under the License.

using System;
using System.Windows;

namespace UnitTestMvvmBindingPack
{
    public static class StaticCommandEventStubs
    {
        static bool _buttonClickExternalCalled;
        static public bool ButtonClickExternalCalled
        {
            get { return _buttonClickExternalCalled; }
            set { _buttonClickExternalCalled = value; }
        }
        static public void ResetTestFlags()
        {
            _buttonClickExternalCalled = false;
            _executeButtonClickExternalCalled = false;
            _canExecuteButtonClickExternal = true;
        }

        static public void Button_Click_External(object sender, RoutedEventArgs e)
        {
            _buttonClickExternalCalled = true;
        }

        static public RoutedEventHandler ClickDelegate
        {
            get { return Button_Click_External; }
        }

        static bool _executeButtonClickExternalCalled;
        static public bool ExecuteButtonClickExternalCalled
        {
            get { return _executeButtonClickExternalCalled; }
            set { _executeButtonClickExternalCalled = value; }
        }

        static public void ExecuteButton_Click_External(object sender)
        {
            _executeButtonClickExternalCalled = true;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
        static public event Action IssueNotifyExecuteButtonChanged;
        static public void InvokeNotifyChanged()
        {
            IssueNotifyExecuteButtonChanged();
        }

        static bool _canExecuteButtonClickExternal = true;
        static public bool CanExecuteButtonClickExternalFlag
        {
            get { return _canExecuteButtonClickExternal; }
            set { _canExecuteButtonClickExternal = value; }
        }

        static public bool CanExecuteButton_Click_External(object sender)
        {
            return _canExecuteButtonClickExternal;
        }

    }
}
