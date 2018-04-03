using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SalvoSaveSaviano : MonoBehaviour {

    private GameObject saveaeo;
    private GameObject player;
    public Vector3 posicao;


    public void Start()
    {
        saveaeo = GameObject.FindGameObjectWithTag("Save");
        player = GameObject.FindGameObjectWithTag("Jogador");
    }

    void Load()
    {
        string texto = File.ReadAllText(saveaeo.GetComponent<SaveAEO>().caminho);
       
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag.Equals("Player"))
        {
            Load();
            SaveAEO jogadorcarregado = JsonUtility.FromJson<SaveAEO>(saveaeo.GetComponent<SaveAEO>().caminho);
            Vector3 posicao = new Vector3();
            posicao.x = saveaeo.GetComponent<SaveAEO>().aEEE.xposition;
            Instantiate(player);
        }
        
    }
}
