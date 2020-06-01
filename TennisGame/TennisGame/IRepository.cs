namespace TennisGame
{
    public interface IRepository<T>
    {
        Game GetGame(int gameId);
    }
}