namespace ExamPdp.Extensions;
public static class GetMusic
{
    static long GetMusicKB(this int mb)
    {
        return mb * 1024;
    }
}