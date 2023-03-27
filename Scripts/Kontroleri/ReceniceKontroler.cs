using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReceniceKontroler : MonoBehaviour
{

    public GameObject Lik;
    public Image slika;
    public TextMeshProUGUI recenica;
    public Sprite[] sprajtoviLikova;

    public void UcitajLikoviScenu()
    {
        SceneManager.LoadScene("Likovi");
    }

    public void UcitajTetris()
    {
        SceneManager.LoadScene("Tetris");
    }

    private void Start()
    {
        ZadajVrednostiRecenica();
    }

    private void Update()
    {
        ObnoviRecenicu();
    }


    void ObnoviRecenicu()
    {
        switch (Podaci.lik)
        {
            case Podaci.Likovi.ZanJoahimGorio: recenica.text = Podaci.ZameniSaDonjimCrtama(0); break;
            case Podaci.Likovi.AnastasijaDeRestau: recenica.text = Podaci.ZameniSaDonjimCrtama(1); break;
            case Podaci.Likovi.DelfinaNukingen: recenica.text = Podaci.ZameniSaDonjimCrtama(2); break;
            case Podaci.Likovi.GrofErnestoDeResto: recenica.text = Podaci.ZameniSaDonjimCrtama(3); break;
            case Podaci.Likovi.EzenDeRastinjak: recenica.text = Podaci.ZameniSaDonjimCrtama(4); break;
            case Podaci.Likovi.MadamVaukuer: recenica.text = Podaci.ZameniSaDonjimCrtama(5); break;
            case Podaci.Likovi.Vautrin: recenica.text = Podaci.ZameniSaDonjimCrtama(6); break;
            case Podaci.Likovi.MadamDeBeusant: recenica.text = Podaci.ZameniSaDonjimCrtama(7); break;
            case Podaci.Likovi.HoracieBiancon: recenica.text = Podaci.ZameniSaDonjimCrtama(8); break;
            case Podaci.Likovi.OnoreDeBalzak: recenica.text = Podaci.ZameniSaDonjimCrtama(9); break;
        }
    }

    void ZadajVrednostiRecenica()
    {
        switch (Podaci.lik)
        {
            case Podaci.Likovi.ZanJoahimGorio:
                Lik.GetComponentInChildren<TextMeshProUGUI>().text = Podaci.imenaLikova[0];
                recenica.text = Podaci.ZameniSaDonjimCrtama(0);
                slika.sprite = sprajtoviLikova[0];
                break;
            case Podaci.Likovi.AnastasijaDeRestau:
                Lik.GetComponentInChildren<TextMeshProUGUI>().text = Podaci.imenaLikova[1];
                recenica.text = Podaci.ZameniSaDonjimCrtama(1);
                slika.sprite = sprajtoviLikova[1];
                break;
            case Podaci.Likovi.DelfinaNukingen:
                Lik.GetComponentInChildren<TextMeshProUGUI>().text = Podaci.imenaLikova[2];
                recenica.text = Podaci.ZameniSaDonjimCrtama(2);
                slika.sprite = sprajtoviLikova[2];
                break;
            case Podaci.Likovi.GrofErnestoDeResto:
                Lik.GetComponentInChildren<TextMeshProUGUI>().text = Podaci.imenaLikova[3];
                recenica.text = Podaci.ZameniSaDonjimCrtama(3);
                slika.sprite = sprajtoviLikova[3];
                break;
            case Podaci.Likovi.EzenDeRastinjak:
                Lik.GetComponentInChildren<TextMeshProUGUI>().text = Podaci.imenaLikova[4];
                recenica.text = Podaci.ZameniSaDonjimCrtama(4);
                slika.sprite = sprajtoviLikova[4];
                break;
            case Podaci.Likovi.MadamVaukuer:
                Lik.GetComponentInChildren<TextMeshProUGUI>().text = Podaci.imenaLikova[5];
                recenica.text = Podaci.ZameniSaDonjimCrtama(5);
                slika.sprite = sprajtoviLikova[5];
                break;
            case Podaci.Likovi.Vautrin:
                Lik.GetComponentInChildren<TextMeshProUGUI>().text = Podaci.imenaLikova[6];
                recenica.text = Podaci.ZameniSaDonjimCrtama(6);
                slika.sprite = sprajtoviLikova[6];
                break;
            case Podaci.Likovi.MadamDeBeusant:
                Lik.GetComponentInChildren<TextMeshProUGUI>().text = Podaci.imenaLikova[7];
                recenica.text = Podaci.ZameniSaDonjimCrtama(7);
                slika.sprite = sprajtoviLikova[7];
                break;
            case Podaci.Likovi.HoracieBiancon:
                Lik.GetComponentInChildren<TextMeshProUGUI>().text = Podaci.imenaLikova[8];
                recenica.text = Podaci.ZameniSaDonjimCrtama(8);
                slika.sprite = sprajtoviLikova[8];
                break;
            case Podaci.Likovi.OnoreDeBalzak:
                Lik.GetComponentInChildren<TextMeshProUGUI>().text = Podaci.imenaLikova[9];
                recenica.text = Podaci.ZameniSaDonjimCrtama(9);
                slika.sprite = sprajtoviLikova[9];
                break;
        }
    }






}
