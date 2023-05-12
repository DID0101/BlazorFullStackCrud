namespace BlazorFullStackCrud.Client.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHero>  Heroes { get; set; }
        List<Comic> Comics { get;set; }
        Task GetComic();
        Task GetSuperHeroes();
        Task <SuperHero> GetSingleHero(int id);
    }
}
