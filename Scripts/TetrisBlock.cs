using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class TetrisBlock : MonoBehaviour
{

    Transform mrezaPoljaJI;
    Transform mrezaPoljaJI_minus;

    public Vector3 rotacionaTacka;
    private float prosloVreme;
    private float prosloVremeLevo;
    private float prosloVremeDesno;
    private float vremePadanja = 0.8f;
    private float vremePadanjaPomeranjaLevo = 0.15f;
    private float vremePadanjaPomeranjaDesno = 0.15f;
    public static int visina = 20;
    public static int sirina = 10;
    bool krajIgre = false;
    public static Transform[,] mrezaPolja = new Transform[sirina, visina];
    List<Color> moguceBoje = new List<Color>();
    List<Color> sveBoje = new List<Color>();
    private void Start()
    {
        sveBoje.Add(Color.magenta);
        sveBoje.Add(Color.blue);
        sveBoje.Add(Color.cyan);
        sveBoje.Add(Color.green);
        sveBoje.Add(Color.magenta);
        sveBoje.Add(Color.red);
        sveBoje.Add(Color.yellow);
        moguceBoje = sveBoje;
        ZadajBoju();
    }
    void Update()
    {
        UnosniKonroler();
        KrajIgre();
    }
    void KrajIgre()
    {
        // AKO SE NALAZI BLOK CIJA Y KORDINATA JE JEDNAKA 16
        // IGRA JE GOTOVA
        for (int i = 0; i < sirina; i++)
        {
            if (mrezaPolja[i, 15] != null)
            {
                krajIgre = true;
            }
        }
        if (krajIgre)
        {
            Debug.Log("Kraj Igre");
            this.enabled = false;
        }
    }

    public void ZadajBoju()
    {
        // MENJAMO BOJU SVE DECE TETRAMINA
        int indeks = Random.Range(0, moguceBoje.Count);
        Color boja = moguceBoje[indeks];
        foreach (Transform dete in transform)
        {
            dete.GetComponent<SpriteRenderer>().color = boja;
        }
        moguceBoje.RemoveAt(indeks);
    }

    void UnosniKonroler()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && Time.time - prosloVremeLevo > vremePadanjaPomeranjaLevo)
        {
            // AKO JE STRELICA LEVO PRITISNUTA POMERA BLOK ZA 1 U LEVO
            transform.position += new Vector3(-1, 0, 0);

            // PROVERAVAMO DA LI JE SL KORAK VALIDAN
            // AKO NIJE VRACAMO NAZAD POMERENI BLOK
            if (!SledeciKorakValidan())
            {
                transform.position -= new Vector3(-1, 0, 0);
            }
            prosloVremeLevo = Time.time;
        }
        else if (Input.GetKey(KeyCode.RightArrow) && Time.time - prosloVremeDesno > vremePadanjaPomeranjaDesno)
        {
            // AKO JE STRELICA DESNO PRITISNUTA POMERA BLOK ZA 1 U DESNO
            transform.position += new Vector3(1, 0, 0);

            // PROVERAVAMO DA LI JE SL KORAK VALIDAN
            // AKO NIJE VRACAMO NAZAD POMERENI BLOK
            if (!SledeciKorakValidan())
            {
                transform.position -= new Vector3(1, 0, 0);
            }
            prosloVremeDesno = Time.time;
        }
        if (Time.time - prosloVreme > (Input.GetKey(KeyCode.DownArrow) ? vremePadanja / 10 : vremePadanja))
        {
            // BLOK TSE TAJMIRANO SPUSTA ZA 1 KA DOLE
            // AKO JE STRELICA DOLE PRITISNUTA UBRZAV A POMERANJE BLOKA KA DOLE
            transform.position += new Vector3(0, -1, 0);

            // PROVERAVAMO DA LI JE SL KORAK VALIDAN
            // AKO NIJE VRACAMO NAZAD POMERENI BLOK
            // TAKODJE DODAJEMO SVU DECU BLOKOVE TETRAMINA 
            if (!SledeciKorakValidan())
            {
                transform.position += new Vector3(0, 1, 0);
                DodajUMrezuPolja();
                IzbrisiRed();
                this.enabled = false;
                FindAnyObjectByType<PrizivacTetramina>().NoviTetramin();
            }

            // RESTARTOVANJE PROSLOG VREMENA 
            prosloVreme = Time.time;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // AKO JE STRELICA NA GORE PRITISNUTA ROTIRAMO X OSU TETRAMINA
            // ZA 90 STEPENI OKO ROTACIONE TACKE KOJU PRVO
            // IZ GLOBALNIH PRETVARAMO U LOKALNE KORDINATE
            Vector3 lokalnaRotacionaTack = transform.TransformPoint(rotacionaTacka);
            transform.RotateAround(lokalnaRotacionaTack, new Vector3(0, 0, 1), 90);

            if (!SledeciKorakValidan())
            {
                transform.RotateAround(lokalnaRotacionaTack, new Vector3(0, 0, 1), -90);
            }
        }
    }

    void Izbrisi(int y)
    {
        for (int x = 0; x < sirina; ++x)
        {
            Destroy(mrezaPolja[x, y].gameObject);
            mrezaPolja[x, y] = null;
        }
    }

    bool PunaLinija(int y)
    {
        for (int x = 0; x < sirina; ++x)
            if (mrezaPolja[x, y] == null)
                return false;
        return true;
    }

    void RedDole(int y)
    {
        for (int x = 0; x < sirina; ++x)
        {
            if (mrezaPolja[x, y] != null)
            {
                mrezaPolja[x, y - 1] = mrezaPolja[x, y];
                mrezaPolja[x, y] = null;
                mrezaPolja[x, y - 1].position += new Vector3(0, -1, 0);
            }
        }
    }
    void IzbrisiRed()
    {
        // BRISE REDOVE KOJI IMAJU PUNU LINIJU I ONDA SPUSTA SVE BLOKOVE KOJI PLUTAJU
        for (int y = 0; y < visina; ++y)
        {
            if (PunaLinija(y))
            {
                Kontroler.skor++;
                Izbrisi(y);
                RedoviDole(y + 1);
                --y;
            }
        }
    }

    void RedoviDole(int y)
    {
        // POMERA SVE REDOVE DOLE
        for (int i = y; i < visina; ++i)
            RedDole(i);
    }


    void DodajUMrezuPolja()
    {
        // PROLAZIMO KROZ SVU DECU(BLOKOVE) TETRAMINA
        foreach (Transform dete in transform)
        {
            // UZIMAMO NJEGOVE KORDINATE
            int rX = Mathf.RoundToInt(dete.transform.position.x);
            int rY = Mathf.RoundToInt(dete.transform.position.y);

            // DODAJEMO U MREZU POLJA NA TIM POZICIJAMA
            mrezaPolja[rX, rY] = dete;
        }
    }

    bool SledeciKorakValidan()
    {
        // PROLAZIMO KROZ SVAKO DETE(BLOK) OVOG TETRIS BLOKA
        foreach (Transform dete in transform)
        {
            // UZIMAMO NJEGOVE KORDINATE
            int rX = Mathf.RoundToInt(dete.transform.position.x);
            int rY = Mathf.RoundToInt(dete.transform.position.y);

            // PROVERAVAMO DA LI SU TE KORDINATE UNUTAR MREZE POLJA
            if (rX < 0 || rX >= sirina || rY < 0 || rY >= visina)
            {
                return false;
            }
            if (mrezaPolja[rX, rY] != null)
            {
                return false;
            }
        }
        return true;
    }
}
