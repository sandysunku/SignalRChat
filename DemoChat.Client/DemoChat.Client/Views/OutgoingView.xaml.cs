﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoChat.Client.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OutgoingView : ViewCell
    {
        public OutgoingView()
        {
            InitializeComponent();
        }
    }
}