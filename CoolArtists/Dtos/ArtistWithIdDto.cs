namespace CoolArtistsApi.CoolArtists.Dtos;

public class ArtistWithIdDto
{
    public int Id { get; set; }
    public string Image { get; set; } = string.Empty;
    public string ArtistName { get; set; } = string.Empty;
    public string ArtistDescription { get; set; } = string.Empty;
}