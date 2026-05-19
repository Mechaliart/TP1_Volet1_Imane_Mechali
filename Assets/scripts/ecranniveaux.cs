using UnityEngine;
using UnityEngine.UI;

public class ecranniveaux : MonoBehaviour
{
    [SerializeField] private Button boutonniveau1;
    [SerializeField] private Button boutonniveau2;
     [SerializeField] private Button boutonniveau3;
    [SerializeField] private string niveau1 = "Niveau1"; 
    [SerializeField] private string niveau2 = "Niveau2"; 
     [SerializeField] private string niveau3 = "Niveau3"; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boutonniveau1.onClick.AddListener(() =>
        {
            TransitionManager.Instance.LoadScene(niveau1);
        }); 
        boutonniveau2.onClick.AddListener(() =>
        {
            TransitionManager.Instance.LoadScene(niveau2);
        });
           boutonniveau3.onClick.AddListener(() =>
        {
            TransitionManager.Instance.LoadScene(niveau3);
        });
    }

 
}
