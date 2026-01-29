namespace ExamPdp.Dtos;

public class UpdateMusicDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double MB { get; set; }
    public string AuthorName { get; set; }
    public string Discription { get; set; }
    public int QuentityLikes { get; set; }
}