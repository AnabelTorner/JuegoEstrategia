using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public float tiempoAparicion;

    public GameObject bomba;
    public GameObject tanque;
    public GameObject mele;
    public GameObject mago;
    public GameObject arquero;

    public GameObject posicionTorreCentral;
    public GameObject posicionTorreIzq;
    public GameObject posicionTorreDer;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > tiempoAparicion)
        {
            switch (Random.Range(0, 5))
            {
                case 0: invocarBomba(); break;
                case 1: invocarTanque(); break;
                case 2: invocarMele(); break;
                case 3: invocarMago(); break;
                case 4: invocarArquero(); break;
            }
            timer = 0;
        }
    }

    //Bomba
    public void invocarBomba()
    {
        switch (Random.Range(0, 3))
        {
            case 0: Instantiate(bomba, posicionTorreCentral.transform); break;
            case 1: Instantiate(bomba, posicionTorreIzq.transform); break;
            case 2: Instantiate(bomba, posicionTorreDer.transform); break;
        }
    }

    //Tanque
    public void invocarTanque()
    {
        switch (Random.Range(0, 3))
        {
            case 0: Instantiate(tanque, posicionTorreCentral.transform); break;
            case 1: Instantiate(tanque, posicionTorreIzq.transform); break;
            case 2: Instantiate(tanque, posicionTorreDer.transform); break;
        }
    }

    //Mele
    public void invocarMele()
    {
        switch (Random.Range(0, 3))
        {
            case 0: Instantiate(mele, posicionTorreCentral.transform); break;
            case 1: Instantiate(mele, posicionTorreIzq.transform); break;
            case 2: Instantiate(mele, posicionTorreDer.transform); break;
        }
    }

    //Mago
    public void invocarMago()
    {
        switch (Random.Range(0, 3))
        {
            case 0: Instantiate(mago, posicionTorreCentral.transform); break;
            case 1: Instantiate(mago, posicionTorreIzq.transform); break;
            case 2: Instantiate(mago, posicionTorreDer.transform); break;
        }
    }

    //Arquero
    public void invocarArquero()
    {
        switch (Random.Range(0, 3))
        {
            case 0: Instantiate(arquero, posicionTorreCentral.transform); break;
            case 1: Instantiate(arquero, posicionTorreIzq.transform); break;
            case 2: Instantiate(arquero, posicionTorreDer.transform); break;
        }
    }
}
