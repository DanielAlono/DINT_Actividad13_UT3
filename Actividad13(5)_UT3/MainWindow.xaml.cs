using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Windows;
using System.Windows.Controls;

namespace Actividad13_5__UT3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Asignamos el grid ventana
            this.Content = ventana;

            string[] valores = new string[] { "0","1","2","3","4","5","6","7","8","9" };
            List<Label> label = new List<Label>();
            List<Viewbox> vb = new List<Viewbox>();
            List<Button> buttons = new List<Button>();

            // Creamos todos los botones y asignamos los label, Viewbox y su Content + Tag.
            for (int i = 0; i < valores.Length; i++)
            {
                label.Add(new Label()); //Inicializamos
                vb.Add(new Viewbox()); // Inicializamos
                buttons.Add(new Button()); // Inicializamos

                label[i].Content = valores[i]; //Asignamos content de Label
                vb[i].Child = label[i]; // Metemos el label dentro de ViewBox

                buttons[i].Content = vb[i]; // Asignamos Content. Metemos el ViewBox en el Button
                buttons[i].Margin = new Thickness(5); //Le añadimos un margen de 5
                buttons[i].Tag = valores[i]; // Asignamos Tag
            }

            // Asignamos sus valores dentro del grid
            Grid.SetRow(buttons[0], 4);
            Grid.SetColumn(buttons[0], 0);
            Grid.SetColumnSpan(buttons[0], 3);

            Grid.SetRow(buttons[1], 1);
            Grid.SetColumn(buttons[1], 0);

            Grid.SetRow(buttons[2], 1);
            Grid.SetColumn(buttons[2], 1);

            Grid.SetRow(buttons[3], 1);
            Grid.SetColumn(buttons[3], 2);

            Grid.SetRow(buttons[4], 2);
            Grid.SetColumn(buttons[4], 0);

            Grid.SetRow(buttons[5], 2);
            Grid.SetColumn(buttons[5], 1);

            Grid.SetRow(buttons[6], 2);
            Grid.SetColumn(buttons[6], 2);

            Grid.SetRow(buttons[7], 3);
            Grid.SetColumn(buttons[7], 0);

            Grid.SetRow(buttons[8], 3);
            Grid.SetColumn(buttons[8], 1);

            Grid.SetRow(buttons[9], 3);
            Grid.SetColumn(buttons[9], 2);
            //Los metemos dentro de la ventana
            for (int i = 0; i < buttons.Count; i++)
            {
                ventana.Children.Add(buttons[i]);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultadoTexBlock.Text = resultadoTexBlock.Text + (sender as Button).Tag.ToString();
        }
    }
}
