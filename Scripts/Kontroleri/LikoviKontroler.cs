using UnityEngine;
using UnityEngine.SceneManagement;
public class LikoviKontroler : MonoBehaviour
{

    public void UcitajGlavnuScenu()
    {
        SceneManager.LoadScene("Glavna");
    }
    public void CicaGorio()
    {
        Podaci.lik = Podaci.Likovi.ZanJoahimGorio;
        SceneManager.LoadScene("Recenice");
    }
    public void Sija()
    {
        Podaci.lik = Podaci.Likovi.AnastasijaDeRestau;
        SceneManager.LoadScene("Recenice");
    }
    public void Delfina()
    {
        Podaci.lik = Podaci.Likovi.DelfinaNukingen;
        SceneManager.LoadScene("Recenice");
    }
    public void Ernesto()
    {
        Podaci.lik = Podaci.Likovi.GrofErnestoDeResto;
        SceneManager.LoadScene("Recenice");
    }

    public void Rastinjak()
    {
        Podaci.lik = Podaci.Likovi.EzenDeRastinjak;
        SceneManager.LoadScene("Recenice");
    }
    public void MVaukuer()
    {
        Podaci.lik = Podaci.Likovi.MadamVaukuer;
        SceneManager.LoadScene("Recenice");
    }
    public void Vautrin()
    {
        Podaci.lik = Podaci.Likovi.Vautrin;
        SceneManager.LoadScene("Recenice");
    }

    public void MBeusant()
    {
        Podaci.lik = Podaci.Likovi.MadamDeBeusant;
        SceneManager.LoadScene("Recenice");
    }

    public void Horacie()
    {
        Podaci.lik = Podaci.Likovi.HoracieBiancon;
        SceneManager.LoadScene("Recenice");
    }

    public void Balzak()
    {
        Podaci.lik = Podaci.Likovi.OnoreDeBalzak;
        SceneManager.LoadScene("Recenice");
    }
}
