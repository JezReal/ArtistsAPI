using CoolArtistsApi.CoolArtists.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CoolArtistsApi.CoolArtists;

[ApiController]
[Route("api/[controller]")]
public class ArtistsController : ControllerBase
{
    public ArtistsController()
    {

    }

    [HttpGet]
    public ActionResult<List<ArtistWithIdDto>> GetCoolArtists()
    {
        var CoolArtists = new List<ArtistWithIdDto>{
            new ArtistWithIdDto {
                Id = 1,
                Image = "https://i.scdn.co/image/ab6761610000e5eb265ef5547ecff4dabd6352bf",
                ArtistName = "John Mayer",
                ArtistDescription = "John Mayer, in full John Clayton Mayer, (born October 16, 1977, Bridgeport, Connecticut, U.S.), American singer, songwriter, and guitarist whose melodic, often soft rock earned him a wide audience and a number of Grammy Awards in the early 21st century."
            },
            new ArtistWithIdDto {
                Id = 2,
                Image = "https://i.scdn.co/image/ab6761610000e5ebdd353edbce04267bff979de6",
                ArtistName = "Polyphia",
                ArtistDescription = "Polyphia is not only the biggest, but also the best metal band in the world. No other act has managed to marry a masterful command of melody with hip hop rhythms and dark and sinister tones in such an enticing way – and they’ve done so without the crutch of sing-along vocals. In challenging the generally accepted constant that dark and technical music has to be atonal and undanceable, the four members of Polyphia have done their part to advance the world of instrumental rock in a manner that has seldom been matched in the history of the genre."
            },
            new ArtistWithIdDto {
                Id = 3,
                Image  = "https://i.scdn.co/image/ab6761610000e5ebc6e1280be0bb5a22ff599700",
                ArtistName = "Official HIGE DANdism",
                ArtistDescription = "OFFICIAL HIGE DANDISM — aka “HIGEDAN” for short — are a Japanese pop band originally formed in 2012 in Shimane. Now based in Tokyo, the band consists of lead vocalist and keyboardist Satoshi Fujihara, guitarist Daisuke Ozasa, bassist and Saxophonist Makoto Narazaki, and drummer Masaki Mastsuura."
            },
            new ArtistWithIdDto {
                Id = 4,
                Image = "https://i.scdn.co/image/ab6761610000e5eb777d988eedca9cccfe433690",
                ArtistName = "BAND-MAID",
                ArtistDescription = "Band-Maid (stylized as BAND-MAID® until 2016) is a Japanese rock band formed in 2013, consisting of singer Saiki Atsumi, guitarist/singer Miku Kobato, lead guitarist Kanami Tōno, bassist Misa, and drummer Akane Hirose. The band combines a rock sound with a maid image modeled on Japanese maid cafés."
            },
            new ArtistWithIdDto {
                Id = 5,
                Image = "https://i.scdn.co/image/ab6761610000e5eb6e9533d2bc08f501d72c23c3",
                ArtistName = "Neck Deep",
                ArtistDescription = "Neck Deep are a Welsh pop punk band from Wrexham, Wales formed in 2012. Founded after vocalist Ben Barlow met former lead guitarist Lloyd Roberts, the pair posted a song (\"What Did You Expect?\") online under the name Neck Deep."
            },
            new ArtistWithIdDto {
                Id = 6,
                Image = "https://i.scdn.co/image/ab6761610000e5eb8c90674b86ec8f34f019702d",
                ArtistName = "The Maine",
                ArtistDescription = "Arizona's the Maine are known for their emotive pop-punk and indie rock sound. The group first garnered attention on the Vans Warped Tour before issuing their Top 40 debut, Can't Stop Won't Stop, in 2008. That paved the way for their sophomore album, 2010's Black & White, which cracked the Top 20 of the Billboard 200."
            },
            new ArtistWithIdDto {
                Id = 7,
                Image = "https://i.scdn.co/image/ab6761610000e5ebe18756b9265f7b53964157f2",
                ArtistName = "DECO*27",
                ArtistDescription = "DECO*27 (デコ・ニーナ, Deko Niina, born December 16, 1986) is a Fukuoka-born Vocaloid producer and cover singer (\"utaite\") notable for his pop rock-style. Debuting in October 2008, his first work \"Boku Mitai na Kimi Kimi Mitai na Boku\" was an instant hit with over 100,000 views on NicoNicoDouga."
            },
            new ArtistWithIdDto {
                Id = 8,
                Image = "https://i.scdn.co/image/ab6761610000e5ebb10c34546a4ca2d7faeb8865",
                ArtistName = "Paramore",
                ArtistDescription = "Paramore is an American rock band from Franklin, Tennessee, formed in 2004. The band currently consists of lead vocalist Hayley Williams, guitarist Taylor York and drummer Zac Farro. Williams and Farro are founding members of the group, while York, a high school friend of the original lineup, joined in 2007."
            },
            new ArtistWithIdDto {
                Id = 9,
                Image = "https://i.scdn.co/image/ab6761610000e5eb4591f07a7393247724a5de66",
                ArtistName = "All Time Low",
                ArtistDescription = "All Time Low is an American rock band from Towson, Maryland, formed in 2003. Consisting of lead vocalist/rhythm guitarist Alex Gaskarth, lead guitarist Jack Barakat, bassist/backing vocalist Zack Merrick, and drummer Rian Dawson, the band took its name from lyrics in the song \"Head on Collision\" by New Found Glory."
            }
        };

        return CoolArtists;
    }
}