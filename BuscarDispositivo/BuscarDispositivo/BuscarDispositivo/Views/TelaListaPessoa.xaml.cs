﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuscarDispositivo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BuscarDispositivo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaListaPessoa : ContentPage
    {
        public TelaListaPessoa()
        {
            InitializeComponent();
            BindingContext = new TelaListaPessoaViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
