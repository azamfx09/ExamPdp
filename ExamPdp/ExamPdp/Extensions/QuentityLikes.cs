using ExamPdp.Dtos;

namespace ExamPdp.Extensions;

public static class QuentityLikes
{
    static int QuentityLikesMusics(this List<MusicDto> dtos)
    {
        var summLikes = 0;
        foreach (var music in dtos)
        {
            summLikes += music.QuentityLikes;
        }

        return summLikes;
    }
}