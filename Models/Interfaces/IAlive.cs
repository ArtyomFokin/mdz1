namespace ZooManagement.Models.Interfaces;

public interface IAlive
{
    /// <summary>
    /// Amount of food (kg) consumed per day.
    /// </summary>
    int Food { get; }
}