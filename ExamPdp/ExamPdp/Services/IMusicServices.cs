using ExamPdp.Dtos;

namespace ExamPdp.Services;

public class IMusicServices
{
    public List<MusicDto> GetAllMusicByAuthorName(string name);
    public bool DeleteMusic(DeleteMusic);
    public MusicDto GetMostLikedMusic();
    public MusicDto GetMusicByName(string name);
    public List<MusicDto> GetAllMusicBAboveSize(double minSize);
    public List<MusicDto> GetAllMudicAboveSize(double minSize);
    public List<MusicDto> GetTopMostLikedMusic(int count);
    public List<MusicDto> GetMusicWithLikesInRange(int MinLikes, MaxLikes);
    public List<MusicDto> GetTotalMusicSizeByAuthor(string name);


}
