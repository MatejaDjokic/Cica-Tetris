using UnityEngine;
using UnityEngine.SceneManagement;

public class GlavnaKontroler : MonoBehaviour
{
    public GameObject uputstvo;
    public GameObject gumbovi;
    public GameObject onama;

    public void IgrajDugme()
    {
        SceneManager.LoadScene("Likovi");
    }

    public void UcitajUputstvo()
    {
        gumbovi!.SetActive(false);
        uputstvo!.SetActive(true);
    }

    public void UcitajONama()
    {
        gumbovi!.SetActive(false);
        onama!.SetActive(true);
    }

    public void IzadjiDugme()
    {
        Application.Quit();
    }

    public void NazadIzUputstva()
    {
        uputstvo!.SetActive(false);
        gumbovi!.SetActive(true);
    }

    public void NazadIzONama()
    {
        onama!.SetActive(false);
        gumbovi!.SetActive(true);
    }


}
