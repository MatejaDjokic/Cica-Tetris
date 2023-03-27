using TMPro;
using UnityEngine;

public class PrizivacTetramina : MonoBehaviour
{
    public GameObject[] tetramini;
    public GameObject roditelj;
    public TextMeshProUGUI recenica;
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
}
