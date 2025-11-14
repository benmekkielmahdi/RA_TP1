using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;   

public class Planets : MonoBehaviour
{
    public GameObject soleil;
    public GameObject terre;
    public GameObject mars;
    public GameObject neptune;
    public GameObject jupiter;

    public TMP_Text description;   
    public void showSoleil()
    {
        soleil.SetActive(true);
        terre.SetActive(false);
        mars.SetActive(false);
        neptune.SetActive(false);
        jupiter.SetActive(false);

        description.text =
            "<b>Soleil :</b>\n" +
            "- Étoile du système solaire\n" +
            "- Température : 5 500°C en surface\n" +
            "- Composition : hydrogène et hélium\n" +
            "- Source de lumière et chaleur pour toutes les planètes";
    }

    public void showTerre()
    {
        soleil.SetActive(false);
        terre.SetActive(true);
        mars.SetActive(false);
        neptune.SetActive(false);
        jupiter.SetActive(false);

        description.text =
            "<b>Terre :</b>\n" +
            "- 3e planète du Soleil\n" +
            "- Couleurs : bleu, vert et blanc\n" +
            "- 1 lune\n" +
            "- Seule planète connue avec la vie";
    }

    public void showMars()
    {
        soleil.SetActive(false);
        terre.SetActive(false);
        mars.SetActive(true);
        neptune.SetActive(false);
        jupiter.SetActive(false);

        description.text =
            "<b>Mars :</b>\n" +
            "- Surnommée : la planète rouge\n" +
            "- Couleur : rouge orangé\n" +
            "- 2 lunes : Phobos et Déimos\n" +
            "- Possède des volcans géants (Olympus Mons)";
    }

    public void showNeptune()
    {
        soleil.SetActive(false);
        terre.SetActive(false);
        mars.SetActive(false);
        neptune.SetActive(true);
        jupiter.SetActive(false);

        description.text =
            "<b>Neptune :</b>\n" +
            "- Planète bleu foncé\n" +
            "- Très lointaine et très froide\n" +
            "- Vents extrêmement puissants\n" +
            "- 14 lunes";
    }

    public void showJupiter()
    {
        soleil.SetActive(false);
        terre.SetActive(false);
        mars.SetActive(false);
        neptune.SetActive(false);
        jupiter.SetActive(true);

        description.text =
            "<b>Jupiter :</b>\n" +
            "- Plus grande planète du système solaire\n" +
            "- Couleurs : marron, beige, blanc\n" +
            "- Grande tache rouge = énorme tempête\n" +
            "- Plus de 70 lunes";
    }
}
