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
using WoWSharp_API;
using WoWSharp_WPF.ViewModel;
using WowDotNetAPI.Models;

namespace WoWSharp_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Elysium.Theme.Controls.Window
    {
        private List<Character> Characters { get; set; }
        private Character Cuifen { get; set; }

        public MainWindow()
        {
            Characters = new List<Character>();
            InitializeComponent();
        }

        public void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Cuifen = Api.GetCharacter("Shadow Council", "Cuifen");
            Characters.Add(Api.GetCharacter("Shadow Council", "Leyr"));
            Characters.Add(Cuifen);
            Characters.Add(Api.GetCharacter("Shadow Council", "Anqwas"));
        }
    }
}
