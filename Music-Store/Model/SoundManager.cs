using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Store.Model
{
    public class SoundManager
    {

        public static void GetAllSounds(ObservableCollection<Sound> sounds)
        {
            var allSounds = getSounds();
            sounds.Clear();
            allSounds.ForEach(p => sounds.Add(p));
        }

        public static void GetSoundsByCategory(ObservableCollection<Sound> sounds, SoundCategory soundCategory)
        {
            var allSounds = getSounds();
            var filteredSounds = allSounds.Where(p => p.Category == soundCategory).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }

        public static void GetSoundsByName(ObservableCollection<Sound> sounds, string name)
        {
            var allSounds = getSounds();
            var filteredSounds = allSounds.Where(p => p.Name == name).ToList();
            sounds.Clear();
            filteredSounds.ForEach(p => sounds.Add(p));
        }

        private static List<Sound> getSounds()
        {
            var sounds = new List<Sound>();

            sounds.Add(new Sound("Anh Là Ai - Phương Ly", SoundCategory.Vpop));
            sounds.Add(new Sound("KHÔNG SAO MÀ EM ĐÂY RỒI - SUNI HẠ LINH ft Lou Hoàng", SoundCategory.Vpop));
            sounds.Add(new Sound("Như Vậy Mãi Thôi - Noo Phước Thịnh", SoundCategory.Vpop));
            sounds.Add(new Sound("Những Kẻ Mộng Mơ", SoundCategory.Vpop));
            sounds.Add(new Sound("SƠN TÙNG M-TP - MUỘN RỒI MÀ SAO CÒN", SoundCategory.Vpop));
            sounds.Add(new Sound("Yêu Thầm - Hoàng Yến Chibi x Tlinh x TDK x Lyly", SoundCategory.Vpop));

            sounds.Add(new Sound("Ariana Grande, Justin Bieber - Stuck with U", SoundCategory.US_UK));
            sounds.Add(new Sound("Avril Lavigne - Head Above Water", SoundCategory.US_UK));
            sounds.Add(new Sound("Charlie Puth - Cheating on You", SoundCategory.US_UK));
            sounds.Add(new Sound("Justin Bieber - Ghost", SoundCategory.US_UK));
            sounds.Add(new Sound("MADE IN THE USA - DEMI LOVATO", SoundCategory.US_UK));
            sounds.Add(new Sound("The Kid LAROI, Justin Bieber - STAY", SoundCategory.US_UK));

            sounds.Add(new Sound("Future_Red Velvet", SoundCategory.Kpop));
            sounds.Add(new Sound("IU _ Celebrity", SoundCategory.Kpop));
            sounds.Add(new Sound("IU_ eight ft SUGA(BTS)", SoundCategory.Kpop));
            sounds.Add(new Sound("My Love_DAVICHI", SoundCategory.Kpop));

            return sounds;
        }
    }
}
