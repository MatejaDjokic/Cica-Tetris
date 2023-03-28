using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LikoviKontroler : MonoBehaviour
{
    public Image slikaZanJoahimGorio;
    public Image slikaAnastasijaDeRestau;
    public Image slikaDelfinaNukingen;
    public Image slikaGrofErnestoDeResto;
    public Image slikaEzenDeRastinjak;
    public Image slikaMadamVaukuer;
    public Image slikaVautrin;
    public Image slikaMadamDeBeusant;
    public Image slikaHoracieBiancon;
    public Image slikaOnoreDeBalzak;
    private void Update()
    {
        Color plava = new Color(0.21875f, 0.30078f, 0.47266f, 1);
        Color zelena = new Color(0, 1, 0, 1);
        // MENJA BOJU KARTICA AKO JE NIVO PREDJEN
        if (Podaci.nivo_1) { slikaZanJoahimGorio.color = zelena; } else slikaZanJoahimGorio.color = plava;
        if (Podaci.nivo_2) { slikaAnastasijaDeRestau.color = zelena; } else slikaAnastasijaDeRestau.color = plava;
        if (Podaci.nivo_3) { slikaDelfinaNukingen.color = zelena; } else slikaDelfinaNukingen.color = plava;
        if (Podaci.nivo_4) { slikaGrofErnestoDeResto.color = zelena; } else slikaGrofErnestoDeResto.color = plava;
        if (Podaci.nivo_5) { slikaEzenDeRastinjak.color = zelena; } else slikaEzenDeRastinjak.color = plava;
        if (Podaci.nivo_6) { slikaMadamVaukuer.color = zelena; } else slikaMadamVaukuer.color = plava;
        if (Podaci.nivo_7) { slikaVautrin.color = zelena; } else slikaVautrin.color = plava;
        if (Podaci.nivo_8) { slikaMadamDeBeusant.color = zelena; } else slikaMadamDeBeusant.color = plava;
        if (Podaci.nivo_9) { slikaHoracieBiancon.color = zelena; } else slikaHoracieBiancon.color = plava;
        if (Podaci.nivo_10) { slikaOnoreDeBalzak.color = zelena; } else slikaOnoreDeBalzak.color = plava;
    }
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
