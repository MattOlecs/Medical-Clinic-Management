using Microsoft.AspNet.FriendlyUrls;
using Przychodnia_Mateusz_Oleksik;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Przychodnia_online
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Dane_przychodni.Deserializacja();
            }
            catch(Exception wyjatek)
            {
                Label1.Text = "Nie udało się wczytać danych " + wyjatek.Message;
            }

            //zestaw od wyboru czynnosci
            Label2.Visible = false;
            DropDownList1.Visible = false;
            Button1.Visible = false;

            //zestaw od wyboru lekarza
            Label3.Visible = false;
            DropDownList2.Visible = false;
            Button2.Visible = false;

            //zajete terminy
            ListBox3.Visible = false;
            Label7.Visible = false;

            //kalendarz
            Calendar1.Visible = false;

            //logowanie
            Label6.Visible = false;

            //wybranie godziny
            Label_wybrana_godz.Visible = false;
            Label_h.Visible = false;
            Label_m.Visible = false;
            TextBox3.Visible = false;
            TextBox4.Visible = false;
            Button4.Visible = false;
            Label_wybrana_godz.Visible = false;
        }

        void wyswietlPracownikow() //wyswietla pracownikow w dropdownlist2 wraz z ich godzinami pracy na danych dzien
        {
            DropDownList2.Items.Clear();
            
            string wybrana_czynnosc = DropDownList1.SelectedValue.ToString();
            DateTime wybrana_data = Calendar1.SelectedDate;

            foreach (GodzinyPracy godzina in GodzinyPracy.ListaGodzinPracy)
                if (godzina.Data_dnia_pracy.Year == wybrana_data.Year && godzina.Data_dnia_pracy.Month == wybrana_data.Month && godzina.Data_dnia_pracy.Day == wybrana_data.Day)
                    foreach (Czynności_medyczne czynnosc in godzina.Pracownik.ListaCzynnosciPracownika)
                        if (czynnosc.Nazwa_czynnosci.Contains(wybrana_czynnosc))
                            DropDownList2.Items.Add(godzina.ToString());
        }

        void wyswietlCzynnosci() //wyswietla czynnosci medyczna dostepne w przychodni
        {
            DropDownList1.Items.Clear();

            foreach (Czynności_medyczne czynnosci in Czynności_medyczne.ListaCzynnosciMedycznych)
                DropDownList1.Items.Add(czynnosci.ToString());
        }

        void wyswietlZajeteTerminy() //wyswietla juz zaklepane terminy na dany dzien u danego pracownika
        {
            ListBox3.Items.Clear();

            Label7.Visible = true;
            ListBox3.Visible = true;

            string wybrany_pracownik = DropDownList2.SelectedValue.ToString();
            DateTime wybrana_data = Calendar1.SelectedDate;

            foreach (ZaplanowaneCzynnosciMedyczne zaplanowane in ZaplanowaneCzynnosciMedyczne.ListaZaplanowanychCzynnosci)
                if (zaplanowane.Data_czynnosci.Year == wybrana_data.Year && zaplanowane.Data_czynnosci.Month == wybrana_data.Month && zaplanowane.Data_czynnosci.Day == wybrana_data.Day && wybrany_pracownik.Contains(zaplanowane.Pracownik.Imie) && wybrany_pracownik.Contains(zaplanowane.Pracownik.Nazwisko))
                {
                    ListBox3.Items.Add(zaplanowane.ToString());
                }
        }

        protected void Button2_Click1(object sender, EventArgs e) //przycisk do pokazania zajetych terminów
        {
            wyswietlZajeteTerminy();
            widokWybranegoLekarza();
            widokWybranejCzynnosci();
            ListBox3.Visible = true;
            widokWyboruGodziny();
        }

        protected void Button1_Click(object sender, EventArgs e) // przycisk do pokazania pracowników z uprawnieniami do danej czynności
        { 
            wyswietlPracownikow();
            widokWybranejCzynnosci();
            przyciskiLekarzWidoczne();
        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e) //zmiana daty w kalendarzu
        {
            wyswietlCzynnosci();
            przyciskiCzynnoscWidoczne();

        }

        void przyciskiCzynnoscWidoczne() // widoczne menu wyboru czynnosci medycznej
        {
            Label2.Visible = true;
            DropDownList1.Visible = true;
            Button1.Visible = true;
            Calendar1.Visible = true;
            Label2.Text = "Wybierz czynność medyczną:";
        }        
        void przyciskiLekarzWidoczne() //widoczne menu wyboru lekarza
        {
            Label3.Visible = true;
            DropDownList2.Visible = true;
            Button2.Visible = true;
            Calendar1.Visible = true;
            Label3.Text = "Wybierz lekarza:";
        }

        void widokWybranejCzynnosci() // to co ma widziec pacjent jak juz wybral czynnosc
        {
            string czynnosc = DropDownList1.SelectedValue.ToString();

            Label2.Text = "Wybrana czynność: " + czynnosc;
            Label2.Visible = true;
            Calendar1.Visible = true;
        }

        void widokWybranegoLekarza()
        {
            string lekarz = DropDownList2.SelectedValue.ToString();

            Label3.Visible = true;
            Label3.Text = lekarz;
            Calendar1.Visible = true;
        }

        void widokWyboruGodziny() //wyswietla elementy do wybrania godziny
        {
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            Button4.Visible = true;
            Label_h.Visible = true;
            Label_m.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            widokZalogowanie();
        }

        void widokZalogowanie() // to co ma być widać po zalogowaniu
        {
            int status_zalogowania = 0;
            string login_email = TextBox1.Text.ToString();
            string haslo_pesel = TextBox2.Text.ToString();
            Pacjenci zalogowany_pacjent = new Pacjenci();

            foreach (Pacjenci pacjent in Pacjenci.ListaPacjentow)
                if (pacjent.Adres_email.Equals(login_email) && pacjent.Pesel.Equals(haslo_pesel))
                {
                    zalogowany_pacjent = pacjent;
                    status_zalogowania = 1;
                }

            if (status_zalogowania != 1)
            {
                Label6.Visible = true;
                Label6.BackColor = Color.Red;
                Label6.Text = "Podano niewłaściwe dane";
                return;
            }
            else 
            {
                Button3.Visible = false;
                Calendar1.Visible = true;
                Label4.Text = zalogowany_pacjent.Imie;
                Label5.Text = zalogowany_pacjent.Nazwisko;
                TextBox1.Visible = false;
                TextBox2.Visible = false;
                Label6.Visible = true;
                Label6.Text = "Wybierz pasujący Ci termin:";
            }


        }
        protected void Button4_Click(object sender, EventArgs e) // przycisk od zatwierdzenia wizyty
        {
            //sekcja do przerobienia godziny spotkania na int
            string zarezerwowana_godzina_tekst, zarezerwowana_minuta_tekst;
            int zarezerwowana_godzina, zarezerwowana_minuta;

            zarezerwowana_godzina_tekst = TextBox3.Text.ToString();
            zarezerwowana_minuta_tekst = TextBox4.Text.ToString();

            if (zarezerwowana_godzina_tekst.Length != 0 && zarezerwowana_minuta_tekst.Length != 0)
            {
                zarezerwowana_godzina = Convert.ToInt32(zarezerwowana_godzina_tekst);
                zarezerwowana_minuta = Convert.ToInt32(zarezerwowana_minuta_tekst);
            }
            else
            {
                Label_wybrana_godz.Visible = true;
                Label_wybrana_godz.BackColor = Color.Red;
                Label_wybrana_godz.Text = "Podaj poprawną godzinę spotkania";
                Label7.Visible = false;
                return;
            }
            //koniec sekcji

            //sekcja do wyciagniecia obiektu pracownik z danych podanych w logowaniu
            string login_email = TextBox1.Text.ToString();
            string haslo_pesel = TextBox2.Text.ToString();
            Pacjenci zalogowany_pacjent = new Pacjenci();

            foreach (Pacjenci pacjent in Pacjenci.ListaPacjentow)
                if (pacjent.Adres_email.Equals(login_email) && pacjent.Pesel.Equals(haslo_pesel))
                {
                    zalogowany_pacjent = pacjent;
                }
            //koniec sekcji

            //sekcja przypisania do obiektu ZaplanowaneCzynnosci wartosci czasu i poprawienie ich formatu
            ZaplanowaneCzynnosciMedyczne zaplanowana_czynnosc = new ZaplanowaneCzynnosciMedyczne();
            zaplanowana_czynnosc.Godz_rozpoczecia = zarezerwowana_godzina;
            zaplanowana_czynnosc.Min_rozpoczecia = zarezerwowana_minuta;
           
            if (zaplanowana_czynnosc.Min_rozpoczecia == 50)
            {
                zaplanowana_czynnosc.Godz_zakonczenia = zaplanowana_czynnosc.Godz_rozpoczecia + 1;
                zaplanowana_czynnosc.Min_zakonczenia = 0;
            }
            else
            {
                zaplanowana_czynnosc.Godz_zakonczenia = zaplanowana_czynnosc.Godz_rozpoczecia;
                zaplanowana_czynnosc.Min_zakonczenia = zaplanowana_czynnosc.Min_rozpoczecia + 10;
            }
            //koniec sekcji

            //sekcja poobrania obiektu pracownik
            string wybrany_pracownik = DropDownList2.SelectedValue.ToString();
            Pracownicy wybrany_pracownik_obiekt = new Pracownicy();
            
            foreach(Pracownicy pracownik in Pracownicy.ListaPracownikow)
                if (wybrany_pracownik.Contains(pracownik.Imie) && wybrany_pracownik.Contains(pracownik.Nazwisko))
                    wybrany_pracownik_obiekt = pracownik;
            //koniec sekcji

            //sekcja pobrania obiektu czynnosc medyczna
            string wybrana_czynnosc = DropDownList1.SelectedValue.ToString();
            Czynności_medyczne wybrana_czynnosc_obiekt = new Czynności_medyczne();

            foreach (Czynności_medyczne czynnosc in Czynności_medyczne.ListaCzynnosciMedycznych)
                if (wybrana_czynnosc.Contains(czynnosc.Nazwa_czynnosci))
                    wybrana_czynnosc_obiekt = czynnosc;
            //koniec sekcji

            //sekcja pobrania obiektu godzina
            DateTime data = Calendar1.SelectedDate;
            GodzinyPracy wybrana_godzina_obiekt = new GodzinyPracy();

            foreach (GodzinyPracy godzina in GodzinyPracy.ListaGodzinPracy)
                if (godzina.Data_dnia_pracy.Year == data.Year && godzina.Data_dnia_pracy.Month == data.Month && godzina.Data_dnia_pracy.Day == data.Day && wybrany_pracownik.Contains(godzina.Czas_ropoczecia.ToString()) && wybrany_pracownik.Contains(godzina.Czas_zakonczenia.ToString()) && wybrany_pracownik_obiekt.Imie == godzina.Pracownik.Imie && wybrany_pracownik_obiekt.Nazwisko == godzina.Pracownik.Nazwisko)
                    wybrana_godzina_obiekt = godzina;
            //koniec sekcji

            //przypisanie wartosci do zaplanowanej czynnosci
            zaplanowana_czynnosc.Nazwa_czynnosci = wybrana_czynnosc_obiekt.Nazwa_czynnosci;
            zaplanowana_czynnosc.Pacjent = zalogowany_pacjent;
            zaplanowana_czynnosc.Pracownik = wybrany_pracownik_obiekt;
            zaplanowana_czynnosc.Data_czynnosci = wybrana_godzina_obiekt.Data_dnia_pracy;
            //koniec sekcji

            //sekcja sprawdzenia kolizji danych
            if (zaplanowana_czynnosc.Godz_rozpoczecia < wybrana_godzina_obiekt.Czas_ropoczecia || zaplanowana_czynnosc.Godz_zakonczenia > wybrana_godzina_obiekt.Czas_zakonczenia || zaplanowana_czynnosc.Godz_rozpoczecia == wybrana_godzina_obiekt.Czas_zakonczenia)
            {
                Label_wybrana_godz.Visible = true;
                Label6.BackColor = Color.Red;
                Label_wybrana_godz.Text = "Wybierz godzinę i czas trwania wizyty w ramach czasowych pracy wybranego pracownika";
                Label7.Visible = false;
                return;
            }

            int licznik_bledu = 0;

            foreach (ZaplanowaneCzynnosciMedyczne zaplanowane in ZaplanowaneCzynnosciMedyczne.ListaZaplanowanychCzynnosci)
            {

                if (zaplanowana_czynnosc.Data_czynnosci.Year == zaplanowane.Data_czynnosci.Year && zaplanowana_czynnosc.Data_czynnosci.Month == zaplanowane.Data_czynnosci.Month && zaplanowana_czynnosc.Data_czynnosci.Day == zaplanowane.Data_czynnosci.Day && zaplanowana_czynnosc.Pracownik.Imie == zaplanowane.Pracownik.Imie && zaplanowana_czynnosc.Pracownik.Nazwisko == zaplanowane.Pracownik.Nazwisko && zaplanowana_czynnosc.Godz_rozpoczecia == zaplanowane.Godz_rozpoczecia && zaplanowana_czynnosc.Min_rozpoczecia == zaplanowane.Min_rozpoczecia)
                {
                    licznik_bledu = 1;
                    break;
                }
            }

            if (licznik_bledu == 1)
            {
                Label_wybrana_godz.Visible = true;
                Label_wybrana_godz.BackColor = Color.Red;
                Label_wybrana_godz.Text = "Podane godziny kolidują z inną już zaplanowaną czynnością medyczną na ten dzień";
                Label7.Visible = false;
                return;
            }

            ZaplanowaneCzynnosciMedyczne.ListaZaplanowanychCzynnosci.Add(zaplanowana_czynnosc);

            wyswietlZajeteTerminy();
            Label_wybrana_godz.Visible = true;
            Label_wybrana_godz.BackColor = Color.Green;
            Label_wybrana_godz.Text = "Zostałeś zapisany na wizytę!";
        }












        protected void Button2_Click(object sender, EventArgs e)
        {
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e) // zmiana wyboru czynnosci medycznej
        {
        }
        protected void ListBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}