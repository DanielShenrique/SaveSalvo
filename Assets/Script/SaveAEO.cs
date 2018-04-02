using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveAEO : MonoBehaviour {

    public string objetosalvo;
    public string caminho;

    public SaveAEEE aEEE = new SaveAEEE();

    [SerializeField]
    private GameObject Player;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag.Equals("Jogador"))
        {
            aEEE.xposition = Player.gameObject.transform.position.x;
            aEEE.yposition = Player.gameObject.transform.position.y;
            aEEE.playername = Player.name;
            objetosalvo = JsonUtility.ToJson(aEEE, true);
            Debug.Log(objetosalvo);
            caminho = Path.Combine(Application.persistentDataPath,"savegame.dat");
            File.WriteAllText(caminho,objetosalvo);
        }
    }
}
