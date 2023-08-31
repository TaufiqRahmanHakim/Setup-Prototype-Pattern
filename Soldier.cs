using UnityEngine;

// Implementasi kelas Soldier yang mengimplementasikan IUnitPrototype
public class Soldier : MonoBehaviour, IUnitPrototype
{
    public string name;
    public int level;
    public string weapon;

    // Implementasi dari metode Clone, mengembalikan kloningan dari objek ini
    public IUnitPrototype Clone()
    {
        // MemberwiseClone adalah metode shallow copy built-in dari C#
        return (IUnitPrototype)this.MemberwiseClone();
    }

    // Implementasi dari metode Report, menampilkan informasi Soldier
    public void Report()
    {
        Debug.Log($"Soldier {name}, level {level}, armed with {weapon}");
    }
}