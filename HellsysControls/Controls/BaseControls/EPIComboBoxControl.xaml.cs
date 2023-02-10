﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HellsysControls.Controls.BaseControls
{
    /// <summary>
    /// EPIComboBoxControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class EPIComboBoxControl : UserControl
    {
        public EPIComboBoxControl()
        {
            InitializeComponent();
        }
        #region Static Properties
        public static readonly DependencyProperty IsEditableProperty =
            DependencyProperty.Register("IsEditable", typeof(bool), typeof(EPIComboBoxControl), new PropertyMetadata(null));
        public static readonly DependencyProperty ValidatingProperty =
            DependencyProperty.Register("Validating", typeof(bool), typeof(EPIComboBoxControl), new PropertyMetadata(null));
        public static new readonly DependencyProperty BorderBrushProperty =
            DependencyProperty.Register("BorderBrush", typeof(Brush), typeof(EPIComboBoxControl), new UIPropertyMetadata(Brushes.SkyBlue));
        public static new readonly DependencyProperty BorderThicknessProperty =
            DependencyProperty.Register("BorderThickness", typeof(Thickness), typeof(EPIComboBoxControl), new UIPropertyMetadata(new Thickness(1)));
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(EPIComboBoxControl), new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public static readonly DependencyProperty WaterMarkTextProperty =
          DependencyProperty.Register("WaterMarkText", typeof(string), typeof(EPIComboBoxControl), new PropertyMetadata(null));
        public static readonly DependencyProperty WaterMarkTextColorProperty =
           DependencyProperty.Register("WaterMarkTextColor", typeof(Brush), typeof(EPIComboBoxControl), new UIPropertyMetadata(Brushes.Gray));
        public static readonly DependencyProperty ItemContainerStyleProperty =
           DependencyProperty.Register("ItemContainerStyle", typeof(Style), typeof(EPIComboBoxControl), new PropertyMetadata(null));
        public static readonly DependencyProperty ItemsSourceProperty =
          DependencyProperty.Register("ItemsSource", typeof(IEnumerable), typeof(EPIComboBoxControl), new PropertyMetadata(null));
        public static readonly DependencyProperty SelectedItemProperty =
           DependencyProperty.Register("SelectedItem", typeof(object), typeof(EPIComboBoxControl), new PropertyMetadata(null));
        public static readonly DependencyProperty SelectedIndexProperty =
          DependencyProperty.Register("SelectedIndex", typeof(int), typeof(EPIComboBoxControl), new PropertyMetadata(null));
        #endregion

        #region Public Properties
        public bool IsEditable
        {
            get { return (bool)GetValue(IsEditableProperty); }
            set { SetValue(IsEditableProperty, value); }
        }

        public bool Validating
        {
            get { return (bool)GetValue(ValidatingProperty); }
            set { SetValue(ValidatingProperty, value); }
        }

        public new Brush BorderBrush
        {
            get { return (Brush)GetValue(BorderBrushProperty); }
            set { SetValue(BorderBrushProperty, value); }
        }

        public new Thickness BorderThickness
        {
            get { return (Thickness)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public string WaterMarkText
        {
            get { return (string)GetValue(WaterMarkTextProperty); }
            set { SetValue(WaterMarkTextProperty, value); }
        }

        public Brush WaterMarkTextColor
        {
            get { return (Brush)GetValue(WaterMarkTextColorProperty); }
            set { SetValue(WaterMarkTextColorProperty, value); }
        }

        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public Style ItemContainerStyle
        {
            get { return (Style)GetValue(ItemContainerStyleProperty); }
            set { SetValue(ItemContainerStyleProperty, value); }
        }

        public object SelectedItem
        {
            get { return (object)GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        public int SelectedIndex
        {
            get { return (int)GetValue(SelectedIndexProperty); }
            set { SetValue(SelectedIndexProperty, value); }
        }
        #endregion
    }
}
