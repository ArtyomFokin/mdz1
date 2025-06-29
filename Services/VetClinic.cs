using ZooManagement.Models;

namespace ZooManagement.Services;

/// <summary>
/// Simple vet clinic stub that approves all healthy animals.
/// In this minimal implementation, we accept every animal.
/// </summary>
public class VetClinic
{
    public bool CheckHealth(Animal animal) => true;
}