using UnityEngine;
using UnityEngine.SceneManagement;

public class LikoviCT : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("Glavna");
    }

    public void CicaGorio()
    {
        Podaci.lik = Podaci.Likovi.ZanJoahimGorio;
        SceneManager.LoadScene("Recenic");
    }
    public void Sija()
    {
        Podaci.lik = Podaci.Likovi.AnastasijaDeRestau;
        SceneManager.LoadScene("Recenic");
    }
    public void Delfina()
    {
        Podaci.lik = Podaci.Likovi.DelfinaNukingen;
        SceneManager.LoadScene("Recenic");
    }
    public void Ernesto()
    {
        Podaci.lik = Podaci.Likovi.GrofErnestoDeResto;
        SceneManager.LoadScene("Recenic");
    }

    public void Rastinjak()
    {
        Podaci.lik = Podaci.Likovi.EzenDeRastinjak;
        SceneManager.LoadScene("Recenic");
    }
    public void MVaukuer()
    {
        Podaci.lik = Podaci.Likovi.MadamVaukuer;
        SceneManager.LoadScene("Recenic");
    }
    public void Vautrin()
    {
        Podaci.lik = Podaci.Likovi.Vautrin;
        SceneManager.LoadScene("Recenic");
    }

    public void MBeusant()
    {
        Podaci.lik = Podaci.Likovi.MadamDeBeusant;
        SceneManager.LoadScene("Recenic");
    }

    public void Horacie()
    {
        Podaci.lik = Podaci.Likovi.HoracieBiancon;
        SceneManager.LoadScene("Recenic");
    }

    public void Balzak()
    {
        Podaci.lik = Podaci.Likovi.OnoreDeBalzak;
        SceneManager.LoadScene("Recenic");
    }
}
