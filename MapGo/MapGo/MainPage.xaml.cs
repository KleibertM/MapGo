﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace MapGo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Pin MiUbi = new Pin()
            {
                Type = PinType.Place,
                Label = "Mi Ubicacion",
                Address = "Av. Globo Terráqueo 3512, San Martín de Porres 15311",
                Position = new Position(-12.000521750624953, -77.06209627111522),
                Tag = "id_miubi",
            };

            map.Pins.Add(MiUbi);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(MiUbi.Position, Distance.FromMeters(500)));
        }
    }
}
