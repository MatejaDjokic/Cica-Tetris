using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrizivacTetramina : MonoBehaviour
{
    public GameObject[] tetramini;
    public GameObject roditelj;
    public TextMeshProUGUI recenica;
    public TextMeshProUGUI brojacText;
    public GameObject gumbDalje;
    void Start()
    {
        NoviTetramin();
    }

    public void NoviTetramin()
    {
        Instantiate(tetramini[Random.Range(0, tetramini.Length)], transform.position, Quaternion.identity, roditelj.transform);
        ObnoviRecenicu();
    }

    public void ObnoviRecenicu()
    {
        // OBNAVLJANEJ RECENICE I MENJANJE VIDLJIVOSTI GUMBA
        switch (Podaci.lik)
        {
            case Podaci.Likovi.ZanJoahimGorio: gumbDalje.SetActive(Podaci.nivo_1); recenica.text = Podaci.ZameniSaDonjimCrtama(0); brojacText.text = Podaci.trenutniSkor_1 + "/" + Podaci.brojReci_1; break;
            case Podaci.Likovi.AnastasijaDeRestau: gumbDalje.SetActive(Podaci.nivo_2); recenica.text = Podaci.ZameniSaDonjimCrtama(1); brojacText.text = Podaci.trenutniSkor_2 + "/" + Podaci.brojReci_2; break;
            case Podaci.Likovi.DelfinaNukingen: gumbDalje.SetActive(Podaci.nivo_3); recenica.text = Podaci.ZameniSaDonjimCrtama(2); brojacText.text = Podaci.trenutniSkor_3 + "/" + Podaci.brojReci_3; break;
            case Podaci.Likovi.GrofErnestoDeResto: gumbDalje.SetActive(Podaci.nivo_4); recenica.text = Podaci.ZameniSaDonjimCrtama(3); brojacText.text = Podaci.trenutniSkor_4 + "/" + Podaci.brojReci_4; break;
            case Podaci.Likovi.EzenDeRastinjak: gumbDalje.SetActive(Podaci.nivo_5); recenica.text = Podaci.ZameniSaDonjimCrtama(4); brojacText.text = Podaci.trenutniSkor_5 + "/" + Podaci.brojReci_5; break;
            case Podaci.Likovi.MadamVaukuer: gumbDalje.SetActive(Podaci.nivo_6); recenica.text = Podaci.ZameniSaDonjimCrtama(5); brojacText.text = Podaci.trenutniSkor_6 + "/" + Podaci.brojReci_6; break;
            case Podaci.Likovi.Vautrin: gumbDalje.SetActive(Podaci.nivo_7); recenica.text = Podaci.ZameniSaDonjimCrtama(6); brojacText.text = Podaci.trenutniSkor_7 + "/" + Podaci.brojReci_7; break;
            case Podaci.Likovi.MadamDeBeusant: gumbDalje.SetActive(Podaci.nivo_8); recenica.text = Podaci.ZameniSaDonjimCrtama(7); brojacText.text = Podaci.trenutniSkor_8 + "/" + Podaci.brojReci_8; break;
            case Podaci.Likovi.HoracieBiancon: gumbDalje.SetActive(Podaci.nivo_9); recenica.text = Podaci.ZameniSaDonjimCrtama(8); brojacText.text = Podaci.trenutniSkor_9 + "/" + Podaci.brojReci_9; break;
            case Podaci.Likovi.OnoreDeBalzak: gumbDalje.SetActive(Podaci.nivo_10); recenica.text = Podaci.ZameniSaDonjimCrtama(9); brojacText.text = Podaci.trenutniSkor_10 + "/" + Podaci.brojReci_10; break;
        }
    }

    public void UcitajLikoviScenu()
    {
        SceneManager.LoadScene("Likovi");
    }
    public void RestartujTetris()
    {
        switch (Podaci.lik)
        {
            case Podaci.Likovi.ZanJoahimGorio: Podaci.nivo_1 = false; Podaci.trenutniSkor_1 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(0); brojacText.text = Podaci.trenutniSkor_1 + "/" + Podaci.brojReci_1; break;
            case Podaci.Likovi.AnastasijaDeRestau: Podaci.nivo_2 = false; Podaci.trenutniSkor_2 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(1); brojacText.text = Podaci.trenutniSkor_2 + "/" + Podaci.brojReci_2; break;
            case Podaci.Likovi.DelfinaNukingen: Podaci.nivo_3 = false; Podaci.trenutniSkor_3 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(2); brojacText.text = Podaci.trenutniSkor_3 + "/" + Podaci.brojReci_3; break;
            case Podaci.Likovi.GrofErnestoDeResto: Podaci.nivo_4 = false; Podaci.trenutniSkor_4 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(3); brojacText.text = Podaci.trenutniSkor_4 + "/" + Podaci.brojReci_4; break;
            case Podaci.Likovi.EzenDeRastinjak: Podaci.nivo_5 = false; Podaci.trenutniSkor_5 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(4); brojacText.text = Podaci.trenutniSkor_5 + "/" + Podaci.brojReci_5; break;
            case Podaci.Likovi.MadamVaukuer: Podaci.nivo_6 = false; Podaci.trenutniSkor_6 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(5); brojacText.text = Podaci.trenutniSkor_6 + "/" + Podaci.brojReci_6; break;
            case Podaci.Likovi.Vautrin: Podaci.nivo_7 = false; Podaci.trenutniSkor_7 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(6); brojacText.text = Podaci.trenutniSkor_7 + "/" + Podaci.brojReci_7; break;
            case Podaci.Likovi.MadamDeBeusant: Podaci.nivo_8 = false; Podaci.trenutniSkor_8 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(7); brojacText.text = Podaci.trenutniSkor_8 + "/" + Podaci.brojReci_8; break;
            case Podaci.Likovi.HoracieBiancon: Podaci.nivo_9 = false; Podaci.trenutniSkor_9 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(8); brojacText.text = Podaci.trenutniSkor_9 + "/" + Podaci.brojReci_9; break;
            case Podaci.Likovi.OnoreDeBalzak: Podaci.nivo_10 = false; Podaci.trenutniSkor_10 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(9); brojacText.text = Podaci.trenutniSkor_10 + "/" + Podaci.brojReci_10; break;
        }
        SceneManager.LoadScene("Tetris");
    }
    public void ZatvoriTetris()
    {
        switch (Podaci.lik)
        {
            case Podaci.Likovi.ZanJoahimGorio: Podaci.nivo_1 = false; Podaci.trenutniSkor_1 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(0); brojacText.text = Podaci.trenutniSkor_1 + "/" + Podaci.brojReci_1; break;
            case Podaci.Likovi.AnastasijaDeRestau: Podaci.nivo_2 = false; Podaci.trenutniSkor_2 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(1); brojacText.text = Podaci.trenutniSkor_2 + "/" + Podaci.brojReci_2; break;
            case Podaci.Likovi.DelfinaNukingen: Podaci.nivo_3 = false; Podaci.trenutniSkor_3 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(2); brojacText.text = Podaci.trenutniSkor_3 + "/" + Podaci.brojReci_3; break;
            case Podaci.Likovi.GrofErnestoDeResto: Podaci.nivo_4 = false; Podaci.trenutniSkor_4 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(3); brojacText.text = Podaci.trenutniSkor_4 + "/" + Podaci.brojReci_4; break;
            case Podaci.Likovi.EzenDeRastinjak: Podaci.nivo_5 = false; Podaci.trenutniSkor_5 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(4); brojacText.text = Podaci.trenutniSkor_5 + "/" + Podaci.brojReci_5; break;
            case Podaci.Likovi.MadamVaukuer: Podaci.nivo_6 = false; Podaci.trenutniSkor_6 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(5); brojacText.text = Podaci.trenutniSkor_6 + "/" + Podaci.brojReci_6; break;
            case Podaci.Likovi.Vautrin: Podaci.nivo_7 = false; Podaci.trenutniSkor_7 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(6); brojacText.text = Podaci.trenutniSkor_7 + "/" + Podaci.brojReci_7; break;
            case Podaci.Likovi.MadamDeBeusant: Podaci.nivo_8 = false; Podaci.trenutniSkor_8 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(7); brojacText.text = Podaci.trenutniSkor_8 + "/" + Podaci.brojReci_8; break;
            case Podaci.Likovi.HoracieBiancon: Podaci.nivo_9 = false; Podaci.trenutniSkor_9 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(8); brojacText.text = Podaci.trenutniSkor_9 + "/" + Podaci.brojReci_9; break;
            case Podaci.Likovi.OnoreDeBalzak: Podaci.nivo_10 = false; Podaci.trenutniSkor_10 = 0; recenica.text = Podaci.ZameniSaDonjimCrtama(9); brojacText.text = Podaci.trenutniSkor_10 + "/" + Podaci.brojReci_10; break;
        }
        SceneManager.LoadScene("Likovi");
    }
}
