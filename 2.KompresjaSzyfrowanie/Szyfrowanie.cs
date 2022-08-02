using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2.KompresjaSzyfrowanie
{
    internal class Szyfrowanie
    {
        private static bool odkodowanie;

        public static void zaszyfrujPlik(string haslo, string plik_wejsciowy, string plik_wyjsciowy)
        {
            CryptFile(haslo, plik_wejsciowy, plik_wyjsciowy, true);
        }


        public static void odszyfrujPlik(string haslo, string plik_wejsciowy, string plik_wyjsciowy)
        {
            CryptFile(haslo, plik_wejsciowy, plik_wyjsciowy, true);
        }



        public static void CryptFile(string haslo, string plik_wejsciowy, string plik_wyjsciowy, bool encrypt)
        {
            using (FileStream wejscie = new FileStream(plik_wejsciowy, FileMode.Open, FileAccess.Read))
            {
                using (FileStream wyjscie = new FileStream(plik_wyjsciowy, FileMode.Create, FileAccess.Write))
                {

                    CryptStream(haslo, wejscie, wyjscie, encrypt);
                }
            }
        }
        public static void CryptStream(string haslo, Stream wejscie, Stream wyjscie, bool encrypt)
        {
            // Używamy operatora AES do szyfrowania
            AesCryptoServiceProvider aes_provider = new AesCryptoServiceProvider();

            // Wyszukiwanie długości klucza
            int bitow_klucza = 0;
            for (int i = 1024; i > 1; i--)
            {
                if (aes_provider.ValidKeySize(i))
                {
                    bitow_klucza = i;
                    break;
                }
            }
            Debug.Assert(bitow_klucza > 0);
            Console.WriteLine("D?ugo?? Klucza: " + bitow_klucza);

            // Pobieramy rozmiar bloku dla operatora AES
            int rozmiar_bloku = aes_provider.BlockSize;

            // Generowanie Klucza
            byte[] klucz = null;
            byte[] wektor = null;
            byte[] kod = { 0x0, 0x0, 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0xF1, 0xF0, 0xEE, 0x21, 0x22, 0x45 };
            TwKlucz_wektor(haslo, klucz, bitow_klucza, rozmiar_bloku, out klucz, out wektor);

            // Szyfrowanie czy Odszyfrowywanie
            ICryptoTransform SzyfroTransformacja;
            if (odkodowanie)
            {
                SzyfroTransformacja = aes_provider.CreateEncryptor(klucz, wektor);
            }
            else
            {
                SzyfroTransformacja = aes_provider.CreateDecryptor(klucz, wektor);
            }


            // gdy używamy niewłaściwego hasła zamykamy strumień
            try
            {
                using (CryptoStream strumien_crypto = new CryptoStream(wyjscie, SzyfroTransformacja, CryptoStreamMode.Write))
                {
                    // kodowanie lub odkodowywanie pliku
                  //  const int rozmiar_bloku = 1024;
                    byte[] bufor = new byte[rozmiar_bloku];
                    int odczytane_bity;
                    while (true)
                    {
                        // Czytamy.
                        odczytane_bity = wejscie.Read(bufor, 0, rozmiar_bloku);
                        if (odczytane_bity == 0) break;

                        // zapisujemy odczytane bity do strumienia.
                        strumien_crypto.Write(bufor, 0, odczytane_bity);
                    }
                }
            }
            catch
            {
            }

            SzyfroTransformacja.Dispose();
        }
        private static void TwKlucz_wektor(string haslo, byte[] kod, int bitow_klucza, int rozmiar_bloku, out byte[] klucz, out byte[] wektor)
        {
            Rfc2898DeriveBytes zamotaneBajty = new Rfc2898DeriveBytes(haslo, kod, 1500);

            klucz = zamotaneBajty.GetBytes(bitow_klucza / 8);
            wektor = zamotaneBajty.GetBytes(rozmiar_bloku / 8);
        }
    }
}
