using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proiect_Practica
{
    public static class AbonamentService
    {
        public static List<Abonament> IncarcaDinCSV(string path)
        {
            var abonamente = new List<Abonament>();

            if (!File.Exists(path))
            {
                MessageBox.Show("Fișierul nu a fost găsit.");
                return abonamente;
            }

            try
            {
                var linii = File.ReadAllLines(path);
                if (linii.Length < 2)
                {
                    MessageBox.Show("Fișierul nu conține suficiente rânduri.");
                    return abonamente;
                }

                for (int i = 1; i < linii.Length; i++) // Ignorăm antetul
                {
                    var linie = linii[i].Trim();
                    if (string.IsNullOrWhiteSpace(linie)) continue;

                    var campuri = linie.Split(',');
                    if (campuri.Length != 10)
                    {
                        MessageBox.Show($"Linia {i + 1} are un număr invalid de coloane: {campuri.Length}");
                        continue;
                    }

                    try
                    {
                        var abonament = new Abonament
                        {
                            TipAbonament = campuri[0].Trim(),
                            TipPachet = campuri[1].Trim(),
                            Revista = campuri[2].Trim(),
                            Status = campuri[3].Trim(),
                            DataStart = ParseData(campuri[4]),
                            DataEnd = ParseData(campuri[5]),
                            OrderId = int.Parse(campuri[6].Trim()),
                            DataOrder = ParseDataOra(campuri[7]),
                            DinImport = campuri[8].Trim(),
                            UserId = int.Parse(campuri[9].Trim())
                        };

                        abonamente.Add(abonament);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Eroare la linia {i + 1}: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare generală la citire: " + ex.Message);
            }

            return abonamente;
        }

        private static DateTime ParseData(string valoare)
        {
            string[] formate = { "yyyy-MM-dd", "dd/MM/yyyy" };
            if (DateTime.TryParseExact(valoare.Trim(), formate, null, System.Globalization.DateTimeStyles.None, out DateTime data))
                return data;

            throw new FormatException($"Data invalidă: {valoare}");
        }

        private static DateTime ParseDataOra(string valoare)
        {
            string[] formate = { "yyyy-MM-dd HH:mm:ss", "dd/MM/yyyy HH:mm", "yyyy-MM-ddTHH:mm:ss" };
            if (DateTime.TryParseExact(valoare.Trim(), formate, null, System.Globalization.DateTimeStyles.None, out DateTime data))
                return data;

            throw new FormatException($"Data/ora invalidă: {valoare}");
        }




        public static void SalveazaInCSV(string path, List<Abonament> abonamente)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("TipAbonament,TipPachet,Revista,Status,DataStart,DataEnd,OrderId,DataOrder,DinImport,UserId");
                    foreach (var a in abonamente)
                    {
                        sw.WriteLine($"{a.TipAbonament},{a.TipPachet},{a.Revista},{a.Status},{a.DataStart:yyyy-MM-dd},{a.DataEnd:yyyy-MM-dd},{a.OrderId},{a.DataOrder:yyyy-MM-dd HH:mm:ss},{a.DinImport},{a.UserId}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }
    }
}
