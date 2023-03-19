using UnityEngine;
using UnityEngine.SceneManagement;

public class GlavnaCT : MonoBehaviour
{

    public GameObject uputstvo;
    public GameObject gumbovi;
    public GameObject onama;

    public void Igraj(){
        SceneManager.LoadScene("Likovi");
    }

    public void Uputstvo(){
        gumbovi.SetActive(false);
        uputstvo.SetActive(true);
    }

    public void ONama(){
        gumbovi.SetActive(false);
        onama.SetActive(true);
    }

    public void Izadji(){
        Application.Quit();
    }

    public void BackUputstvo(){
        uputstvo.SetActive(false);
        gumbovi.SetActive(true);
    }

    public void BackONama(){
        onama.SetActive(false);
        gumbovi.SetActive(true);
    }
}
