/*
 * Note: this only works on Windows!
 * 
 * Steps to include a WAV audio file:
 * 0. Find and download a WAV file that you can use legally.
 * 1. From the toolbar, Project => Add Existing Item... => Pick the .wav audio file
 * 2. Same as with data files, set the .wav file to "Copy if newer" so that the file is included in your build.
 * 3. Install System.Windows.Extensions via NuGet.
 * 
 * Compress your wav files: https://www.youcompress.com/wav/
 * 
 * Some places to find free music/sounds that you can use legally:
 * - https://incompetech.com/
 * - https://freesound.org/
 * - https://www.youtube.com/audiolibrary/music?nv=1
 * - https://freemusicarchive.org/
 * - https://jfxr.frozenfractal.com/
 */

using System;
using static System.Console;
using System.Media;

namespace AudioDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            if (OperatingSystem.IsWindows())
            {
                SoundPlayer wetFart = new SoundPlayer("wet_fart.wav");
                wetFart.Load();
                wetFart.PlayLooping();
            }


            ForegroundColor = ConsoleColor.White;
            WriteLine(@"
                                              ,           ^'^  _
                                              )               (_) ^'^
         _/\_                    .---------. ((        ^'^
         (('>                    )`'`'`'`'`( ||                 ^'^
    _    /^|                    /`'`'`'`'`'`\||           ^'^
    =>--/__|m---               /`'`'`'`'`'`'`\|
         ^^           ,,,,,,, /`'`'`'`'`'`'`'`\      ,
                     .-------.`|`````````````|`  .   )
                    / .^. .^. \|  ,^^, ,^^,  |  / \ ((
                   /  |_| |_|  \  |__| |__|  | /,-,\||
        _         /_____________\ |')| |  |  |/ |_| \|
       (')         |  __   __  |  '==' '=='  /_______\     _
      (' ')        | /  \ /  \ |   _______   |,^, ,^,|    (')
       \  \        | |--| |--| |  ((--.--))  ||_| |_||   (' ')
     _  ^^^ _      | |__| |('| |  ||  |  ||  |,-, ,-,|   /  /
   ,' ',  ,' ',    |           |  ||  |  ||  ||_| |_||   ^^^
.,,|RIP|,.|RIP|,.,,'==========='==''=='==''=='=======',,....,,,,.,ldb


== Credits ==
Music: 'Wet Fart Meme - Sound Effect (HD)'
Art: Haunted house by ldb from https://www.asciiart.eu/holiday-and-events/halloween
");
            ForegroundColor = ConsoleColor.Red;
            WriteLine("\n(Press any key to exit)");
            ReadKey();
        }
    }
}