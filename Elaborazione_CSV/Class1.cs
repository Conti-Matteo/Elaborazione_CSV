using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaborazione_CSV
{
    public class ElaborazioneCSV
    {
        public static Random r = new Random();

        #region azione1
        public int Azione1()
        {
            string s;
            int i = 0;
            int giusto = 0;
            StreamWriter writer = new StreamWriter("conti.csv", append: false);

            if (File.Exists("conti.csv"))
            {
                StreamReader reader = new StreamReader("conti.csv");
                s = reader.ReadLine();
                while (s != null)
                {
                    if (i == 0)
                    {
                        writer.WriteLine(s + ";Valore Randomico;Campo Cancellazione Logica;Campo Univoco");
                    }
                    else
                    {
                        int valore = r.Next(0, 21);
                        writer.WriteLine(s + ";" + valore + ";false;" + i + "");
                    }
                    i++;
                    s = reader.ReadLine();
                }
                reader.Close();
            }
            else
            {
                giusto = 1;
            }
            writer.Close();

            return giusto;
        }
        #endregion

        #region azione2
        public int Azione2()
        {
            string s;
            int count;
            StreamReader reader = new StreamReader("conti.csv");
            s = reader.ReadLine();
            reader.Close();
            return count = s.Split(';').Length;

        }
        #endregion

        #region azione3
        public int Azione3()
        {
            StreamReader reader = new StreamReader("conti.csv");
            int lunghezzaStringa = 0, lunghezzaMax = 0, i = 0;
            string s;

            s = reader.ReadLine();
            while (s != null)
            {
                lunghezzaStringa = s.Length;
                if (i != 0)
                {
                    if (lunghezzaMax < lunghezzaStringa)
                    {
                        lunghezzaMax = s.Length;
                    }
                }
                s = reader.ReadLine();
                i++;
            }
            reader.Close();
            return lunghezzaMax;
        }
        #endregion

        #region azione4
        public void Azione4()
        {
            string s;
            int i = 0;
            StreamReader reader = new StreamReader("conti.csv");
            StreamWriter writer = new StreamWriter("temporaneo.csv");

            s = reader.ReadLine();
            while (s != null)
            {
                if (i != 0)
                {
                    writer.WriteLine(s.PadRight(200));
                }
                else
                {
                    writer.WriteLine(s.PadRight(200));
                }

                s = reader.ReadLine();
                i++;
            }

            reader.Close();
            writer.Close();

            File.Replace("temporaneo.csv", "conti.csv", "backup.csv");
        }
        #endregion

        #region azione5
        public void Azione5(string comune, string provincia, string tipo, string categoria, string denominazione, string indirizzo, int cap, string località, int telefono, int fax, string email, string sito, int camere, int letti, int bagni, int appartamenti)
        {
            int i = 0;
            StreamReader reader = new StreamReader("conti.csv");
            string line = reader.ReadLine();
            while (line != null)
            {
                i++;
                line = reader.ReadLine();
            }
            reader.Close();
            var oStream = new FileStream("conti.csv", FileMode.Append, FileAccess.Write, FileShare.Read);
            BinaryWriter writer = new BinaryWriter(oStream);
            string linea = $"{comune};{provincia};{tipo};{categoria};{denominazione};{indirizzo};{cap};{località};{telefono};{fax};{email};{sito};{camere};{letti};{bagni};{appartamenti};{r.Next(0,21)};true;".PadRight(200);
            byte[] data = Encoding.ASCII.GetBytes(linea);
            writer.Write(data);

            writer.Close();
            oStream.Close();
        }
        #endregion

        #region azione7
        public int Azione7(string parola)
        {
            StreamReader reader = new StreamReader("conti.csv");
            string s;
            int i = 0;
            s = reader.ReadLine();
            while (s != null)
            {

                String[] split = s.Split(';');
                String[] split1 = split[Azione2() - 1].Split(' ');

                if (split1[0] == parola)
                {
                    reader.Close();
                    return i;
                }

                i++;
                s = reader.ReadLine();

            }
            reader.Close();
            return -1;
        }
        #endregion 

        #region azione8
        public  void Azione8(string comune, string provincia, string tipo, string categoria, string denominazione, string indirizzo, int cap, string località, int telefono, int fax, string email, string sito, int camere, int letti, int bagni, int appartamenti, int linea)
        {
            var oStream = new FileStream("conti.csv", FileMode.Open, FileAccess.Write, FileShare.Read);
            BinaryWriter writer = new BinaryWriter(oStream);

            oStream.Seek(0, SeekOrigin.Begin);

            oStream.Seek((200 * linea), SeekOrigin.Current);
            string s = $"{comune};{provincia};{tipo};{categoria};{denominazione};{indirizzo};{cap};{località};{telefono};{fax};{email};{sito};{camere};{letti};{bagni};{appartamenti};{linea}".PadRight(200);
            byte[] data = Encoding.ASCII.GetBytes(s);
            writer.Write(data);

            writer.Close();
        }
        #endregion

        #region azione9
        public int Azione9(string ricerca)
        {
            int riga = Azione7(ricerca);
            int i = 0;
            int successo = 0;
            var readStream = new FileStream("conti.csv", FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryReader read = new BinaryReader(readStream);

            //Legge i dati e li converte in stringa
            readStream.Seek(0, SeekOrigin.Begin);
            readStream.Seek((200 * riga), SeekOrigin.Current);

            byte[] data = new byte[200];
            readStream.Read(data, 0, 200);
            string s = Encoding.ASCII.GetString(data);

            readStream.Close();
            read.Close();

            String[] split = s.Split(';');
            String[] split1 = split[7].Split(' ');

            var writeStream = new FileStream("conti.csv", FileMode.Open, FileAccess.Write, FileShare.Write);
            BinaryWriter writer = new BinaryWriter(writeStream);

            writeStream.Seek(0, SeekOrigin.Begin);
            writeStream.Seek((200 * riga), SeekOrigin.Current);

            //Scrive i dati
            string linea = $"{split[0]};{split[1]};{split[2]};{split[3]};{split[4]};{split[5]};{split[6]};{split[7]};{split[8]};{split[9]};{split[10]};{split[11]};{split[12]};{split[13]};{split[14]};{split[15]};{split[16]};{split[18]};true;{split[17]}".PadRight(200);
            byte[] data2 = Encoding.ASCII.GetBytes(linea);
            writer.Write(data2);
            successo = 1;

            writer.Close();
            writeStream.Close();

            return successo;
        }
        #endregion
    }
}
