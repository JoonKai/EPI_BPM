﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using HellsysLibrary.Extensions;

namespace HellsysControls.Commons
{
    public class ComboBoxColorManager
    {
        // Fields
        private static Brush _newBackground;
        private static Brush _newBorderBrush;

        // Properties
        public static readonly DependencyProperty BackgroundProperty =
            DependencyProperty.RegisterAttached("Background", typeof(Brush), typeof(ComboBoxColorManager), new UIPropertyMetadata(null, BackgroundChanged));


        public static readonly DependencyProperty BorderBrushProperty =
           DependencyProperty.RegisterAttached("BorderBrush", typeof(Brush), typeof(ComboBoxColorManager), new UIPropertyMetadata(null, BorderBrushChanged));


        // Methods
        private static void AddEvents(DependencyObject d, DependencyPropertyChangedEventArgs e, Action<Brush> brushCallBack)
        {
            ComboBox cmb = d as ComboBox;
            if (cmb == null) return;

            if (e.NewValue != e.OldValue)
            {
                brushCallBack?.Invoke((Brush)e.NewValue);

                cmb.Loaded -= Cmb_Loaded;
                cmb.Unloaded -= Cmb_Unloaded;
                cmb.Loaded += Cmb_Loaded;
                cmb.Unloaded += Cmb_Unloaded;
            }
        }

        public static Brush GetBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(BackgroundProperty);
        }

        public static void SetBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(BackgroundProperty, value);
        }

        public static Brush GetBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(BorderBrushProperty);
        }

        public static void SetBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(BorderBrushProperty, value);
        }

        // Events
        private static void BackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            AddEvents(d, e, brush => _newBackground = brush);
        }

        private static void BorderBrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            AddEvents(d, e, brush => _newBorderBrush = brush);
        }

        private static void Cmb_Unloaded(object sender, RoutedEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            cmb.Loaded -= Cmb_Loaded;
            cmb.Unloaded -= Cmb_Unloaded;
            _newBackground = null;
            _newBorderBrush = null;
        }

        private static void Cmb_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if (_newBackground != null)
            {
                cmb.SetBackground(_newBackground);
            }
            if (_newBorderBrush != null)
            {
                cmb.SetBorderBrush(_newBorderBrush);
            }
        }
    }
}
