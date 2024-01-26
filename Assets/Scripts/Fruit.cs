using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{

    //Tiempo espec�fico para cada fruta
    public float fruitTime;

    //M�todo para que la fruta sea recogida
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Si el objeto que se ha metido en el trigger de la fruta es el jugador
        if (collision.CompareTag("Player"))
        {
            //Llamamos al m�todo del GameManager que inicializa el contador de
            //tiempo de invencibilidad de PacMan
            GameManager.gmSharedInstance.MakeInvincibleFor(fruitTime);
            //Eliminamos la fruta
            Destroy(gameObject);
        }
    }
}
