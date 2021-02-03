using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerNota : MonoBehaviour
{
    public GameObject notas;
    public Vector3 rail1, rail2, rail3, rail4;
    public float nextNota = 0, betweenNote = 0.005F;
    int[] posNotas = new int[] {0,1,3,2,1,0,3,1};
    int nota;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextNota)
        {
            nextNota = betweenNote + Time.time;
            nota++;
            //les poscicions de les notes les agafa d'un array i es poscisiona segons l'eleccio en el switch.
            spaw(posNotas[nota]);
        }
    }

    public void spaw(int pos)
    {
        GameObject nota = Instantiate(notas);

        switch (pos)
        {
            case 0:
                nota.transform.position = this.transform.position + rail1;
                break;
            case 1:
                nota.transform.position = this.transform.position + rail2;
                break;
            case 2:
                nota.transform.position = this.transform.position + rail3;
                break;
            case 3:
                nota.transform.position = this.transform.position + rail4;
                break;
        }
    }
}
