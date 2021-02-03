using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

    public GameObject nota;
    public colision colision;
    public spawnerNota spawner;
    public int score;

    Vector3 rail1 = new Vector3(-3, 0, 0), rail2 = new Vector3(-1, 0, 0), rail3 = new Vector3(1, 0, 0), rail4 = new Vector3(3, 0, 0), posColision = new Vector3(0, -4, 0);

    // Start is called before the first frame update
    void Start()
    {
        colision colisio1 = Instantiate(colision);
        colision colisio2 = Instantiate(colision);
        colision colisio3 = Instantiate(colision);
        colision colisio4 = Instantiate(colision);
        spawnerNota spawn = Instantiate(spawner);

        colisio1.transform.position = transform.position + rail1 + posColision;
        colisio2.transform.position = transform.position + rail2 + posColision;
        colisio3.transform.position = transform.position + rail3 + posColision;
        colisio4.transform.position = transform.position + rail4 + posColision;
        spawn.transform.position = transform.position + new Vector3(0, 10, 0);

        colisio1.code = KeyCode.Z;
        colisio1.manager = this;
        colisio2.code = KeyCode.X;
        colisio2.manager = this;
        colisio3.code = KeyCode.C;
        colisio3.manager = this;
        colisio4.code = KeyCode.V;
        colisio4.manager = this;
        spawn.notas = this.nota;
        spawn.rail1 = this.rail1;
        spawn.rail2 = this.rail2;
        spawn.rail3 = this.rail3;
        spawn.rail4 = this.rail4;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("Score").GetComponentInChildren<Text>().text = "SCORE: " + score;
    }
}
