using WebApplication3.Services.Interfaces;

namespace WebApplication3.Services.Programs;

public class CocktailService : ICocktailService
{
    public string GetShortInfo() => "Маргарита: текіла, лайм, тріпл сек";
    public string GetFullInfo() => "Маргарита\nІнгредієнти:\n- 50мл текіли\n- 25мл лаймового соку\n- 15мл тріпл сек";
}