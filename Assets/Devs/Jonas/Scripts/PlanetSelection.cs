using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetSelection : MonoBehaviour
{
    //[SerializeField]
    //private List<SceneAsset> Planetas;
    string planetName;

    private void Start()
    {
        planetName = GetComponentInChildren<TextMeshProUGUI>().text;
    }

    public void selectPlanet()
    {
        SceneManager.LoadScene(planetName);
    }
}
