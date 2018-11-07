using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Interfaces.FileEnv;
using Interfaces.MediaLibraryEnv;
using Interfaces.PlayerEnv;
using Interfaces.PlaylistEnv;

using FileEnv;
using MediaLibraryEnv;
using PlaylistEnv;
using PlayerEnv;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediaLibrary mediaLibrary = new MediaLibrary(new List<IFile>(), new List<IPlaylist<IFile>>(), new Player());

            IPlaylist<IFile> playlist = new Playlist<IFile>(new List<IFile>(), "MyPlaylist");

            IFile mediaFile1 = new Photo("png", "Photo01", 1000000, @"D:\Photos", "1920x1080", 1920, 1080);
            IFile mediaFile2 = new Photo("png", "Photo02", 2000000, @"D:\Photos", "1920x1080", 1920, 1080);
            IFile mediaFile3 = new Photo("png", "Photo03", 3000000, @"D:\Photos", "1920x1080", 1920, 1080);

            IFile mediaFile4 = new Music("mp3", "Music01", 5000000, @"D:\Music", 320, 192000000, "3:00", "Rap", "playingtheangel", "MAGNUM OPUS", "Frisson", "2017");
            IFile mediaFile5 = new Music("mp3", "Music02", 6000000, @"D:\Music", 320, 192000000, "4:00", "Heavy Metal", "In Flames", "Come Clarity", "Come Clarity", "2006");
            IFile mediaFile6 = new Music("mp3", "Music03", 7000000, @"D:\Music", 320, 192000000, "5:00", "Dubstep", "Skrillex", "Recess", "Fuck That", "2014");

            IFile mediaFile7 = new Video("mp4", "Video01", 15000000, @"D:\Videos", 320, 192000000, "3:00", 1920, 1080, 60);
            IFile mediaFile8 = new Video("mp4", "Video02", 16000000, @"D:\Videos", 320, 192000000, "4:00", 1280, 720, 59);
            IFile mediaFile9 = new Video("mp4", "Video03", 17000000, @"D:\Videos", 320, 192000000, "5:00", 1680, 1050, 30);

            ICollection<IFile> mf = new List<IFile> { mediaFile1, mediaFile4, mediaFile7 };

            // Photo
            playlist.AddFile(mediaFile1);
            playlist.AddFile(mediaFile2);
            playlist.AddFile(mediaFile3);

            // Music
            playlist.AddFile(mediaFile4);
            playlist.AddFile(mediaFile5);
            playlist.AddFile(mediaFile6);

            // Videos
            playlist.AddFile(mediaFile7);
            playlist.AddFile(mediaFile8);
            playlist.AddFile(mediaFile9);

            mediaLibrary.PlayPlaylist(playlist);

            Console.ReadKey();
        }
    }
}
