using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WoWSharp_API;
using WowDotNetAPI.Models;

namespace WoWSharp_WPF.ViewModel
{
    /// <summary>
    /// Interaction logic for CharacterViewModel.xaml
    /// </summary>
    public partial class CharacterIconViewModel : UserControl
    {
        private Character _model;
        
        public Character Model
        {
            get { return _model; }
            set
            {
                _model = value;
                InitializeComponent();
                SetClassLabelColour();
                SetRaceLabelColour();
                SetIcon();
            }
        }

        public void SetClassLabelColour()
        {
            switch (Model.Class)
            {
                case CharacterClass.DEATH_KNIGHT:
                    Label_Class.Foreground = (Brush) FindResource("Colour_DeathKnight");
                    break;
                case CharacterClass.DRUID:
                    Label_Class.Foreground = (Brush) FindResource("Colour_Druid");
                    break;
                case CharacterClass.HUNTER:
                    Label_Class.Foreground = (Brush) FindResource("Colour_Hunter");
                    break;
                case CharacterClass.MAGE:
                    Label_Class.Foreground = (Brush) FindResource("Colour_Mage");
                    break;
                case CharacterClass.MONK:
                    Label_Class.Foreground = (Brush) FindResource("Colour_Monk");
                    break;
                case CharacterClass.PALADIN:
                    Label_Class.Foreground = (Brush) FindResource("Colour_Paladin");
                    break;
                case CharacterClass.PRIEST:
                    Label_Class.Foreground = (Brush) FindResource("Colour_Priest");
                    break;
                case CharacterClass.ROGUE:
                    Label_Class.Foreground = (Brush) FindResource("Colour_Rogue");
                    break;
                case CharacterClass.SHAMAN:
                    Label_Class.Foreground = (Brush) FindResource("Colour_Shaman");
                    break;
                case CharacterClass.WARLOCK:
                    Label_Class.Foreground = (Brush) FindResource("Colour_Warlock");
                    break;
                case CharacterClass.WARRIOR:
                    Label_Class.Foreground = (Brush) FindResource("Colour_Warrior");
                    break;
            }
        }

        public void SetRaceLabelColour()
        {
            switch (Model.Race)
            {
                case CharacterRace.PANDAREN_HORDE:
                case CharacterRace.GOBLIN:
                case CharacterRace.BLOOD_ELF:
                case CharacterRace.ORC:
                case CharacterRace.TAUREN:
                case CharacterRace.TROLL:
                case CharacterRace.UNDEAD:
                    Label_Race.Foreground = (Brush) FindResource("Colour_HordeRed");
                    break;
                case CharacterRace.PANDAREN_ALLIANCE:
                case CharacterRace.WORGEN:
                case CharacterRace.DRAENIE:
                case CharacterRace.DWARF:
                case CharacterRace.GNOME:
                case CharacterRace.HUMAN:
                case CharacterRace.NIGHT_ELF:
                    Label_Race.Foreground = (Brush) FindResource("Colour_AllianceBlue");
                    break;
            }
        }

        public void SetIcon()
        {
            var baseUri = new Uri(String.Format(Api.ThumbnailUrlBase, "us", Model.Thumbnail));
            Image_Icon.Source = new BitmapImage(baseUri);
        }
    }
}