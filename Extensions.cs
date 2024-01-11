using AdatbazisAPI.Models.Dtos;

namespace AdatbazisAPI
{
    public static class Extensions
    {
        public static SzerzoDto AsDto(this Szerzo szerzok) 
        {
            return new(szerzok.Id,  szerzok.nemzetiseg, szerzok.Nev, szerzok.Nem);
        }
        public static KonyvDto AsDto( this Konyv konyvek ) 
        {
            return new(konyvek.Id, konyvek.szerzo, konyvek.Cím, konyvek.Mufaj, konyvek.kiadaseve);
        }
        public static NemzetisegDto AsDto(this Nemzetiseg nemzetisegek)
        {
            return new(nemzetisegek.Id, nemzetisegek.SzerzoNemzetisege);
        }
    }
}
