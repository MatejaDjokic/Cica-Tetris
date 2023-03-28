using UnityEngine;

public static class Podaci
{
    public static Likovi lik;
    public static int brojReci_1 = 21;
    public static int brojReci_2 = 41;
    public static int brojReci_3 = 33;
    public static int brojReci_4 = 34;
    public static int brojReci_5 = 27;
    public static int brojReci_6 = 28;
    public static int brojReci_7 = 23;
    public static int brojReci_8 = 18;
    public static int brojReci_9 = 31;
    public static int brojReci_10 = 22;

    public static int trenutniSkor_1 = 21 - 1;
    public static int trenutniSkor_2 = 41 - 1;
    public static int trenutniSkor_3 = 33 - 1;
    public static int trenutniSkor_4 = 34 - 1;
    public static int trenutniSkor_5 = 27 - 1;
    public static int trenutniSkor_6 = 28 - 1;
    public static int trenutniSkor_7 = 23 - 1;
    public static int trenutniSkor_8 = 18 - 1;
    public static int trenutniSkor_9 = 31 - 1;
    public static int trenutniSkor_10 = 22 - 1;

    public static bool nivo_1 = false;
    public static bool nivo_2 = false;
    public static bool nivo_3 = false;
    public static bool nivo_4 = false;
    public static bool nivo_5 = false;
    public static bool nivo_6 = false;
    public static bool nivo_7 = false;
    public static bool nivo_8 = false;
    public static bool nivo_9 = false;
    public static bool nivo_10 = false;
    public enum Likovi
    {
        ZanJoahimGorio,
        AnastasijaDeRestau,
        DelfinaNukingen,
        GrofErnestoDeResto,
        EzenDeRastinjak,
        MadamVaukuer,
        Vautrin,
        MadamDeBeusant,
        HoracieBiancon,
        OnoreDeBalzak,
    }
    public static readonly string[] imenaLikova = {
        "Žan Joakim Gorio",
        "Anastasija de Ruso",
        "Delfina Nukingen",
        "Grof Ernesto de Resto",
        "Ežen de Rastinjak",
        "Madam Voker",
        "Votren",
        "Madam de Busant",
        "Horacie Biančon",
        "Onore de Balžak",
    };
    public static readonly string[] recenice = {
        "Čiča Gorio treba da se suoči sa činjenicom da njegove ćerke nisu toliko zainteresovane za njega koliko je želeo da veruje.",
        "Anastazija bi trebalo da shvati da je novac samo sredstvo, a ne krajnji cilj u životu trebalo bi da nauči da cene i poštuju svoju porodicu, uključujući i svog oca, koji ih je sve vreme bezuslovno voleo i brinuo o njima.",
        "Delfina je bila zaslepljena bogatstvom i uspehom u visokom društvu, pa bi trebalo da se osvrnu na svoje vrednosti i prioritete u životu umesto da stalno troše novac na beskrajne želje i hirove.",
        "Ernest de Resto predstavljen je kao deo društva koji se razbacuje novcem i živi raskošno, često na račun drugih ljudi, tako da bi trebalo da shvati da novac nije vazan koliko je vazna ljubav.",
        "Rastinjakova želja za prestižom i uspehom u aristokratskim krugovima, iako je bio obrazovan, bila je neodgovorna odluka koja mu nije bila od koristi u suočavanju sa izazovima.",
        "Gospođa Voker bi trebalo da razmotri različite opcije za poboljšanje svog poslovanja. Može da razmišlja o tome kako da privuče više gostiju, poboljša kvalitet svojih usluga i ponuda.",
        "U situacijama u kojima se nalazio, Votren bi trebao da bude iskren i direktan sa ljudima, umesto da igra igre i manipuliše njima.",
        "Gospođa de Bozeanje mogla da se ponaša dostojanstvenije i izbegne skandale koji su joj naškodili u društvenom životu.",
        "Biaconovo rešenje za suočavanje sa situacijama u romanu bilo je da primeni svoje znanje i veštine u korist drugih ljudi, što ga je činilo poštovanijim i uticajnijim među likovima u romanu. ",
        "Balzacova uloga u romanu \"Čiča Gorio\" je da kao pisac stvori svet koji će omogućiti da se prikažu ljudske slabosti i ambicije.",
    };

    public static string ZameniSaDonjimCrtama(int indeksRecenica)
    {
        int trenutniSkor = 0;
        int brojReci = 0;
        switch (indeksRecenica)
        {
            case 0: trenutniSkor = Podaci.trenutniSkor_1; brojReci = Podaci.brojReci_1; break;
            case 1: trenutniSkor = Podaci.trenutniSkor_2; brojReci = Podaci.brojReci_2; break;
            case 2: trenutniSkor = Podaci.trenutniSkor_3; brojReci = Podaci.brojReci_3; break;
            case 3: trenutniSkor = Podaci.trenutniSkor_4; brojReci = Podaci.brojReci_4; break;
            case 4: trenutniSkor = Podaci.trenutniSkor_5; brojReci = Podaci.brojReci_5; break;
            case 5: trenutniSkor = Podaci.trenutniSkor_6; brojReci = Podaci.brojReci_6; break;
            case 6: trenutniSkor = Podaci.trenutniSkor_7; brojReci = Podaci.brojReci_7; break;
            case 7: trenutniSkor = Podaci.trenutniSkor_8; brojReci = Podaci.brojReci_8; break;
            case 8: trenutniSkor = Podaci.trenutniSkor_9; brojReci = Podaci.brojReci_9; break;
            case 9: trenutniSkor = Podaci.trenutniSkor_10; brojReci = Podaci.brojReci_10; break;
        }

        string[] staraRecenica = Podaci.recenice[indeksRecenica].Split(" ");
        string[] novaRecenica = new string[staraRecenica.Length];

        for (int i = 0; i < trenutniSkor && i < staraRecenica.Length; i++)
        {
            novaRecenica[i] = staraRecenica[i];
        }

        for (int i = trenutniSkor; i < staraRecenica.Length; i++)
        {
            novaRecenica[i] = new string('_', staraRecenica[i].Length);
        }

        string rezultat = string.Join(" ", novaRecenica);

        if (trenutniSkor >= brojReci)
            return $"<color=#004D79>{rezultat}</color>";
        else
            return rezultat;
    }

}
