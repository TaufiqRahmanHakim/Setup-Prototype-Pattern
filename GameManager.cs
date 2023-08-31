using UnityEngine;

// Kelas GameManager untuk mengelola unit-unit dalam game
public class GameManager : MonoBehaviour
{
    public Soldier soldierPrototype; // Prototipe Soldier
    public Tank tankPrototype; // Prototipe Tank

    void Start()
    {
        // Mengkloning dan menyesuaikan Soldier
        Soldier soldier1 = (Soldier)soldierPrototype.Clone();
        soldier1.name = "John";
        soldier1.level = 2;
        soldier1.weapon = "Rifle";
        soldier1.Report(); // Menampilkan info

        // Mengkloning dan menyesuaikan Soldier lainnya
        Soldier soldier2 = (Soldier)soldierPrototype.Clone();
        soldier2.name = "Steve";
        soldier2.level = 3;
        soldier2.weapon = "Shotgun";
        soldier2.Report(); // Menampilkan info

        // Mengkloning dan menyesuaikan Tank
        Tank tank1 = (Tank)tankPrototype.Clone();
        tank1.name = "Panther";
        tank1.level = 1;
        tank1.cannonType = "120mm";
        tank1.Report(); // Menampilkan info
    }
}