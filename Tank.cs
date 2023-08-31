using UnityEngine;

// Implementasi kelas Tank yang mengimplementasikan IUnitPrototype
public class Tank : MonoBehaviour, IUnitPrototype
{
    public string name;
    public int level;
    public string cannonType;

    // Implementasi dari metode Clone, mengembalikan kloningan dari objek ini
    public IUnitPrototype Clone()
    {
        return (IUnitPrototype)this.MemberwiseClone();
    }

    // Implementasi dari metode Report, menampilkan informasi Tank
    public void Report()
    {
        Debug.Log($"Tank {name}, level {level}, equipped with {cannonType} cannon");
    }
}