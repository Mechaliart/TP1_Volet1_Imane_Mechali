using UnityEngine;
using UnityEngine.UI;

public class boutonmenu : MonoBehaviour
{
    [SerializeField] private Button boutonmenu1;
   
    [SerializeField] private string ecranintro = "EcranIntro"; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boutonmenu1.onClick.AddListener(() =>
        {
            TransitionManager.Instance.LoadScene(ecranintro);
        });
    }

 
}