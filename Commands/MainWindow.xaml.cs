using System;
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

namespace Commands
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BindNewCommandOnKey(Key.A, Brushes.AliceBlue, button);
            BindNewCommandOnKey(Key.B, Brushes.Blue, button);
            BindNewCommandOnKey(Key.C, Brushes.Cyan, button);
            BindNewCommandOnKey(Key.D, Brushes.DarkBlue, button);
            BindNewCommandOnKey(Key.E, Brushes.LightGreen, button);
            BindNewCommandOnKey(Key.F, Brushes.Fuchsia, button);
            BindNewCommandOnKey(Key.G, Brushes.Green, button);
            BindNewCommandOnKey(Key.H, Brushes.HotPink, button);
            BindNewCommandOnKey(Key.I, Brushes.Indigo, button);
            BindNewCommandOnKey(Key.J, Brushes.LightSeaGreen, button);
            BindNewCommandOnKey(Key.K, Brushes.Khaki, button);
            BindNewCommandOnKey(Key.L, Brushes.LemonChiffon, button);
            BindNewCommandOnKey(Key.M, Brushes.Magenta, button);
            BindNewCommandOnKey(Key.N, Brushes.Navy, button);
            BindNewCommandOnKey(Key.O, Brushes.Orange, button);
            BindNewCommandOnKey(Key.P, Brushes.Purple, button);
            BindNewCommandOnKey(Key.Q, Brushes.MediumPurple, button);
            BindNewCommandOnKey(Key.R, Brushes.Red, button);
            BindNewCommandOnKey(Key.S, Brushes.Silver, button);
            BindNewCommandOnKey(Key.T, Brushes.Turquoise, button);
            BindNewCommandOnKey(Key.U, Brushes.MediumBlue, button);
            BindNewCommandOnKey(Key.V, Brushes.Violet, button);
            BindNewCommandOnKey(Key.W, Brushes.White, button);
            BindNewCommandOnKey(Key.X, Brushes.DarkGray, button);
            BindNewCommandOnKey(Key.Y, Brushes.Yellow, button);
            BindNewCommandOnKey(Key.Z, Brushes.DarkOrange, button);
        }

        private void BindNewCommandOnKey(Key key, Brush brush, Control element, 
            ModifierKeys modifier = ModifierKeys.Control)
        {
            RoutedCommand command = new RoutedCommand();
            command.InputGestures.Add(new KeyGesture(key, modifier));
            CommandBindings.Add(new CommandBinding(
                command, (s, e) => element.Background = brush));
        }
    }
}
