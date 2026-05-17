using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button boutonPoisson;
    [SerializeField] private string niveaux = "Niveaux"; 

    void Start()
    {   //code pour le bouton du menu principal qui permet de charger la scène du niveau 1
        boutonPoisson.onClick.AddListener(() =>
        {
            TransitionManager.Instance.LoadScene(niveaux);
        });
    }
}