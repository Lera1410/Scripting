using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Метод Start вызывается один раз в начале игры
    void Start()
    {
        // Удаление объекта, к которому прикреплен этот скрипт
        Destroy(gameObject);
    }
}