using ExamPdp.Dtos;
using ExamPdp.Entities;
using System.Security.Cryptography.X509Certificates;

namespace ExamPdp.Services;

public class MusicServices : IMusicServices
{

    List<Music> Musics;
    public MusicServices()
    {
        Musics = new List<Music>();
    }

    public Guid AddMusic(CreateMusicDto createMudicDto)
    {
        var music = new Music();
        music.Id = Guid.NewGuid();
        music.Name = createMudicDto.Name;
        music.AuthorName = createMudicDto.AuthorName;
        music.QuentityLikes = createMudicDto.QuentityLikes;
        music.MB = CreateMusicDto.MB;

        Musics.Add(music);
        return music.Id;
    }

    public bool DeleteMusic(Guid id)
    {
        for (int i = 0; i < Musics.Count; i++)
        {
            if (Musics[i].Id == id)

            {
                Musics.RemoveAt(i);

            }


        }
    }
