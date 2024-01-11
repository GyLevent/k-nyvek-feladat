namespace AdatbazisAPI.Models.Dtos
{
    //Szerzo
    public record SzerzoDto(Guid Id, Nemzetiseg nemzetiseg, string Nev, string Nem);
    public record CreateSzerzo(Guid Id,Guid NemzetisegId, string Nev,string Nem);
    public record UpdateSzerzo(Guid NemzetisegId,string Nev,string Nem);
    //Konyv
    public record KonyvDto(Guid Id,Szerzo szerzo,string Cím,string Mufaj,int Kiadaseve);
    public record CreateKonyv(Guid Id,Guid SzerzoId,string Cím,string Mufaj,int Kiadaseve);
    public record UpdateKonyv(Guid SzerzoId,string Cím,string Mufaj,int Kiadasneve);
    //Nemzetiseg
    public record NemzetisegDto(Guid Id, string SzerzoNemzetisege);
    public record CreateNemzetiseg(Guid Id, string SzerzoNemzetisege);
    public record UpdateNemzetiseg(string SzerzoNemzetisege);
}
