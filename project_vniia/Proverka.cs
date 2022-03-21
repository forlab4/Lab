using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_vniia
{
    class Item_Proverka
    {
        
        public static float b0 { get; private set; }
        public float b { get; private set; }
        public float b1 { get; private set; }
        public float b2 { get; private set; }
        public float b3 { get; private set; }
        public float b4 { get; private set; }
        public float b5 { get; private set; }
        public float b6 { get; private set; }
        public float b7 { get; private set; }

        public float b8 { get; private set; }
        public float b9 { get; private set; }
        public float b10 { get; private set; }
        public float b11 { get; private set; }
        public float b12 { get; private set; }
        public float b13 { get; private set; }
        public float b14 { get; private set; }
        public float b15 { get; private set; }
        public Item_Proverka(string str, int r)
        {
            string[] parts = str.ToLower().Split(new char[] { ' ' });
            for(int i=0; i<parts.Length; i++)
            {
                if (Proverka.k == 2)
                {
                    Form1.Flags_1 = true;
                    break;
                }
                if (Form1.Flags == true || Form1.Flags_1 == true)
                {
                   int j = 0;
                    foreach (string p in parts)
                    {
                        float num;
                        if (p != "")
                        {
                                try
                                {
                                    string pp = p.Replace('.', ',');
                                if (pp.Contains(":"))
                                {
                                    pp = pp.Substring(pp.IndexOf(':') + 1);
                                }
                                bool no = float.TryParse(pp, out num);

                                if (no)
                                {
                                    switch (j)
                                    {
                                        case 0:
                                            b = float.Parse(pp);
                                            b0 = b;
                                            j = j + 1;
                                            break;
                                        case 1:
                                            b1 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 2:
                                            b2 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 3:
                                            b3 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 4:
                                            b4 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 5:
                                            b5 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 6:
                                            b6 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 7:
                                            b7 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 8:
                                            b8 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 9:
                                            b9 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 10:
                                            b10 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 11:
                                            b11 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 12:
                                            b12 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 13:
                                            b13 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 14:
                                            b14 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 15:
                                            b15 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                    }
                                }
                                }
                                catch (Exception l)
                                {
                                    Console.WriteLine(l.Message);
                                }
                            
                        }
                    }
                    if (j == r)
                    {
                        Form1.Flags_1 = false;
                        break;
                    }
                }

                if (i < parts.Length - 2)
                {
                    if (parts[i].Contains("погрешность") && parts[i + 1].Contains("порогов") &&
                        parts[i + 2].Contains("дискриминации,%"))
                    {
                        Form1.Flags = true;
                        break;
                    }
                }

                b0 = b;
                Form1.Flags = false;
            } 
             
        }
    }
    
    class Item_Prov_Obnarug
    {
        public static string istochnik { get; set; }
        public static float b0 { get; private set; }
        public float b { get; private set; }
        public float b1 { get; private set; }
        public float b2 { get; private set; }
        public float b3 { get; private set; }
        public float b4 { get; private set; }
        public float b5 { get; private set; }
        public float b6 { get; private set; }
        public float b7 { get; private set; }

        public float b8 { get; private set; }
        public float b9 { get; private set; }
        public float b10 { get; private set; }
        public float b11 { get; private set; }
        public float b12 { get; private set; }
        public float b13 { get; private set; }
        public float b14 { get; private set; }
        public float b15 { get; private set; }
        public Item_Prov_Obnarug(string str, int r)
        {
            string[] parts = str.ToLower().Split(new char[] { ' ' });
            for (int i = 0; i < parts.Length; i++)
            {
                if (i < parts.Length - 2)
                {
                    if (parts[i].Contains("проверка") && parts[i + 1].Contains("обнаружения") &&
                        parts[i + 2].Contains("ям"))
                    {
                        Form1.Flags = true;
                        break;
                    }

                    if (parts[i].Contains("нестабильность") && parts[i + 1].Contains("фона") &&
                        parts[i + 2].Contains("nf1/nf2:"))
                    {
                        istochnik = parts[i];
                        break;
                    }
                    else
                    {
                        istochnik = "k";
                    }
                }

                if (i < parts.Length - 1)
                {
                    if (parts[i].Contains("сигнал") && parts[i + 1].Contains("(имп/с)"))
                    {
                        Form1.Flags_1 = true;
                        break;
                    }

                    if (parts[i].Contains("количество") && parts[i + 1].Contains("обнаружений"))
                    {
                        Form1.Flags_1 = true;
                        break;
                    }
                }

                if (Form1.Flags == true && Form1.Flags_1 == true)
                {
                    int j = 0;
                    foreach (string p in parts)
                    {
                        float num;
                        if (p != "")
                        {
                            try
                            {
                                string pp = p.Replace('.', ',');
                                if (pp.Contains(":"))
                                {
                                    pp = pp.Substring(pp.IndexOf(':') + 1);
                                }
                                bool no = float.TryParse(pp, out num);

                                if (no)
                                {
                                    switch (j)
                                    {
                                        case 0:
                                            b = float.Parse(pp);
                                            b0 = b;
                                            j = j + 1;
                                            break;
                                        case 1:
                                            b1 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 2:
                                            b2 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 3:
                                            b3 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 4:
                                            b4 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 5:
                                            b5 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 6:
                                            b6 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 7:
                                            b7 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 8:
                                            b8 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 9:
                                            b9 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 10:
                                            b10 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 11:
                                            b11 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 12:
                                            b12 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 13:
                                            b13 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 14:
                                            b14 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 15:
                                            b15 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                    }
                                    //b = Convert.ToDouble(pp);
                                    if (j == r)
                                        break;
                                }
                            }
                            catch (Exception l)
                            {
                                Console.WriteLine(l.Message);
                            }

                        }
                    }
                    if (j == r)
                    {
                        Form1.Flags_1 = false;
                        break;
                    }
                    Form1.Flags_1 = false;///????????????????????????
                }
            }
        }
    }

    class Item_Prov_Chuvstv
    {
        public static float b0 { get; set; }
        public static string istochnik { get; private set; }
        public float b { get; private set; }
        public float b1 { get; private set; }
        public float b2 { get; private set; }
        public float b3 { get; private set; }
        public float b4 { get; private set; }
        public float b5 { get; private set; }
        public float b6 { get; private set; }
        public float b7 { get; private set; }

        public float b8 { get; private set; }
        public float b9 { get; private set; }
        public float b10 { get; private set; }
        public float b11 { get; private set; }
        public float b12 { get; private set; }
        public float b13 { get; private set; }
        public float b14 { get; private set; }
        public float b15 { get; private set; }
        public Item_Prov_Chuvstv(string str, int r)
        {
            string[] parts = str.ToLower().Split(new char[] { ' ' });

            for (int i = 0; i < parts.Length; i++)
            {
                if (i < parts.Length - 2)
                {
                    if (parts[i].Contains("проверка") && parts[i + 1].Contains("чувствительности") &&
                        parts[i + 2].Contains("бд"))
                    {
                        Form1.Flags = true;
                        break;
                    }
                    if (parts[i].Contains("нестабильность") && parts[i + 1].Contains("фона") && parts[i + 2].Contains("nf1/nf2:"))
                    {
                        Form1.Flags_ = true;
                        Form1.Flags_1 = true;
                        istochnik = parts[i];
                        break;
                    }

                }

                if (i < parts.Length - 1)
                {
                    if (parts[i].Contains("тип") && parts[i + 1].Contains("источника:сm") ||
                        parts[i].Contains("тип") && parts[i + 1].Contains("источника:cf") ||
                        parts[i].Contains("тип") && parts[i + 1].Contains("источника:cs") ||
                        parts[i].Contains("тип") && parts[i + 1].Contains("источника:u") ||
                        parts[i].Contains("тип") && parts[i + 1].Contains("источника:pu"))

                    {
                        Form1.Flags_1 = true;
                        istochnik = parts[i + 1];
                        break;
                    }
                }

                try
                {
                    if (parts[i].Contains("чувствительность") && parts[i + 1].Contains("(имп/(с*г)"))
                    {
                        Form1.Flags_ = true;
                        break;
                    }
                }
                catch (Exception p)
                { Console.WriteLine(p.Message); }

               
            }
            if (Form1.Flags == true && Form1.Flags_1 == true && Form1.Flags_ == true)
            {
                int j = 0;
                foreach (string p in parts)
                {
                    float num;
                    if (p != "")
                    {
                        try
                        {
                            string pp = p.Replace('.', ',');
                            if (pp.Contains(":"))
                            {
                                pp = pp.Substring(pp.IndexOf(':') + 1);
                            }
                            bool no = float.TryParse(pp, out num);

                            if (no)
                            {
                                switch (j)
                                {
                                    case 0:
                                        b = float.Parse(pp);
                                        b0 = b;
                                        j = j + 1;
                                        break;
                                    case 1:
                                        b1 = float.Parse(pp);
                                        j = j + 1;
                                        break;
                                    case 2:
                                        b2 = float.Parse(pp);
                                        j = j + 1;
                                        break;
                                    case 3:
                                        b3 = float.Parse(pp);
                                        j = j + 1;
                                        break;
                                    case 4:
                                        b4 = float.Parse(pp);
                                        j = j + 1;
                                        break;
                                    case 5:
                                        b5 = float.Parse(pp);
                                        j = j + 1;
                                        break;
                                    case 6:
                                        b6 = float.Parse(pp);
                                        j = j + 1;
                                        break;
                                    case 7:
                                        b7 = float.Parse(pp);
                                        j = j + 1;
                                        break;
                                    case 8:
                                        b8 = float.Parse(pp);
                                        j = j + 1;
                                        break;
                                    case 9:
                                        b9 = float.Parse(pp);
                                        j = j + 1;
                                        break;
                                    case 10:
                                        b10 = float.Parse(pp);
                                        j = j + 1;
                                        break;
                                    case 11:
                                        b11 = float.Parse(pp);
                                        j = j + 1;
                                        break;
                                    case 12:
                                        b12 = float.Parse(pp);
                                        j = j + 1;
                                        break;
                                    case 13:
                                        b13 = float.Parse(pp);
                                        j = j + 1;
                                        break;
                                    case 14:
                                        b14 = float.Parse(pp);
                                        j = j + 1;
                                        break;
                                    case 15:
                                        b15 = float.Parse(pp);
                                        j = j + 1;
                                        break;
                                }
                                //b = Convert.ToDouble(pp);
                                if (j == r)
                                    break;
                            }
                        }
                        catch (Exception l)
                        {
                            Console.WriteLine(l.Message);
                        }

                    }
                }
                if (j == r)
                {
                    Form1.Flags_1 = false;
                    Form1.Flags_ = false;
                }

            }

        }
    }

    class Item_Prov_LognS
    {
        
        public static float b0 { get; set; }
        public float b { get; private set; }
        public float b1 { get; private set; }
        public float b2 { get; private set; }
        public float b3 { get; private set; }
        public float b4 { get; private set; }
        public float b5 { get; private set; }
        public float b6 { get; private set; }
        public float b7 { get; private set; }

        public float b8 { get; private set; }
        public float b9 { get; private set; }
        public float b10 { get; private set; }
        public float b11 { get; private set; }
        public float b12 { get; private set; }
        public float b13 { get; private set; }
        public float b14 { get; private set; }
        public float b15 { get; private set; }
        public Item_Prov_LognS(string str, int r)
        {
            str.ToLower();
            string[] parts = str.ToLower().Split(new char[] { ' ' });
            for (int i = 0; i < parts.Length; i++)
            {
                if (i < parts.Length - 3)
                {
                    if (parts[i].Contains("проверка") && parts[i + 1].Contains("на") &&
                        parts[i + 2].Contains("ложные") && parts[i + 3].Contains("срабатывания"))
                    {
                        Form1.Flags = true;
                        break;
                    }
                }

                if (i < parts.Length - 2)
                {
                    if (Form1.Flags == true && parts[i].Contains("нестабильность") && parts[i + 1].Contains("фона") &&
                        parts[i + 2].Contains("nf1/nf2"))
                    {
                        Proverka.Logn = true;
                        break;
                    }
                }

                if (i < parts.Length - 7)
                {
                    if (parts[i].Contains("количество") && parts[i + 1].Contains("ложных") &&
                        parts[i + 2].Contains("срабатываний") && parts[i + 3].Contains("за")
                        && parts[i + 5].Contains("измерений") && parts[i + 6].Contains("по") &&
                        parts[i + 7].Contains("1с"))
                    {
                        Form1.Flags_1 = true;
                        break;
                    }
                }

                if (Form1.Flags == true && Form1.Flags_1 == true)
                {
                    int j = 0;
                    foreach (string p in parts)
                    {
                        float num;
                        if (p != "")
                        {
                            try
                            {
                                string pp = p.Replace('.', ',');
                                if (pp.Contains(":"))
                                {
                                    pp = pp.Substring(pp.IndexOf(':') + 1);
                                }
                                bool no = float.TryParse(pp, out num);

                                if (no)
                                {
                                    switch (j)
                                    {
                                        case 0:
                                            b = float.Parse(pp);
                                            b0 = 1022;
                                            j = j + 1;
                                            break;
                                        case 1:
                                            b1 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 2:
                                            b2 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 3:
                                            b3 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 4:
                                            b4 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 5:
                                            b5 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 6:
                                            b6 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 7:
                                            b7 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 8:
                                            b8 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 9:
                                            b9 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 10:
                                            b10 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 11:
                                            b11 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 12:
                                            b12 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 13:
                                            b13 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 14:
                                            b14 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                        case 15:
                                            b15 = float.Parse(pp);
                                            j = j + 1;
                                            break;
                                    }
                                    //b = Convert.ToDouble(pp);
                                    if (j == r)
                                        break;
                                }
                            }
                            catch (Exception l)
                            {
                                Console.WriteLine(l.Message);
                            }

                        }
                    }
                    if (j == r)
                    {
                        Form1.Flags_1 = false;
                        break;
                    }
                }
            }
            

        }
    }
    #region
    //class Proverka
    //{
    //    public static int k = 0;
        
    //    public static string[] parts;
    //    public double b { get; private set; }
    //    public static bool Logn = false;

    //    public int Kolvo(Item_Proverka item_o)
    //    {
    //        int h = 0;
    //        if (item_o.b != 0)
    //            h++;
    //        if (item_o.b1 != 0)
    //            h++;
    //        if (item_o.b2 != 0)
    //            h++;
    //        if (item_o.b3 != 0)
    //            h++;
    //        if (item_o.b4 != 0)
    //            h++;
    //        if (item_o.b5 != 0)
    //            h++;
    //        if (item_o.b6 != 0)
    //            h++;
    //        if (item_o.b7 != 0)
    //            h++;
    //        return h;
    //    }
        
    //    public void Main_Proverka(Form1 form1, DataTable First, DataTable Blocks, DataTable Sys_sb)
    //    {
    //        List<Item_Proverka> items = new List<Item_Proverka>();
    //        List<string> Fil = Directory.GetFiles(Form1.Proverka_ways, "*.txt").ToList<string>();
    //        foreach (var fil in Fil)
    //        {
    //            k = 0;
    //            string[] allStringFromFile = File.ReadAllLines(fil, Encoding.Default);

    //            int len = allStringFromFile.Length;

    //            items.Clear();

    //            string name = Path.GetFileNameWithoutExtension(fil); // returns File
    //            int r=8;
    //            parts = name.Split(new char[] { '_' });
    //            int rr = parts.Length;
    //            for (int i = 0; i < len; i++)
    //            {
    //                if (k == 4)
    //                {
    //                    Form1.Flags = false;
    //                    k = 0;
    //                }
    //                items.Add(new Item_Proverka(allStringFromFile[i], r));

    //                if (Item_Proverka.b0 != 0 || k == 2)
    //                {
    //                    if (k == 0)
    //                    {
    //                        Item_Proverka item_o = items.LastOrDefault();
    //                        if (rr != 1)
    //                            r = rr;// Kolvo(item_o);
    //                        Form1.Flags = true;
    //                    }
    //                    k++;
    //                }

    //            }
    //            DataTable table = new DataTable("Добавление_проверок");
    //            k = 4;
    //            table = First.Clone();
    //               table.BeginLoadData();

    //               float[] bbb = new float[8];
    //                float[] chuvstvit = new float[8];

    //                string curDate = DateTime.Now.ToShortDateString();
    //            #region mmm
    //            foreach (Item_Proverka item_ in items)
    //            {
    //                if (item_.b!= 0)
    //                {
    //                    switch (k)
    //                    {
    //                        case 4:
    //                            bbb[0] = item_.b;
    //                            bbb[1] = item_.b1;
    //                            bbb[2] = item_.b2;
    //                            bbb[3] = item_.b3;
    //                            bbb[4] = item_.b4;
    //                            bbb[5] = item_.b5;
    //                            bbb[6] = item_.b6;
    //                            bbb[7] = item_.b7;
    //                            break;
    //                        case 5:
    //                            if (item_.b > bbb[0]) { bbb[0] = item_.b; }
    //                            if (item_.b1 > bbb[1]) { bbb[1] = item_.b1; }
    //                            if (item_.b2 > bbb[2]) { bbb[2] = item_.b2; }
    //                            if (item_.b3 > bbb[3]) { bbb[3] = item_.b3; }
    //                            if (item_.b4 > bbb[4]) { bbb[4] = item_.b4; }
    //                            if (item_.b5 > bbb[5]) { bbb[5] = item_.b5; }
    //                            if (item_.b6 > bbb[6]) { bbb[6] = item_.b6; }
    //                            if (item_.b7 > bbb[7]) { bbb[7] = item_.b7; }
    //                            break;
    //                        case 6:
    //                            chuvstvit[0] = item_.b;
    //                            chuvstvit[1] = item_.b1;
    //                            chuvstvit[2] = item_.b2;
    //                            chuvstvit[3] = item_.b3;
    //                            chuvstvit[4] = item_.b4;
    //                            chuvstvit[5] = item_.b5;
    //                            chuvstvit[6] = item_.b6;
    //                            chuvstvit[7] = item_.b7;

    //                            if (rr != 1)
    //                            {
    //                                for (int j = 0; j < r; j++)
    //                                {
    //                                    if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                    {
    //                                        DataRow mynewrow = table.NewRow();
    //                                    mynewrow["Номер БД"] = parts[j];
    //                                    mynewrow["Пороги"] = bbb[j];
    //                                    mynewrow["S Cs 10 см"] = chuvstvit[j];
    //                                    mynewrow["Дата проверки"] = curDate;
    //                                    table.Rows.Add(mynewrow);
    //                                    }
    //                                    else
    //                                    {
    //                                        table.Rows[j]["Пороги"] = bbb[j];
    //                                        table.Rows[j]["S Cs 10 см"] = chuvstvit[j];
    //                                    }
    //                                }
    //                            }
    //                            else
    //                            {
    //                                if (r == 1)
    //                                {
    //                                    for (int j = 0; j < r; j++)
    //                                    {
    //                                            if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                            {
    //                                                DataRow mynewrow = table.NewRow();
    //                                        mynewrow["Номер БД"] = name;
    //                                        mynewrow["Пороги"] = bbb[j];
    //                                        mynewrow["S Cs 10 см"] = chuvstvit[j];
    //                                        mynewrow["Дата проверки"] = curDate;
    //                                        table.Rows.Add(mynewrow);
    //                                        }
    //                                        else
    //                                        {
    //                                            table.Rows[j]["Пороги"] = bbb[j];
    //                                            table.Rows[j]["S Cs 10 см"] = chuvstvit[j];
    //                                        }
    //                                    }
    //                                }
    //                                else
    //                                {
    //                                    for (int j = 0; j < r; j++)
    //                                    {
    //                                                if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                                {
    //                                                    DataRow mynewrow = table.NewRow();
    //                                        mynewrow["Номер БД"] = "?дополнить";
    //                                        mynewrow["Пороги"] = bbb[j];
    //                                        mynewrow["S Cs 10 см"] = chuvstvit[j];
    //                                        mynewrow["Дата проверки"] = curDate;
    //                                        mynewrow["Примечание"] = "В системе " + name;
    //                                        table.Rows.Add(mynewrow);
    //                                        }
    //                                        else
    //                                        {
    //                                            table.Rows[j]["Пороги"] = bbb[j];
    //                                            table.Rows[j]["S Cs 10 см"] = chuvstvit[j];
    //                                        }
    //                                    }
    //                                }
    //                            }
    //                            k = 3;
    //                            break;
    //                        default:
    //                            break;
    //                    }
    //                    k++;
    //                }
    //            }

    //            items.Clear();
    //            #endregion
    //            List<Item_Prov_Obnarug> itemr = new List<Item_Prov_Obnarug>();
    //            itemr.Clear();
    //            Form1.Flags = false;
    //            k = 0;

    //            for (int i = 0; i < len; i++)
    //            {
    //                itemr.Add(new Item_Prov_Obnarug(allStringFromFile[i], r));

    //                Item_Prov_Obnarug item_ = itemr.LastOrDefault();
    //                if (item_.b1 != 0)
    //                {
    //                    if (k == 1 || k % 2 != 0)
    //                    {
    //                        chuvstvit[0] = item_.b;
    //                        chuvstvit[1] = item_.b1;
    //                        chuvstvit[2] = item_.b2;
    //                        chuvstvit[3] = item_.b3;
    //                        chuvstvit[4] = item_.b4;
    //                        chuvstvit[5] = item_.b5;
    //                        chuvstvit[6] = item_.b6;
    //                        chuvstvit[7] = item_.b7;
    //                        if (rr != 1)
    //                        {
    //                            if (parts.Length < r)
    //                            {
    //                                r = parts.Length;
    //                            }
    //                            for (int j = 0; j < r; j++)
    //                            {
    //                                if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                {
    //                                    DataRow mynewrow = table.NewRow();
    //                                    mynewrow["Номер БД"] = parts[j];
    //                                    mynewrow["Q"] = bbb[j];
    //                                    mynewrow["Колличество срабатываний"] = chuvstvit[j];
    //                                    mynewrow["Дата проверки"] = curDate;
    //                                    table.Rows.Add(mynewrow);
    //                                }
    //                                else
    //                                {
    //                                    table.Rows[j]["Q"] = bbb[j];
    //                                    table.Rows[j]["Колличество срабатываний"] = chuvstvit[j];
    //                                }
    //                            }
    //                        }
    //                        else
    //                        {
    //                            if (r == 1)
    //                            {
    //                                for (int j = 0; j < r; j++)
    //                                {
    //                                    if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                    {
    //                                        DataRow mynewrow = table.NewRow();
    //                                        mynewrow["Номер БД"] = name;
    //                                        mynewrow["Q"] = bbb[j];
    //                                        mynewrow["Колличество срабатываний"] = chuvstvit[j];
    //                                        mynewrow["Дата проверки"] = curDate;
    //                                        table.Rows.Add(mynewrow);
    //                                    }
    //                                    else
    //                                    {
    //                                        table.Rows[j]["Q"] = bbb[j];
    //                                        table.Rows[j]["Колличество срабатываний"] = chuvstvit[j];
    //                                    }
    //                                }
    //                            }
    //                            else
    //                            {
    //                                for (int j = 0; j < r; j++)
    //                                {
    //                                    if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                    {
    //                                        DataRow mynewrow = table.NewRow();
    //                                        mynewrow["Номер БД"] = "?дополнить";
    //                                        mynewrow["Q"] = bbb[j];
    //                                        mynewrow["Колличество срабатываний"] = chuvstvit[j];
    //                                        mynewrow["Дата проверки"] = curDate;
    //                                        mynewrow["Примечание"] = "В системе " + name;
    //                                        table.Rows.Add(mynewrow);
    //                                    }
    //                                    else
    //                                    {
    //                                        table.Rows[j]["Q"] = bbb[j];
    //                                        table.Rows[j]["Колличество срабатываний"] = chuvstvit[j];
    //                                    }
    //                                }
    //                            }
    //                        }
    //                    }
    //                    else
    //                    {
    //                        bbb[0] = item_.b;
    //                        bbb[1] = item_.b1;
    //                        bbb[2] = item_.b2;
    //                        bbb[3] = item_.b3;
    //                        bbb[4] = item_.b4;
    //                        bbb[5] = item_.b5;
    //                        bbb[6] = item_.b6;
    //                        bbb[7] = item_.b7;
    //                    }
    //                    k++;
    //                    try
    //                    {
    //                        //// придумать как добавить break
    //                        if (Item_Prov_Obnarug.istochnik.Contains("Нестабильность") && item_.b != 0 && (item_.b == Item_Prov_Obnarug.b0))
    //                        {
    //                            Item_Prov_Obnarug.istochnik = "k";
    //                            //break;
    //                        }
    //                    }
    //                    catch (Exception p)
    //                    { }
    //                }
    //            }

    //            itemr.Clear();
    //            ////////////////////////////////////////
    //            bool cf_ = false;
    //            List<Item_Prov_Chuvstv> items_ = new List<Item_Prov_Chuvstv>();
    //            items_.Clear();

    //            Form1.Flags = false;
    //            Form1.Flags_ = false;
    //            double[,] vs = new double[8, 8];
    //            for (int vvv = 0; vvv < 8; vvv++)
    //            {
    //                for (int vj = 0; vj < 8; vj++)
    //                    vs[vvv, vj] = 0;
    //            }
    //            for (int i = 0; i < len; i++)
    //            {
    //                items_.Add(new Item_Prov_Chuvstv(allStringFromFile[i], r));
    //                if (Item_Prov_Chuvstv.b0 != 0)
    //                {
    //                    Item_Prov_Chuvstv item_o = items_.LastOrDefault();

    //                    if ((Item_Prov_Chuvstv.istochnik.Contains("Cs")|| Item_Prov_Chuvstv.istochnik.Contains("cs")) && item_o.b != 0 && (item_o.b == Item_Prov_Chuvstv.b0))
    //                    {
    //                        bbb[0] = item_o.b;
    //                        bbb[1] = item_o.b1;
    //                        bbb[2] = item_o.b2;
    //                        bbb[3] = item_o.b3;
    //                        bbb[4] = item_o.b4;
    //                        bbb[5] = item_o.b5;
    //                        bbb[6] = item_o.b6;
    //                        bbb[7] = item_o.b7;
    //                        if (rr != 1)
    //                        {
    //                            if (parts.Length < r)
    //                            {
    //                                r = parts.Length;
    //                            }
    //                            for (int j = 0; j < r; j++)
    //                            {
    //                                if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                {
    //                                    DataRow mynewrow = table.NewRow();
    //                                    mynewrow["Номер БД"] = parts[j];
    //                                    mynewrow["S Cs 50 см"] = bbb[j];
    //                                    mynewrow["Дата проверки"] = curDate;
    //                                    table.Rows.Add(mynewrow);
    //                                }
    //                                else
    //                                {
    //                                    table.Rows[j]["S Cs 50 см"] = bbb[j];
    //                                }
    //                            }
    //                            Form1.Flags_1 = false;
    //                            Form1.Flags_ = false;
    //                        }
    //                        else
    //                        {
    //                            if (r == 1)
    //                            {
    //                                for (int j = 0; j < r; j++)
    //                                {
    //                                    if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                    {
    //                                        DataRow mynewrow = table.NewRow();
    //                                        mynewrow["Номер БД"] = name;
    //                                        mynewrow["S Cs 50 см"] = bbb[j];
    //                                        mynewrow["Дата проверки"] = curDate;
    //                                        table.Rows.Add(mynewrow);
    //                                    }
    //                                    else
    //                                    {
    //                                        table.Rows[j]["S Cs 50 см"] = bbb[j];
    //                                    }
    //                                }
    //                            }
    //                            else
    //                            {
    //                                for (int j = 0; j < r; j++)
    //                                {
    //                                    if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                    {
    //                                        DataRow mynewrow = table.NewRow();
    //                                    mynewrow["Номер БД"] = "?дополнить";
    //                                    mynewrow["S Cs 50 см"] = bbb[j];
    //                                    mynewrow["Дата проверки"] = curDate;
    //                                    mynewrow["Примечание"] = "В системе " + name;
    //                                    table.Rows.Add(mynewrow);
    //                                    }
    //                                    else
    //                                    {
    //                                        table.Rows[j]["S Cs 50 см"] = bbb[j];
    //                                    }
    //                                }
    //                            }
    //                            Form1.Flags_1 = false;
    //                            Form1.Flags_ = false;
    //                        }
    //                    }
    //                    if (!Item_Prov_Chuvstv.istochnik.Contains("pu") && !Item_Prov_Chuvstv.istochnik.Contains("Pu") && (Item_Prov_Chuvstv.istochnik.Contains("U")|| Item_Prov_Chuvstv.istochnik.Contains("u")) && item_o.b != 0 && (item_o.b == Item_Prov_Chuvstv.b0))
    //                    {
    //                        bbb[0] = item_o.b;
    //                        bbb[1] = item_o.b1;
    //                        bbb[2] = item_o.b2;
    //                        bbb[3] = item_o.b3;
    //                        bbb[4] = item_o.b4;
    //                        bbb[5] = item_o.b5;
    //                        bbb[6] = item_o.b6;
    //                        bbb[7] = item_o.b7;
    //                        if (rr != 1)
    //                        {
    //                            for (int j = 0; j < r; j++)
    //                            {
    //                                if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                {
    //                                    DataRow mynewrow = table.NewRow();
    //                                    mynewrow["Номер БД"] = parts[j];
    //                                    mynewrow["S U 50 см"] = bbb[j];
    //                                    mynewrow["Дата проверки"] = curDate;
    //                                    table.Rows.Add(mynewrow);
    //                                }
    //                                else
    //                                {
    //                                    table.Rows[j]["S U 50 см"] = bbb[j];
    //                                }

    //                            }
    //                            Form1.Flags_1 = false;
    //                            Form1.Flags_ = false;
    //                        }
    //                        else
    //                        {
    //                            if (r == 1)
    //                            {
    //                                for (int j = 0; j < r; j++)
    //                                {
    //                                    if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                    {
    //                                        DataRow mynewrow = table.NewRow();
    //                                    mynewrow["Номер БД"] = name;
    //                                    mynewrow["S U 50 см"] = bbb[j];
    //                                    mynewrow["Дата проверки"] = curDate;
    //                                    table.Rows.Add(mynewrow);
    //                                    }
    //                                    else
    //                                    {
    //                                        table.Rows[j]["S U 50 см"] = bbb[j];
    //                                    }
    //                                }
    //                            }
    //                            else
    //                            {
    //                                for (int j = 0; j < r; j++)
    //                                {
    //                                    if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                    {
    //                                        DataRow mynewrow = table.NewRow();
    //                                    mynewrow["Номер БД"] = "?дополнить";
    //                                    mynewrow["S U 50 см"] = bbb[j];
    //                                    mynewrow["Дата проверки"] = curDate;
    //                                    mynewrow["Примечание"] = "В системе " + name;
    //                                    table.Rows.Add(mynewrow);
    //                                }
    //                                else
    //                                {
    //                                    table.Rows[j]["S U 50 см"] = bbb[j];
    //                                }
    //                            }
    //                            }
    //                            Form1.Flags_1 = false;
    //                            Form1.Flags_ = false;
    //                        }
    //                    }
    //                    if ((Item_Prov_Chuvstv.istochnik.Contains("Cf") || Item_Prov_Chuvstv.istochnik.Contains("cf") || Item_Prov_Chuvstv.istochnik.Contains("Pu")|| Item_Prov_Chuvstv.istochnik.Contains("pu")) && item_o.b != 0 && (item_o.b == Item_Prov_Chuvstv.b0))
    //                    {
    //                        if (Item_Prov_Chuvstv.istochnik.Contains("Cf") || Item_Prov_Chuvstv.istochnik.Contains("cf"))
    //                        {
    //                            cf_ = true;

    //                            int vv = 0;
    //                            for (int vj = 0; vj < 8; vj++)
    //                            {
    //                                if (vs[vv, vj] == 0)
    //                                {
    //                                    switch (vj)
    //                                    {
    //                                        case 0:
    //                                            vs[vv, vj] = item_o.b;
    //                                            break;
    //                                        case 1:
    //                                            vs[vv, vj] = item_o.b1;
    //                                            break;
    //                                        case 2:
    //                                            vs[vv, vj] = item_o.b2;
    //                                            break;
    //                                        case 3:
    //                                            vs[vv, vj] = item_o.b3;
    //                                            break;
    //                                        case 4:
    //                                            vs[vv, vj] = item_o.b4;
    //                                            break;
    //                                        case 5:
    //                                            vs[vv, vj] = item_o.b5;
    //                                            break;
    //                                        case 6:
    //                                            vs[vv, vj] = item_o.b6;
    //                                            break;
    //                                        case 7:
    //                                            vs[vv, vj] = item_o.b7;
    //                                            break;
    //                                    }
    //                                }
    //                                else { vv++; vj--; }
    //                            }
    //                            Form1.Flags_1 = false;
    //                            Form1.Flags_ = false;
    //                        }
    //                        else
    //                        {
    //                            bbb[0] = item_o.b;
    //                            bbb[1] = item_o.b1;
    //                            bbb[2] = item_o.b2;
    //                            bbb[3] = item_o.b3;
    //                            bbb[4] = item_o.b4;
    //                            bbb[5] = item_o.b5;
    //                            bbb[6] = item_o.b6;
    //                            bbb[7] = item_o.b7;
    //                            if (rr != 1)
    //                            {
    //                                for (int j = 0; j < r; j++)
    //                                {
    //                                    if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                    {
    //                                        DataRow mynewrow = table.NewRow();
    //                                        mynewrow["Номер БД"] = parts[j];
    //                                        mynewrow["S Pu/Cf 50 см"] = bbb[j];
    //                                        mynewrow["Дата проверки"] = curDate;
    //                                        table.Rows.Add(mynewrow);
    //                                    }
    //                                    else
    //                                    {
    //                                        table.Rows[j]["S Pu/Cf 50 см"] = bbb[j];
    //                                    }

    //                                }
    //                                Form1.Flags_1 = false;
    //                                Form1.Flags_ = false;
    //                            }
    //                            else
    //                            {
    //                                if (r == 1)
    //                                {
    //                                    for (int j = 0; j < r; j++)
    //                                    {
    //                                        if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                        {
    //                                            DataRow mynewrow = table.NewRow();
    //                                            mynewrow["Номер БД"] = name;
    //                                            mynewrow["S Pu/Cf 50 см"] = bbb[j];
    //                                            mynewrow["Дата проверки"] = curDate;
    //                                            table.Rows.Add(mynewrow);
    //                                        }
    //                                        else
    //                                        {
    //                                            table.Rows[j]["S Pu/Cf 50 см"] = bbb[j];
    //                                        }
    //                                    }
    //                                }
    //                                else
    //                                {
    //                                    for (int j = 0; j < r; j++)
    //                                    {
    //                                        if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                        {
    //                                            DataRow mynewrow = table.NewRow();
    //                                            mynewrow["Номер БД"] = "?дополнить";
    //                                            mynewrow["S Pu/Cf 50 см"] = bbb[j];
    //                                            mynewrow["Дата проверки"] = curDate;
    //                                            mynewrow["Примечание"] = "В системе " + name;
    //                                            table.Rows.Add(mynewrow);
    //                                        }
    //                                        else
    //                                        {
    //                                            table.Rows[j]["S Pu/Cf 50 см"] = bbb[j];
    //                                        }
    //                                    }
    //                                }
    //                                Form1.Flags_1 = false;
    //                                Form1.Flags_ = false;
    //                            }
    //                        }
    //                    }

    //                    if (Item_Prov_Chuvstv.istochnik.Contains("Нестабильность") && item_o.b != 0 && (item_o.b == Item_Prov_Chuvstv.b0))
    //                    {
    //                        bbb[0] = item_o.b;
    //                        bbb[1] = item_o.b1;
    //                        bbb[2] = item_o.b2;
    //                        bbb[3] = item_o.b3;
    //                        bbb[4] = item_o.b4;
    //                        bbb[5] = item_o.b5;
    //                        bbb[6] = item_o.b6;
    //                        bbb[7] = item_o.b7;
    //                        if (rr != 1)
    //                        {
    //                            for (int j = 0; j < r; j++)
    //                            {
    //                                if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == i)
    //                                {
    //                                    DataRow mynewrow = table.NewRow();
    //                                    mynewrow["Номер БД"] = parts[j];
    //                                    mynewrow["Нестабильность фона"] = bbb[j];
    //                                    mynewrow["Дата проверки"] = curDate;
    //                                    table.Rows.Add(mynewrow);
    //                                }
    //                                else
    //                                {
    //                                    table.Rows[j]["Нестабильность фона"] = bbb[j];
    //                                }

    //                            }
    //                            Form1.Flags_1 = false;
    //                            Form1.Flags_ = false;
    //                        }
    //                        else
    //                        {
    //                            if (r == 1)
    //                            {
    //                                for (int j = 0; j < r; j++)
    //                                {
    //                                    if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                    {
    //                                        DataRow mynewrow = table.NewRow();
    //                                    mynewrow["Номер БД"] = name;
    //                                    mynewrow["Нестабильность фона"] = bbb[j];
    //                                    mynewrow["Дата проверки"] = curDate;
    //                                    table.Rows.Add(mynewrow);
    //                                    }
    //                                    else
    //                                    {
    //                                        table.Rows[j]["Нестабильность фона"] = bbb[j];
    //                                    }
    //                                }
    //                            }
    //                            else
    //                            {
    //                                for (int j = 0; j < r; j++)
    //                                {
    //                                    if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                   {
    //                                       DataRow mynewrow = table.NewRow();
    //                                    mynewrow["Номер БД"] = "?дополнить";
    //                                    mynewrow["Нестабильность фона"] = bbb[j];
    //                                    mynewrow["Дата проверки"] = curDate;
    //                                    mynewrow["Примечание"] = "В системе " + name;
    //                                    table.Rows.Add(mynewrow);
    //                                    }
    //                                    else
    //                                    {
    //                                        table.Rows[j]["Нестабильность фона"] = bbb[j];
    //                                    }
    //                                }
    //                            }
    //                            Form1.Flags_1 = false;
    //                            Form1.Flags_ = false;
    //                        }
    //                        //break;
    //                    }

    //                    Item_Prov_Chuvstv.b0 = 0;

    //                }
    //            }
    //            if (cf_)
    //            {
    //                for(int i=0;i<8;i++)
    //                {
    //                    bbb[i] = 0;
    //                }
    //                for (int vj = 0; vj < 8; vj++)
    //                {
    //                    for (int vv = 0; vv < 8; vv++)
    //                    {
    //                        if (vs[vv, vj] > bbb[vj])
    //                        {
    //                            bbb[vj] = (float)vs[vv, vj];
    //                        }
                            
    //                    }
    //                }
    //                for (int i = 0; i < 8; i++)
    //                {
    //                    if (bbb[i] == 0)
    //                        break;
    //                    else
    //                    {
    //                        bbb[i] = bbb[i]*10000;
    //                    } 
    //                }
    //                if (rr != 1)
    //                {
    //                    for (int j = 0; j < r; j++)
    //                    {
    //                        if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                        {
    //                            DataRow mynewrow = table.NewRow();
    //                            mynewrow["Номер БД"] = parts[j];
    //                            mynewrow["S Pu/Cf 50 см"] = bbb[j];
    //                            mynewrow["Дата проверки"] = curDate;
    //                            table.Rows.Add(mynewrow);
    //                        }
    //                        else
    //                        {
    //                            table.Rows[j]["S Pu/Cf 50 см"] = bbb[j];
    //                        }

    //                    }
    //                    Form1.Flags_1 = false;
    //                    Form1.Flags_ = false;
    //                }
    //                else
    //                {
    //                    if (r == 1)
    //                    {
    //                        for (int j = 0; j < r; j++)
    //                        {
    //                            if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                            {
    //                                DataRow mynewrow = table.NewRow();
    //                                mynewrow["Номер БД"] = name;
    //                                mynewrow["S Pu/Cf 50 см"] = bbb[j];
    //                                mynewrow["Дата проверки"] = curDate;
    //                                table.Rows.Add(mynewrow);
    //                            }
    //                            else
    //                            {
    //                                table.Rows[j]["S Pu/Cf 50 см"] = bbb[j];
    //                            }
    //                        }
    //                    }
    //                    else
    //                    {
    //                        for (int j = 0; j < r; j++)
    //                        {
    //                            if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                            {
    //                                DataRow mynewrow = table.NewRow();
    //                                mynewrow["Номер БД"] = "?дополнить";
    //                                mynewrow["S Pu/Cf 50 см"] = bbb[j];
    //                                mynewrow["Дата проверки"] = curDate;
    //                                mynewrow["Примечание"] = "В системе " + name;
    //                                table.Rows.Add(mynewrow);
    //                            }
    //                            else
    //                            {
    //                                table.Rows[j]["S Pu/Cf 50 см"] = bbb[j];
    //                            }
    //                        }
    //                    }
    //                    Form1.Flags_1 = false;
    //                    Form1.Flags_ = false;
    //                }
    //            }

    //                items_.Clear();
    //            ////////////////////////////////

    //            List<Item_Prov_LognS> item_s = new List<Item_Prov_LognS>();
    //            item_s.Clear();

    //            Form1.Flags = false;
    //            Form1.Flags_1 = false;

    //            for (int i = 0; i < len; i++)
    //            {
    //                item_s.Add(new Item_Prov_LognS(allStringFromFile[i], r));
                    
    //                if (Item_Prov_LognS.b0 == 1022)
    //                {
    //                    Item_Prov_LognS item_o = item_s.LastOrDefault();
    //                    bbb[0] = item_o.b;
    //                    bbb[1] = item_o.b1;
    //                    bbb[2] = item_o.b2;
    //                    bbb[3] = item_o.b3;
    //                    bbb[4] = item_o.b4;
    //                    bbb[5] = item_o.b5;
    //                    bbb[6] = item_o.b6;
    //                    bbb[7] = item_o.b7;
    //                    Form1.Flags_1 = false;
    //                }
    //                Item_Prov_LognS.b0 = 0;
    //                if (Logn == true)
    //                {
    //                    if (rr != 1)
    //                    {
    //                        if(parts.Length < r)
    //                        {
    //                            r = parts.Length;
    //                        }
    //                        for (int j = 0; j < r; j++)
    //                      {
    //                        if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                        {
    //                            DataRow mynewrow = table.NewRow();
    //                            mynewrow["Номер БД"] = parts[j];
    //                            mynewrow["Ложные срабатывания"] = bbb[j];
    //                            mynewrow["Дата проверки"] = curDate;
    //                            table.Rows.Add(mynewrow);
    //                        }
    //                        else
    //                        {
    //                            table.Rows[j]["Ложные срабатывания"] = bbb[j];
    //                        }
                            
    //                      }
    //                        //break;
    //                    }
    //                    else
    //                    {
    //                        if (r == 1)
    //                        {
    //                            for (int j = 0; j < r; j++)
    //                            {
    //                                if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                {
    //                                    DataRow mynewrow = table.NewRow();
    //                                mynewrow["Номер БД"] = name;
    //                                mynewrow["Ложные срабатывания"] = bbb[j];
    //                                mynewrow["Дата проверки"] = curDate;
    //                                table.Rows.Add(mynewrow);
    //                                }
    //                                else
    //                                {
    //                                    table.Rows[j]["Ложные срабатывания"] = bbb[j];
    //                                }
    //                            }
    //                        }
    //                        else
    //                        {
    //                            for (int j = 0; j < r; j++)
    //                            {
    //                                if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
    //                                {
    //                                  DataRow mynewrow = table.NewRow();
    //                                mynewrow["Номер БД"] = "?дополнить";
    //                                mynewrow["Ложные срабатывания"] = bbb[j];
    //                                mynewrow["Дата проверки"] = curDate;
    //                                mynewrow["Примечание"] = "В системе " + name;
    //                                table.Rows.Add(mynewrow);
    //                                }
    //                                else
    //                                {
    //                                    table.Rows[j]["Ложные срабатывания"] = bbb[j];
    //                                }
    //                            }
    //                        }
    //                        //break;
    //                    }
    //                }
    //            }
    //            ////////////////////////////////////////
    //            ///
    //            Form1.Flags = false;
    //            Form1.Flags_1 = false;
    //            var rows_to_delete = new List<DataRow>();
    //            try
    //            {
    //                foreach (DataRow row in table.Rows)
    //                {
    //                string TableName = row["Ложные срабатывания"].ToString();
    //                string TableName1 = row["Нестабильность фона"].ToString();
    //                string TableName2 = row["S Pu/Cf 50 см"].ToString();
    //                string TableName3= row["S U 50 см"].ToString();
    //                string TableName4 = row["S Cs 50 см"].ToString();
    //                string TableName5 = row["Q"].ToString();
    //                string TableName6 = row["Колличество срабатываний"].ToString();
    //                string TableName7 = row["Пороги"].ToString();
    //                string TableName8 = row["S Cs 10 см"].ToString();
    //                if ((TableName == "" || TableName == "0" || TableName == null) && (TableName1 == "" || TableName1 == "0" || TableName1 == null) &&
    //                    (TableName2 == "" || TableName2 == "0" || TableName2 == null) && (TableName3 == "" || TableName3 == "0" || TableName3 == null) &&
    //                    (TableName4 == "" || TableName4 == "0" || TableName4 == null) && (TableName5 == "" || TableName5 == "0" || TableName5 == null) &&
    //                    (TableName6 == "" || TableName6 == "0" || TableName6 == null) && (TableName7 == "" || TableName7 == "0" || TableName7 == null) &&
    //                    (TableName8 == "" || TableName8 == "0" || TableName8 == null))
    //                {
    //                    rows_to_delete.Add(row);
    //                }
    //                }
    //                foreach (var r_ in rows_to_delete)
    //                {
    //                    table.Rows.Remove(r_);
    //                }
    //                ///////////////////
    //                ///Cf
    //                ////////////////////
    //                if (cf_)
    //                {
    //                    double[] massCf = new double[8];
    //                    int i = 0;
    //                    foreach (DataRow row in table.Rows)
    //                    {
    //                        double TableName2 = Convert.ToDouble(row["S Pu/Cf 50 см"]);
    //                        if (TableName2 == 0)
    //                        { massCf[i] = 0; break; }
    //                        else massCf[i] = TableName2;
    //                        i++;
    //                    }
    //                    int koll=0;
    //                    foreach (var cf in massCf)
    //                    {
    //                        if (cf != 0)
    //                            koll++;
    //                    }
    //                    for (int j = 0; j != koll; j++)
    //                    {
    //                        table.Rows[j]["S Pu/Cf 50 см"] = 0;
    //                    }
    //                    foreach (var cf in massCf)
    //                    {
    //                        if (koll == 0)
    //                        {
    //                            break;
    //                        }
    //                        for (int j = table.Rows.Count; j != 0; j--)
    //                        {
    //                            table.Rows[j - koll]["S Pu/Cf 50 см"] = cf;
    //                            koll--;
    //                            break;
    //                        }
    //                    }
    //                    cf_ = false;
    //                }
    //                    ///////////////////
    //                    rows_to_delete.Clear();

    //            }
    //            catch (Exception p)
    //            {
    //                MessageBox.Show(p.ToString());
    //            }
    //            var conn_tabl = new OleDbConnection(Form1.conString);
    //            conn_tabl.Open();
                
    //            //////////////////
    //            string[] mass = new string[]{ "`Номер БД`", "`Тип проверки`", "`Дата проверки`", "`Канал Cs`", "`Канал Св`", "`Пороги`", "`S Cs 10 см`",
    //                "`S Cs 50 см`", "`S U 50 см`", "`S Pu/Cf 50 см`", "`Нестабильность фона`", "`Колличество срабатываний`", "`Q`","`Ложные срабатывания`",
    //                "`Примечание`", "`s_ColLineage`","`s_Generation`", "`s_GUID`", "`s_Lineage`"};
    //            ///////////////////////
    //            try
    //            {
    //                int kolvo_strok = 0;
    //                bool validvalue = false;
    //                foreach (DataRow row_ in table.Rows)
    //                {
    //                    var array1 = row_.ItemArray;
    //                    ///
    //                    string text = "SELECT * FROM `Проверка` WHERE ";
    //                    for (int arr = 4; arr < array1.Length; arr++)
    //                    {
    //                        if (array1[arr] != DBNull.Value)
    //                        {
    //                            text = text + mass[arr - 1] + "= ? AND ";
    //                        }
    //                    }
    //                    char[] Mychar = { 'A', 'N', 'D', ' ' };
    //                    text = text.TrimEnd(Mychar);

    //                    var command_sv = new OleDbCommand();
    //                    command_sv.Connection = conn_tabl;

    //                    command_sv.CommandText = text;

    //                    for (int arr = 4; arr < array1.Length; arr++)
    //                    {
    //                        if (array1[arr] != DBNull.Value)
    //                        {
    //                            command_sv.Parameters.AddWithValue("?", array1[arr]);
    //                        }
    //                    }

    //                    using (OleDbDataReader data = command_sv.ExecuteReader())
    //                    {
    //                        validvalue = data.Read();
    //                    }
    //                    command_sv.Parameters.Clear();
    //                }
    //                var array1_ = table.Rows[0].ItemArray;
    //                string[] blocks = new string[16];
    //                DataTable dt = new DataTable();
    //                bool vnesti = false;
    //                string way_ = "";
    //                if (!validvalue)
    //                {
    //                    ///////////////////
    //                    if (array1_[15].ToString() != "")
    //                    {
    //                        string pp = array1_[15].ToString();
    //                        int value;
    //                        int.TryParse(string.Join("", pp.Where(c => char.IsDigit(c))), out value);

    //                        var command3_sv = new OleDbCommand();
    //                        command3_sv.Connection = conn_tabl;

    //                        command3_sv.CommandText = "SELECT `Блок1`, `Блок2`,`Блок3`,`Блок4`,`Блок5`,`Блок6`," +
    //                            "`Блок7`,`Блок8` FROM `Системы в сборе` WHERE `Номер системы` = ?";
    //                        command3_sv.Parameters.AddWithValue("?", value);

    //                        OleDbDataReader reader = command3_sv.ExecuteReader();
    //                        while (reader.Read())
    //                        {
    //                            for (int i = 0; i < 8; i++)
    //                            {
    //                                blocks[i] = reader[i].ToString();
    //                            }
    //                        }

    //                        command3_sv.Parameters.Clear();
                            
    //                        if (array1_[1].ToString() == "?дополнить")
    //                        {
    //                            List<string> Sbor_system = Directory.GetFiles(Form_System.System_ways, "*.txt").ToList<string>();
    //                            foreach (var sbor_S in Sbor_system)
    //                            {
    //                                string file_ = Path.GetFileName(sbor_S);
    //                                string numbersystem = value.ToString() + ".txt";
    //                                if (file_ == numbersystem)
    //                                {
    //                                    vnesti = true;
    //                                    way_ = Form_System.System_ways + "\\" + numbersystem;
    //                                    try
    //                                    {
    //                                        Stream fs = new FileStream(way_, FileMode.Open, FileAccess.Read);
    //                                        StreamReader sr = new StreamReader(fs);
                                            
    //                                        dt.Columns.Add("Номер системы");
    //                                        dt.Columns.Add("Тип системы");
    //                                        dt.Columns.Add("Тип БД");
    //                                        string s = sr.ReadLine();
    //                                        string[] parts = s.Split(',');
    //                                        for (int i = 1; i < parts.Length - 2; i++)
    //                                        {
    //                                            dt.Columns.Add("Блок_" + i);
    //                                        }
    //                                        DataRow row = dt.NewRow();
    //                                        for (int i = 0; i < parts.Length; i++)
    //                                            row[i] = parts[i];
    //                                        dt.Rows.Add(row);

    //                                        for (int i = 3; i < parts.Length; i++)
    //                                            blocks[i - 3] = parts[i];

    //                                        while (sr.Peek() != -1)
    //                                        {
    //                                            s = sr.ReadLine();
    //                                            parts = s.Split(',');
    //                                            DataRow row1 = dt.NewRow();
    //                                            for (int i = 0; i < parts.Length; i++)
    //                                                row1[i] = parts[i];
    //                                            dt.Rows.Add(row1);
    //                                            for (int i = 3; i < parts.Length; i++)
    //                                                blocks[i - 3] = parts[i];
    //                                        }
    //                                        sr.Close();
    //                                        fs.Close();
    //                                    }
    //                                    catch (Exception p)
    //                                    { MessageBox.Show(p.ToString()); }
    //                                }
    //                            }

    //                        }
    //                    }
    //                }
    //                    /////
    //                foreach (DataRow row_ in table.Rows)
    //                {
    //                    var array1 = row_.ItemArray;
    //                    if (array1_[1].ToString() == "?дополнить")
    //                    {
    //                        if (blocks[kolvo_strok] == null)
    //                        { }
    //                        else
    //                            array1[1] = blocks[kolvo_strok];
    //                    }

    //                        if (!validvalue)
    //                        {
    //                            OleDbCommand cmd = new OleDbCommand();
    //                            cmd.CommandType = CommandType.Text;
    //                            cmd.CommandText = "INSERT INTO `Проверка` (`Номер БД`, `Тип проверки`, `Дата проверки`, " +
    //                            "`Канал Cs`, `Канал Св`, `Пороги`, `S Cs 10 см`, `S Cs 50 см`, `S U 50 см`," +
    //                            " `S Pu/Cf 50 см`, `Нестабильность фона`, `Колличество срабатываний`, `Q`," +
    //                            " `Ложные срабатывания`, `Примечание`, `s_ColLineage`," +
    //                            " `s_Generation`, `s_GUID`, `s_Lineage`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

    //                            cmd.Parameters.AddWithValue("@NumberB", array1[1]);
    //                            cmd.Parameters.AddWithValue("@Type", array1[2]);
    //                            cmd.Parameters.AddWithValue("@Data", array1[3]);
    //                            cmd.Parameters.AddWithValue("@Cs", array1[4]);
    //                            cmd.Parameters.AddWithValue("@Cv", array1[5]);
    //                            cmd.Parameters.AddWithValue("@Porog", array1[6]);
    //                            cmd.Parameters.AddWithValue("@S_Cs", array1[7]);
    //                            cmd.Parameters.AddWithValue("@S_Cs_5", array1[8]);
    //                            cmd.Parameters.AddWithValue("@S_U", array1[9]);
    //                            cmd.Parameters.AddWithValue("@S_Pu", array1[10]);
    //                            cmd.Parameters.AddWithValue("@Fon", array1[11]);
    //                            cmd.Parameters.AddWithValue("@Kolvo", array1[12]);
    //                            cmd.Parameters.AddWithValue("@Q", array1[13]);
    //                            cmd.Parameters.AddWithValue("@L_srab", array1[14]);
    //                            cmd.Parameters.AddWithValue("@Prim", array1[15]);
    //                            cmd.Parameters.AddWithValue("@s_C", array1[16]);
    //                            cmd.Parameters.AddWithValue("@s_G", array1[17]);
    //                            cmd.Parameters.AddWithValue("@s_GUID", array1[18]);
    //                            cmd.Parameters.AddWithValue("@s_L", array1[19]);

    //                            cmd.Connection = conn_tabl;
    //                            cmd.ExecuteNonQuery();
    //                        }
    //                    kolvo_strok++;
    //                }
    //                ////////////////////////
    //                ///внести из файла в таблицу системы в сборе
    //                ////////////////////////
    //                if (vnesti)
    //                {
    //                    try
    //                    {
    //                        var rows = dt.Rows;
    //                        var rows_ = Blocks.Rows;
    //                        try
    //                        {
    //                            Prov(rows, Blocks);
    //                        }
    //                        catch (Exception p1)
    //                        {
    //                            MessageBox.Show(p1.ToString());
    //                            return;
    //                        }
    //                        int length = 2;
    //                        foreach (DataRow row_ in rows)
    //                        {
    //                            length = row_.ItemArray.Length;
    //                            for (int i = row_.ItemArray.Length; i > 2; i--)
    //                            {
    //                                if (row_[i - 1] == null || row_[i - 1].ToString() == "")
    //                                {
    //                                    length = length - 1;
    //                                }
    //                                else
    //                                    break;
    //                            }
    //                            var row_new = Sys_sb.NewRow();
    //                            var row_new1 = Sys_sb.NewRow();
    //                            row_new["Номер системы"] = row_.ItemArray[0];
    //                            row_new["Тип системы"] = row_.ItemArray[1];
    //                            row_new["Дата проверки"] = curDate;

    //                            if (length > 19)
    //                            {
    //                                return;
    //                            }
    //                            if (length > 11)
    //                            {
    //                                row_new1["Номер системы"] = row_.ItemArray[0] + "(н)";
    //                                row_new1["Тип системы"] = row_.ItemArray[1];
    //                                row_new1["Дата проверки"] = curDate;
    //                                for (int i = 1; i < 9; i++)
    //                                {
    //                                    row_new["Блок" + i] = row_.ItemArray[i + 2];
                                        
    //                                }
    //                                int g = 1;
    //                                for (int i = 9; i < length - 2; i++)
    //                                {
    //                                    row_new1["Блок" + g] = row_.ItemArray[i + 2];
    //                                    g++;
                                       
    //                                }
    //                            }
    //                            else
    //                            {
    //                                for (int i = 1; i < length - 2; i++)
    //                                {
    //                                    row_new["Блок" + i] = row_.ItemArray[i + 2];
                                        
    //                                }
    //                            }
                                

    //                            if (length > 11)
    //                            {  var array1_1 = row_new1.ItemArray;
    //                                OleDbCommand cmd1 = new OleDbCommand();
    //                                cmd1.CommandType = CommandType.Text;
    //                                cmd1.CommandText = "INSERT INTO `Системы в сборе` (`Номер системы`, `Тип системы`, `Дата проверки`, " +
    //                                "`Местонахождение`, `Примечания`, `Блок1`, `Блок2`, `Блок3`, `Блок4`," +
    //                                " `Блок5`, `Блок6`, `Блок7`, `Блок8`, `Книга Протоколов`, `Страница в книге`, `s_ColLineage`," +
    //                                " `s_Generation`, `s_GUID`, `s_Lineage`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

    //                                cmd1.Parameters.AddWithValue("@NumberSys", array1_1[1]);
    //                                cmd1.Parameters.AddWithValue("@TypeSys", array1_1[2]);
    //                                cmd1.Parameters.AddWithValue("@Data", array1_1[3]);
    //                                cmd1.Parameters.AddWithValue("@Location", array1_1[4]);
    //                                cmd1.Parameters.AddWithValue("@Prim", array1_1[5]);
    //                                cmd1.Parameters.AddWithValue("@Block1", array1_1[6]);
    //                                cmd1.Parameters.AddWithValue("@Block2", array1_1[7]);
    //                                cmd1.Parameters.AddWithValue("@Block3", array1_1[8]);
    //                                cmd1.Parameters.AddWithValue("@Block4", array1_1[9]);
    //                                cmd1.Parameters.AddWithValue("@Block5", array1_1[10]);
    //                                cmd1.Parameters.AddWithValue("@Block6", array1_1[11]);
    //                                cmd1.Parameters.AddWithValue("@Block7", array1_1[12]);
    //                                cmd1.Parameters.AddWithValue("@Block8", array1_1[13]);
    //                                cmd1.Parameters.AddWithValue("@Book", array1_1[14]);
    //                                cmd1.Parameters.AddWithValue("@List", array1_1[15]);
    //                                cmd1.Parameters.AddWithValue("@s_C", array1_1[16]);
    //                                cmd1.Parameters.AddWithValue("@s_G", array1_1[17]);
    //                                cmd1.Parameters.AddWithValue("@s_GUID", array1_1[18]);
    //                                cmd1.Parameters.AddWithValue("@s_L", array1_1[19]);
                                    
    //                                cmd1.Connection = conn_tabl;
    //                                cmd1.ExecuteNonQuery();
    //                            }
    //                            var array1 = row_new.ItemArray;
    //                            OleDbCommand cmd = new OleDbCommand();
    //                                cmd.CommandType = CommandType.Text;
    //                                cmd.CommandText = "INSERT INTO `Системы в сборе` (`Номер системы`, `Тип системы`, `Дата проверки`, " +
    //                                "`Местонахождение`, `Примечания`, `Блок1`, `Блок2`, `Блок3`, `Блок4`," +
    //                                " `Блок5`, `Блок6`, `Блок7`, `Блок8`, `Книга Протоколов`, `Страница в книге`, `s_ColLineage`," +
    //                                " `s_Generation`, `s_GUID`, `s_Lineage`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

    //                                cmd.Parameters.AddWithValue("@NumberSys", array1[1]);
    //                                cmd.Parameters.AddWithValue("@TypeSys", array1[2]);
    //                                cmd.Parameters.AddWithValue("@Data", array1[3]);
    //                                cmd.Parameters.AddWithValue("@Location", array1[4]);
    //                                cmd.Parameters.AddWithValue("@Prim", array1[5]);
    //                                cmd.Parameters.AddWithValue("@Block1", array1[6]);
    //                                cmd.Parameters.AddWithValue("@Block2", array1[7]);
    //                                cmd.Parameters.AddWithValue("@Block3", array1[8]);
    //                                cmd.Parameters.AddWithValue("@Block4", array1[9]);
    //                                cmd.Parameters.AddWithValue("@Block5", array1[10]);
    //                                cmd.Parameters.AddWithValue("@Block6", array1[11]);
    //                                cmd.Parameters.AddWithValue("@Block7", array1[12]);
    //                                cmd.Parameters.AddWithValue("@Block8", array1[13]);
    //                                cmd.Parameters.AddWithValue("@Book", array1[14]);
    //                                cmd.Parameters.AddWithValue("@List", array1[15]);
    //                                cmd.Parameters.AddWithValue("@s_C", array1[16]);
    //                                cmd.Parameters.AddWithValue("@s_G", array1[17]);
    //                                cmd.Parameters.AddWithValue("@s_GUID", array1[18]);
    //                                cmd.Parameters.AddWithValue("@s_L", array1[19]);

    //                                cmd.Connection = conn_tabl;
    //                                cmd.ExecuteNonQuery();

    //                        }
    //                        char[] Mychar = { '.','t','x', ' ' };
    //                        string wayyy = way_.TrimEnd(Mychar);
    //                        wayyy = wayyy + "(внесено).txt";
    //                        File.Move(way_, wayyy); 
    //                    }
    //                    catch (Exception o)
    //                    {
    //                        MessageBox.Show(o.ToString());
    //                    }

    //                    ////////////////
    //                }
    //                conn_tabl.Close();
    //            }
    //            catch (Exception p)
    //            { MessageBox.Show(p.ToString()); }
    //            int w = 1,q=2;
    //            try
    //            {
    //                string file = Path.GetFileName(fil);
    //                string newPath = Path.Combine(Form1.Proverka_ways_perem, file);
    //                File.Move(fil, newPath);
    //            }
    //            catch(IOException)
    //            {
    //                do
    //                {
    //                    try
    //                    {
    //                        string file = Path.GetFileNameWithoutExtension(fil)+"-" + w+".txt";
    //                        string newPath = Path.Combine(Form1.Proverka_ways_perem, file);
    //                        File.Move(fil, newPath);
    //                        q = 3;
    //                    }
    //                    catch (Exception)
    //                    { w++; }
    //                } while (q==2);
    //            }
    //        }
    //    }
    //    public void Prov(DataRowCollection rows, DataTable table)
    //    {
    //        try
    //        {
    //            var rows_ = table.Rows;

    //            int k = 0;
    //            int k1 = 0;
    //            int length = 2;
    //            int t2; 
    //            int t3;
    //            t3 = table.Columns["Примечания"].Ordinal;
    //            t2 = table.Columns["Отметка выполнения"].Ordinal;
    //            foreach (DataRow row_ in rows)
    //            {
    //                length = row_.ItemArray.Length;
    //                for (int i = row_.ItemArray.Length; i > 2; i--)
    //                {
    //                    if (row_[i - 1] == null || row_[i - 1].ToString() == "")
    //                    {
    //                        length = length - 1;
    //                    }
    //                    else
    //                        break;
    //                }
    //                if (length > 19)
    //                {
    //                    MessageBox.Show("Строка превышает лимит в 16 блоков!");
    //                    return;
    //                }

    //                for (int i = 3; i < length; i++)
    //                {
    //                    foreach (DataRow r in rows_)
    //                    {
    //                            if (r.ItemArray[0].ToString() == row_.ItemArray[i].ToString())
    //                            {
    //                                k++;
    //                                k1 = length;

    //                            OleDbConnection dbCon = new OleDbConnection(Form1.conString);
    //                            dbCon.Open();
    //                            var array1 = r.ItemArray;

    //                            if(array1[t2].ToString().Contains(".сохранено в файле"))
    //                            {
    //                                char[] Mychar = { 'с', 'о', 'х', 'р', 'а', 'н', 'е', 'в', 'ф', 'й', 'л', ' ' };
    //                                string str = array1[t2].ToString();
    //                                str= str.TrimEnd(Mychar);
    //                                r[t2] = str;
    //                            }
    //                            var ttt = r[t2].ToString();
    //                            string rr;
    //                            rr = r[t3].ToString();
    //                            rr = "Выпущен в составе системы " + row_.ItemArray[0];
    //                            r[t3] = rr;
    //                            rr = "";
    //                            char ch = ttt.Contains("Г") ? 'a' :
    //                                ttt.Contains("г") ? 'b' :
    //                                'c';
    //                            switch (ch)
    //                            {
    //                                case 'a':
    //                                    rr = r[t2].ToString();
    //                                    rr = rr.Replace("Г", "в");
    //                                    r[t2] = rr;
    //                                    break;
    //                                case 'b':
    //                                    rr = r[t2].ToString();
    //                                    rr = rr.Replace("г", "в");
    //                                    r[t2] = rr;
    //                                    break;
    //                                case 'c':
    //                                    rr = r[t2].ToString();
    //                                    rr = rr + "в";
    //                                    r[t2] = rr;
    //                                    break;
    //                            }
    //                            array1 = r.ItemArray;
    //                            OleDbCommand cmd = new OleDbCommand();
    //                            cmd.CommandType = CommandType.Text;
    //                            cmd.CommandText = "UPDATE `Блоки` SET `Номер БД` = ?, `Тип БД` = ?, `Номер ФЭУ` = ?," +
    //                    " `Номинальное U` = ?, `Примечания` = ?, `Местоположение` = ?, `Отметка выполнения` = ?, " +
    //                    "`КАН` = ?, `s_ColLineage` = ?, `s_Generation` = ?, `s_GUID` = ?, `s_Lineage` = ? " +
    //                    "WHERE `Номер БД` = ?";
    //                            cmd.Parameters.AddWithValue("@NumberBD", array1[0]);
    //                            cmd.Parameters.AddWithValue("@TypeBD", array1[1]);
    //                            cmd.Parameters.AddWithValue("@FEY", array1[2]);
    //                            cmd.Parameters.AddWithValue("@Nomin", array1[3]);
    //                            cmd.Parameters.AddWithValue("@Prim", array1[4]);
    //                            cmd.Parameters.AddWithValue("@Location", array1[5]);
    //                            cmd.Parameters.AddWithValue("@Otmetca", array1[6]);
    //                            cmd.Parameters.AddWithValue("@KAN", array1[7]);
    //                            cmd.Parameters.AddWithValue("@s_C", array1[8]);
    //                            cmd.Parameters.AddWithValue("@s_G", array1[9]);
    //                            cmd.Parameters.AddWithValue("@s_GUID", array1[10]);
    //                            cmd.Parameters.AddWithValue("@s_L", array1[11]);
    //                            cmd.Parameters.AddWithValue("@ID", array1[0]);
                                
    //                            cmd.Connection = dbCon;
    //                                cmd.ExecuteNonQuery();
                                
    //                            }
    //                    } 
    //                }

    //            }
    //            if (k < k1 - 3)
    //            {
    //                MessageBox.Show("Не все блоки существуют!");
    //                return;
    //            }
                
    //        }
    //        catch (Exception p)
    //        { MessageBox.Show( p.ToString()); }

    //    }
    //}
    #endregion
    class Proverka
    {
        public static int k = 0;

        public static string[] parts;
        public double b { get; private set; }
        public static bool Logn = false;


        public void Main_Proverka(Form1 form1, DataTable First, DataTable Blocks, DataTable Sys_sb)
        {
            List<Item_Proverka> items = new List<Item_Proverka>();
            List<string> Fil = Directory.GetFiles(Form1.Proverka_ways, "*.txt").ToList<string>();
            foreach (var fil in Fil)
            {
                k = 0;
                string[] allStringFromFile = File.ReadAllLines(fil, Encoding.Default);

                int len = allStringFromFile.Length;

                items.Clear();

                string name = Path.GetFileNameWithoutExtension(fil); // returns File
                int r = 16;
                parts = name.Split(new char[] { '_' });
                int rr = parts.Length;
                for (int i = 0; i < len; i++)
                {
                    if (k == 4)
                    {
                        Form1.Flags = false;
                        Form1.Flags_1 = false;
                        k = 0;
                    }
                    items.Add(new Item_Proverka(allStringFromFile[i], r));

                    if (Item_Proverka.b0 != 0 || k == 2)
                    {
                        if (k == 0)
                        {
                            Item_Proverka item_o = items.LastOrDefault();
                            if (rr != 1)
                                r = rr;
                            Form1.Flags = true;
                        }
                        k++;
                    }

                }
                DataTable table = new DataTable("Добавление_проверок");
                k = 4;
                table = First.Clone();
                table.BeginLoadData();

                float[] bbb = new float[16];
                float[] chuvstvit = new float[16];

                string curDate = DateTime.Now.ToShortDateString();
                #region mmm
                foreach (Item_Proverka item_ in items)
                {
                    if (item_.b != 0)
                    {
                        switch (k)
                        {
                            case 4:
                                bbb[0] = item_.b;
                                bbb[1] = item_.b1;
                                bbb[2] = item_.b2;
                                bbb[3] = item_.b3;
                                bbb[4] = item_.b4;
                                bbb[5] = item_.b5;
                                bbb[6] = item_.b6;
                                bbb[7] = item_.b7;
                                //////
                                bbb[8] = item_.b8;
                                bbb[9] = item_.b9;
                                bbb[10] = item_.b10;
                                bbb[11] = item_.b11;
                                bbb[12] = item_.b12;
                                bbb[13] = item_.b13;
                                bbb[14] = item_.b14;
                                bbb[15] = item_.b15;
                                break;
                            case 5:
                                if (item_.b > bbb[0]) { bbb[0] = item_.b; }
                                if (item_.b1 > bbb[1]) { bbb[1] = item_.b1; }
                                if (item_.b2 > bbb[2]) { bbb[2] = item_.b2; }
                                if (item_.b3 > bbb[3]) { bbb[3] = item_.b3; }
                                if (item_.b4 > bbb[4]) { bbb[4] = item_.b4; }
                                if (item_.b5 > bbb[5]) { bbb[5] = item_.b5; }
                                if (item_.b6 > bbb[6]) { bbb[6] = item_.b6; }
                                if (item_.b7 > bbb[7]) { bbb[7] = item_.b7; }
                                ///
                                if (item_.b8 > bbb[8]) { bbb[8] = item_.b8; }
                                if (item_.b9 > bbb[9]) { bbb[9] = item_.b9; }
                                if (item_.b10 > bbb[10]) { bbb[10] = item_.b10; }
                                if (item_.b11 > bbb[11]) { bbb[11] = item_.b11; }
                                if (item_.b12 > bbb[12]) { bbb[12] = item_.b12; }
                                if (item_.b13 > bbb[13]) { bbb[13] = item_.b13; }
                                if (item_.b14 > bbb[14]) { bbb[14] = item_.b14; }
                                if (item_.b15 > bbb[15]) { bbb[15] = item_.b15; }
                                break;
                            case 6:
                                chuvstvit[0] = item_.b;
                                chuvstvit[1] = item_.b1;
                                chuvstvit[2] = item_.b2;
                                chuvstvit[3] = item_.b3;
                                chuvstvit[4] = item_.b4;
                                chuvstvit[5] = item_.b5;
                                chuvstvit[6] = item_.b6;
                                chuvstvit[7] = item_.b7;
                                ///
                                chuvstvit[8] = item_.b8;
                                chuvstvit[9] = item_.b9;
                                chuvstvit[10] = item_.b10;
                                chuvstvit[11] = item_.b11;
                                chuvstvit[12] = item_.b12;
                                chuvstvit[13] = item_.b13;
                                chuvstvit[14] = item_.b14;
                                chuvstvit[15] = item_.b15;

                                if (rr != 1)
                                {
                                    for (int j = 0; j < r; j++)
                                    {
                                        if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                        {
                                            DataRow mynewrow = table.NewRow();
                                            mynewrow["Номер БД"] = parts[j];
                                            mynewrow["Пороги"] = bbb[j];
                                            mynewrow["S Cs 10 см"] = chuvstvit[j];
                                            mynewrow["Дата проверки"] = curDate;
                                            table.Rows.Add(mynewrow);
                                        }
                                        else
                                        {
                                            table.Rows[j]["Пороги"] = bbb[j];
                                            table.Rows[j]["S Cs 10 см"] = chuvstvit[j];
                                        }
                                    }
                                }
                                else
                                {
                                    if (r == 1)
                                    {
                                        for (int j = 0; j < r; j++)
                                        {
                                            if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                            {
                                                DataRow mynewrow = table.NewRow();
                                                mynewrow["Номер БД"] = name;
                                                mynewrow["Пороги"] = bbb[j];
                                                mynewrow["S Cs 10 см"] = chuvstvit[j];
                                                mynewrow["Дата проверки"] = curDate;
                                                table.Rows.Add(mynewrow);
                                            }
                                            else
                                            {
                                                table.Rows[j]["Пороги"] = bbb[j];
                                                table.Rows[j]["S Cs 10 см"] = chuvstvit[j];
                                            }
                                        }
                                    }
                                    else
                                    {
                                        for (int j = 0; j < r; j++)
                                        {
                                            if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                            {
                                                DataRow mynewrow = table.NewRow();
                                                mynewrow["Номер БД"] = "?дополнить";
                                                mynewrow["Пороги"] = bbb[j];
                                                mynewrow["S Cs 10 см"] = chuvstvit[j];
                                                mynewrow["Дата проверки"] = curDate;
                                                mynewrow["Примечание"] = "В системе " + name;
                                                table.Rows.Add(mynewrow);
                                            }
                                            else
                                            {
                                                table.Rows[j]["Пороги"] = bbb[j];
                                                table.Rows[j]["S Cs 10 см"] = chuvstvit[j];
                                            }
                                        }
                                    }
                                }
                                k = 3;
                                break;
                            default:
                                break;
                        }
                        k++;
                    }
                }

                items.Clear();
                #endregion
                List<Item_Prov_Obnarug> itemr = new List<Item_Prov_Obnarug>();
                itemr.Clear();
                Form1.Flags = false;
                k = 0;

                for (int i = 0; i < len; i++)
                {
                    itemr.Add(new Item_Prov_Obnarug(allStringFromFile[i], r));
                    
                    Item_Prov_Obnarug item_ = itemr.LastOrDefault();
                    if (item_.b1 != 0)
                    {
                        if (k == 1 || k % 2 != 0)
                        {
                            chuvstvit[0] = item_.b;
                            chuvstvit[1] = item_.b1;
                            chuvstvit[2] = item_.b2;
                            chuvstvit[3] = item_.b3;
                            chuvstvit[4] = item_.b4;
                            chuvstvit[5] = item_.b5;
                            chuvstvit[6] = item_.b6;
                            chuvstvit[7] = item_.b7;
                            ///
                            chuvstvit[8] = item_.b8;
                            chuvstvit[9] = item_.b9;
                            chuvstvit[10] = item_.b10;
                            chuvstvit[11] = item_.b11;
                            chuvstvit[12] = item_.b12;
                            chuvstvit[13] = item_.b13;
                            chuvstvit[14] = item_.b14;
                            chuvstvit[15] = item_.b15;
                            if (rr != 1)
                            {
                                if (parts.Length < r)
                                {
                                    r = parts.Length;
                                }
                                for (int j = 0; j < r; j++)
                                {
                                    if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                    {
                                        DataRow mynewrow = table.NewRow();
                                        mynewrow["Номер БД"] = parts[j];
                                        mynewrow["Q"] = bbb[j];
                                        mynewrow["Колличество срабатываний"] = chuvstvit[j];
                                        mynewrow["Дата проверки"] = curDate;
                                        table.Rows.Add(mynewrow);
                                    }
                                    else
                                    {
                                        table.Rows[j]["Q"] = bbb[j];
                                        table.Rows[j]["Колличество срабатываний"] = chuvstvit[j];
                                    }
                                }
                            }
                            else
                            {
                                if (r == 1)
                                {
                                    for (int j = 0; j < r; j++)
                                    {
                                        if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                        {
                                            DataRow mynewrow = table.NewRow();
                                            mynewrow["Номер БД"] = name;
                                            mynewrow["Q"] = bbb[j];
                                            mynewrow["Колличество срабатываний"] = chuvstvit[j];
                                            mynewrow["Дата проверки"] = curDate;
                                            table.Rows.Add(mynewrow);
                                        }
                                        else
                                        {
                                            table.Rows[j]["Q"] = bbb[j];
                                            table.Rows[j]["Колличество срабатываний"] = chuvstvit[j];
                                        }
                                    }
                                }
                                else
                                {
                                    for (int j = 0; j < r; j++)
                                    {
                                        if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                        {
                                            DataRow mynewrow = table.NewRow();
                                            mynewrow["Номер БД"] = "?дополнить";
                                            mynewrow["Q"] = bbb[j];
                                            mynewrow["Колличество срабатываний"] = chuvstvit[j];
                                            mynewrow["Дата проверки"] = curDate;
                                            mynewrow["Примечание"] = "В системе " + name;
                                            table.Rows.Add(mynewrow);
                                        }
                                        else
                                        {
                                            table.Rows[j]["Q"] = bbb[j];
                                            table.Rows[j]["Колличество срабатываний"] = chuvstvit[j];
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            bbb[0] = item_.b;
                            bbb[1] = item_.b1;
                            bbb[2] = item_.b2;
                            bbb[3] = item_.b3;
                            bbb[4] = item_.b4;
                            bbb[5] = item_.b5;
                            bbb[6] = item_.b6;
                            bbb[7] = item_.b7;
                            //////
                            bbb[8] = item_.b8;
                            bbb[9] = item_.b9;
                            bbb[10] = item_.b10;
                            bbb[11] = item_.b11;
                            bbb[12] = item_.b12;
                            bbb[13] = item_.b13;
                            bbb[14] = item_.b14;
                            bbb[15] = item_.b15;
                        }
                        k++;
                        try
                        {
                            //// придумать как добавить break
                            if (Item_Prov_Obnarug.istochnik.Contains("нестабильность") && item_.b != 0 && (item_.b == Item_Prov_Obnarug.b0))
                            {
                                Item_Prov_Obnarug.istochnik = "k";
                                //break;
                            }
                        }
                        catch (Exception p)
                        { }
                    }
                }

                itemr.Clear();
                ////////////////////////////////////////
                bool cf_ = false;
                List<Item_Prov_Chuvstv> items_ = new List<Item_Prov_Chuvstv>();
                items_.Clear();

                Form1.Flags = false;
                Form1.Flags_ = false;
                double[,] vs = new double[16, 16];
                for (int vvv = 0; vvv < 16; vvv++)
                {
                    for (int vj = 0; vj < 16; vj++)
                        vs[vvv, vj] = 0;
                }
                for (int i = 0; i < len; i++)
                {
                    items_.Add(new Item_Prov_Chuvstv(allStringFromFile[i], r));
                    if (Item_Prov_Chuvstv.b0 != 0)
                    {
                        Item_Prov_Chuvstv item_o = items_.LastOrDefault();

                        if ( Item_Prov_Chuvstv.istochnik.Contains("cs") && item_o.b != 0 && (item_o.b == Item_Prov_Chuvstv.b0))
                        {
                            bbb[0] = item_o.b;
                            bbb[1] = item_o.b1;
                            bbb[2] = item_o.b2;
                            bbb[3] = item_o.b3;
                            bbb[4] = item_o.b4;
                            bbb[5] = item_o.b5;
                            bbb[6] = item_o.b6;
                            bbb[7] = item_o.b7;
                            //////
                            bbb[8] = item_o.b8;
                            bbb[9] = item_o.b9;
                            bbb[10] = item_o.b10;
                            bbb[11] = item_o.b11;
                            bbb[12] = item_o.b12;
                            bbb[13] = item_o.b13;
                            bbb[14] = item_o.b14;
                            bbb[15] = item_o.b15;
                            if (rr != 1)
                            {
                                if (parts.Length < r)
                                {
                                    r = parts.Length;
                                }
                                for (int j = 0; j < r; j++)
                                {
                                    if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                    {
                                        DataRow mynewrow = table.NewRow();
                                        mynewrow["Номер БД"] = parts[j];
                                        mynewrow["S Cs 50 см"] = bbb[j];
                                        mynewrow["Дата проверки"] = curDate;
                                        table.Rows.Add(mynewrow);
                                    }
                                    else
                                    {
                                        table.Rows[j]["S Cs 50 см"] = bbb[j];
                                    }
                                }
                                Form1.Flags_1 = false;
                                Form1.Flags_ = false;
                            }
                            else
                            {
                                if (r == 1)
                                {
                                    for (int j = 0; j < r; j++)
                                    {
                                        if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                        {
                                            DataRow mynewrow = table.NewRow();
                                            mynewrow["Номер БД"] = name;
                                            mynewrow["S Cs 50 см"] = bbb[j];
                                            mynewrow["Дата проверки"] = curDate;
                                            table.Rows.Add(mynewrow);
                                        }
                                        else
                                        {
                                            table.Rows[j]["S Cs 50 см"] = bbb[j];
                                        }
                                    }
                                }
                                else
                                {
                                    for (int j = 0; j < r; j++)
                                    {
                                        if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                        {
                                            DataRow mynewrow = table.NewRow();
                                            mynewrow["Номер БД"] = "?дополнить";
                                            mynewrow["S Cs 50 см"] = bbb[j];
                                            mynewrow["Дата проверки"] = curDate;
                                            mynewrow["Примечание"] = "В системе " + name;
                                            table.Rows.Add(mynewrow);
                                        }
                                        else
                                        {
                                            table.Rows[j]["S Cs 50 см"] = bbb[j];
                                        }
                                    }
                                }
                                Form1.Flags_1 = false;
                                Form1.Flags_ = false;
                            }
                        }
                        if ( !Item_Prov_Chuvstv.istochnik.Contains("pu")  && Item_Prov_Chuvstv.istochnik.Contains("u") && item_o.b != 0 && (item_o.b == Item_Prov_Chuvstv.b0))
                        {
                            bbb[0] = item_o.b;
                            bbb[1] = item_o.b1;
                            bbb[2] = item_o.b2;
                            bbb[3] = item_o.b3;
                            bbb[4] = item_o.b4;
                            bbb[5] = item_o.b5;
                            bbb[6] = item_o.b6;
                            bbb[7] = item_o.b7;
                            //////
                            bbb[8] = item_o.b8;
                            bbb[9] = item_o.b9;
                            bbb[10] = item_o.b10;
                            bbb[11] = item_o.b11;
                            bbb[12] = item_o.b12;
                            bbb[13] = item_o.b13;
                            bbb[14] = item_o.b14;
                            bbb[15] = item_o.b15;
                            if (rr != 1)
                            {
                                for (int j = 0; j < r; j++)
                                {
                                    if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                    {
                                        DataRow mynewrow = table.NewRow();
                                        mynewrow["Номер БД"] = parts[j];
                                        mynewrow["S U 50 см"] = bbb[j];
                                        mynewrow["Дата проверки"] = curDate;
                                        table.Rows.Add(mynewrow);
                                    }
                                    else
                                    {
                                        table.Rows[j]["S U 50 см"] = bbb[j];
                                    }

                                }
                                Form1.Flags_1 = false;
                                Form1.Flags_ = false;
                            }
                            else
                            {
                                if (r == 1)
                                {
                                    for (int j = 0; j < r; j++)
                                    {
                                        if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                        {
                                            DataRow mynewrow = table.NewRow();
                                            mynewrow["Номер БД"] = name;
                                            mynewrow["S U 50 см"] = bbb[j];
                                            mynewrow["Дата проверки"] = curDate;
                                            table.Rows.Add(mynewrow);
                                        }
                                        else
                                        {
                                            table.Rows[j]["S U 50 см"] = bbb[j];
                                        }
                                    }
                                }
                                else
                                {
                                    for (int j = 0; j < r; j++)
                                    {
                                        if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                        {
                                            DataRow mynewrow = table.NewRow();
                                            mynewrow["Номер БД"] = "?дополнить";
                                            mynewrow["S U 50 см"] = bbb[j];
                                            mynewrow["Дата проверки"] = curDate;
                                            mynewrow["Примечание"] = "В системе " + name;
                                            table.Rows.Add(mynewrow);
                                        }
                                        else
                                        {
                                            table.Rows[j]["S U 50 см"] = bbb[j];
                                        }
                                    }
                                }
                                Form1.Flags_1 = false;
                                Form1.Flags_ = false;
                            }
                        }
                        if ((Item_Prov_Chuvstv.istochnik.Contains("cm") || 
                             Item_Prov_Chuvstv.istochnik.Contains("cf") ||
                             Item_Prov_Chuvstv.istochnik.Contains("pu")) 
                             && item_o.b != 0 && (item_o.b == Item_Prov_Chuvstv.b0))
                        {
                            if ( Item_Prov_Chuvstv.istochnik.Contains("cm") || Item_Prov_Chuvstv.istochnik.Contains("cf"))
                            {
                                cf_ = true;

                                int vv = 0;
                                for (int vj = 0; vj < 16; vj++)
                                {
                                    if (vs[vv, vj] == 0)
                                    {
                                        switch (vj)
                                        {
                                            case 0:
                                                vs[vv, vj] = item_o.b;
                                                break;
                                            case 1:
                                                vs[vv, vj] = item_o.b1;
                                                break;
                                            case 2:
                                                vs[vv, vj] = item_o.b2;
                                                break;
                                            case 3:
                                                vs[vv, vj] = item_o.b3;
                                                break;
                                            case 4:
                                                vs[vv, vj] = item_o.b4;
                                                break;
                                            case 5:
                                                vs[vv, vj] = item_o.b5;
                                                break;
                                            case 6:
                                                vs[vv, vj] = item_o.b6;
                                                break;
                                            case 7:
                                                vs[vv, vj] = item_o.b7;
                                                break;
                                            case 8:
                                                vs[vv, vj] = item_o.b8;
                                                break;
                                            case 9:
                                                vs[vv, vj] = item_o.b9;
                                                break;
                                            case 10:
                                                vs[vv, vj] = item_o.b10;
                                                break;
                                            case 11:
                                                vs[vv, vj] = item_o.b11;
                                                break;
                                            case 12:
                                                vs[vv, vj] = item_o.b12;
                                                break;
                                            case 13:
                                                vs[vv, vj] = item_o.b13;
                                                break;
                                            case 14:
                                                vs[vv, vj] = item_o.b14;
                                                break;
                                            case 15:
                                                vs[vv, vj] = item_o.b15;
                                                break;
                                        }
                                    }
                                    else { vv++; vj--; }
                                }
                                Form1.Flags_1 = false;
                                Form1.Flags_ = false;
                            }
                            else
                            {
                                bbb[0] = item_o.b;
                                bbb[1] = item_o.b1;
                                bbb[2] = item_o.b2;
                                bbb[3] = item_o.b3;
                                bbb[4] = item_o.b4;
                                bbb[5] = item_o.b5;
                                bbb[6] = item_o.b6;
                                bbb[7] = item_o.b7;
                                //////
                                bbb[8] = item_o.b8;
                                bbb[9] = item_o.b9;
                                bbb[10] = item_o.b10;
                                bbb[11] = item_o.b11;
                                bbb[12] = item_o.b12;
                                bbb[13] = item_o.b13;
                                bbb[14] = item_o.b14;
                                bbb[15] = item_o.b15;
                                if (rr != 1)
                                {
                                    for (int j = 0; j < r; j++)
                                    {
                                        if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                        {
                                            DataRow mynewrow = table.NewRow();
                                            mynewrow["Номер БД"] = parts[j];
                                            mynewrow["S Pu/Cf 50 см"] = bbb[j];
                                            mynewrow["Дата проверки"] = curDate;
                                            table.Rows.Add(mynewrow);
                                        }
                                        else
                                        {
                                            table.Rows[j]["S Pu/Cf 50 см"] = bbb[j];
                                        }

                                    }
                                    Form1.Flags_1 = false;
                                    Form1.Flags_ = false;
                                }
                                else
                                {
                                    if (r == 1)
                                    {
                                        for (int j = 0; j < r; j++)
                                        {
                                            if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                            {
                                                DataRow mynewrow = table.NewRow();
                                                mynewrow["Номер БД"] = name;
                                                mynewrow["S Pu/Cf 50 см"] = bbb[j];
                                                mynewrow["Дата проверки"] = curDate;
                                                table.Rows.Add(mynewrow);
                                            }
                                            else
                                            {
                                                table.Rows[j]["S Pu/Cf 50 см"] = bbb[j];
                                            }
                                        }
                                    }
                                    else
                                    {
                                        for (int j = 0; j < r; j++)
                                        {
                                            if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                            {
                                                DataRow mynewrow = table.NewRow();
                                                mynewrow["Номер БД"] = "?дополнить";
                                                mynewrow["S Pu/Cf 50 см"] = bbb[j];
                                                mynewrow["Дата проверки"] = curDate;
                                                mynewrow["Примечание"] = "В системе " + name;
                                                table.Rows.Add(mynewrow);
                                            }
                                            else
                                            {
                                                table.Rows[j]["S Pu/Cf 50 см"] = bbb[j];
                                            }
                                        }
                                    }
                                    Form1.Flags_1 = false;
                                    Form1.Flags_ = false;
                                }
                            }
                        }

                        if (Item_Prov_Chuvstv.istochnik.Contains("нестабильность") && item_o.b != 0 && (item_o.b == Item_Prov_Chuvstv.b0))
                        {
                            bbb[0] = item_o.b;
                            bbb[1] = item_o.b1;
                            bbb[2] = item_o.b2;
                            bbb[3] = item_o.b3;
                            bbb[4] = item_o.b4;
                            bbb[5] = item_o.b5;
                            bbb[6] = item_o.b6;
                            bbb[7] = item_o.b7;
                            //////
                            bbb[8] = item_o.b8;
                            bbb[9] = item_o.b9;
                            bbb[10] = item_o.b10;
                            bbb[11] = item_o.b11;
                            bbb[12] = item_o.b12;
                            bbb[13] = item_o.b13;
                            bbb[14] = item_o.b14;
                            bbb[15] = item_o.b15;
                            if (rr != 1)
                            {
                                for (int j = 0; j < r; j++)
                                {
                                    if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == i)
                                    {
                                        DataRow mynewrow = table.NewRow();
                                        mynewrow["Номер БД"] = parts[j];
                                        mynewrow["Нестабильность фона"] = bbb[j];
                                        mynewrow["Дата проверки"] = curDate;
                                        table.Rows.Add(mynewrow);
                                    }
                                    else
                                    {
                                        table.Rows[j]["Нестабильность фона"] = bbb[j];
                                    }

                                }
                                Form1.Flags_1 = false;
                                Form1.Flags_ = false;
                            }
                            else
                            {
                                if (r == 1)
                                {
                                    for (int j = 0; j < r; j++)
                                    {
                                        if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                        {
                                            DataRow mynewrow = table.NewRow();
                                            mynewrow["Номер БД"] = name;
                                            mynewrow["Нестабильность фона"] = bbb[j];
                                            mynewrow["Дата проверки"] = curDate;
                                            table.Rows.Add(mynewrow);
                                        }
                                        else
                                        {
                                            table.Rows[j]["Нестабильность фона"] = bbb[j];
                                        }
                                    }
                                }
                                else
                                {
                                    for (int j = 0; j < r; j++)
                                    {
                                        if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                        {
                                            DataRow mynewrow = table.NewRow();
                                            mynewrow["Номер БД"] = "?дополнить";
                                            mynewrow["Нестабильность фона"] = bbb[j];
                                            mynewrow["Дата проверки"] = curDate;
                                            mynewrow["Примечание"] = "В системе " + name;
                                            table.Rows.Add(mynewrow);
                                        }
                                        else
                                        {
                                            table.Rows[j]["Нестабильность фона"] = bbb[j];
                                        }
                                    }
                                }
                                Form1.Flags_1 = false;
                                Form1.Flags_ = false;
                            }
                            //break;
                        }

                        Item_Prov_Chuvstv.b0 = 0;

                    }
                }
                if (cf_)
                {
                    for (int i = 0; i < 16; i++)
                    {
                        bbb[i] = 0;
                    }
                    for (int vj = 0; vj < 16; vj++)
                    {
                        for (int vv = 0; vv < 16; vv++)
                        {
                            if (vs[vv, vj] > bbb[vj])
                            {
                                bbb[vj] = (float)vs[vv, vj];
                            }

                        }
                    }
                    for (int i = 0; i < 16; i++)
                    {
                        if (bbb[i] == 0)
                        {break;}
                        else
                        {
                            bbb[i] = bbb[i] * 10000;
                        }
                    }
                    if (rr != 1)
                    {
                        for (int j = 0; j < r; j++)
                        {
                            if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                            {
                                DataRow mynewrow = table.NewRow();
                                mynewrow["Номер БД"] = parts[j];
                                mynewrow["S Pu/Cf 50 см"] = bbb[j];
                                mynewrow["Дата проверки"] = curDate;
                                table.Rows.Add(mynewrow);
                            }
                            else
                            {
                                table.Rows[j]["S Pu/Cf 50 см"] = bbb[j];
                            }

                        }
                        Form1.Flags_1 = false;
                        Form1.Flags_ = false;
                    }
                    else
                    {
                        if (r == 1)
                        {
                            for (int j = 0; j < r; j++)
                            {
                                if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                {
                                    DataRow mynewrow = table.NewRow();
                                    mynewrow["Номер БД"] = name;
                                    mynewrow["S Pu/Cf 50 см"] = bbb[j];
                                    mynewrow["Дата проверки"] = curDate;
                                    table.Rows.Add(mynewrow);
                                }
                                else
                                {
                                    table.Rows[j]["S Pu/Cf 50 см"] = bbb[j];
                                }
                            }
                        }
                        else
                        {
                            for (int j = 0; j < r; j++)
                            {
                                if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                {
                                    DataRow mynewrow = table.NewRow();
                                    mynewrow["Номер БД"] = "?дополнить";
                                    mynewrow["S Pu/Cf 50 см"] = bbb[j];
                                    mynewrow["Дата проверки"] = curDate;
                                    mynewrow["Примечание"] = "В системе " + name;
                                    table.Rows.Add(mynewrow);
                                }
                                else
                                {
                                    table.Rows[j]["S Pu/Cf 50 см"] = bbb[j];
                                }
                            }
                        }
                        Form1.Flags_1 = false;
                        Form1.Flags_ = false;
                    }
                }

                items_.Clear();
                ////////////////////////////////

                List<Item_Prov_LognS> item_s = new List<Item_Prov_LognS>();
                item_s.Clear();

                Form1.Flags = false;
                Form1.Flags_1 = false;

                for (int i = 0; i < len; i++)
                {
                    item_s.Add(new Item_Prov_LognS(allStringFromFile[i], r));

                    if (Item_Prov_LognS.b0 == 1022)
                    {
                        Item_Prov_LognS item_o = item_s.LastOrDefault();
                        bbb[0] = item_o.b;
                        bbb[1] = item_o.b1;
                        bbb[2] = item_o.b2;
                        bbb[3] = item_o.b3;
                        bbb[4] = item_o.b4;
                        bbb[5] = item_o.b5;
                        bbb[6] = item_o.b6;
                        bbb[7] = item_o.b7;
                        //////
                        bbb[8] = item_o.b8;
                        bbb[9] = item_o.b9;
                        bbb[10] = item_o.b10;
                        bbb[11] = item_o.b11;
                        bbb[12] = item_o.b12;
                        bbb[13] = item_o.b13;
                        bbb[14] = item_o.b14;
                        bbb[15] = item_o.b15;
                        Form1.Flags_1 = false;
                    }
                    Item_Prov_LognS.b0 = 0;
                    if (Logn == true)
                    {
                        if (rr != 1)
                        {
                            if (parts.Length < r)
                            {
                                r = parts.Length;
                            }
                            for (int j = 0; j < r; j++)
                            {
                                if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                {
                                    DataRow mynewrow = table.NewRow();
                                    mynewrow["Номер БД"] = parts[j];
                                    mynewrow["Ложные срабатывания"] = bbb[j];
                                    mynewrow["Дата проверки"] = curDate;
                                    table.Rows.Add(mynewrow);
                                }
                                else
                                {
                                    table.Rows[j]["Ложные срабатывания"] = bbb[j];
                                }

                            }
                            //break;
                        }
                        else
                        {
                            if (r == 1)
                            {
                                for (int j = 0; j < r; j++)
                                {
                                    if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                    {
                                        DataRow mynewrow = table.NewRow();
                                        mynewrow["Номер БД"] = name;
                                        mynewrow["Ложные срабатывания"] = bbb[j];
                                        mynewrow["Дата проверки"] = curDate;
                                        table.Rows.Add(mynewrow);
                                    }
                                    else
                                    {
                                        table.Rows[j]["Ложные срабатывания"] = bbb[j];
                                    }
                                }
                            }
                            else
                            {
                                for (int j = 0; j < r; j++)
                                {
                                    if (table.Rows.Count == 0 || table.Rows.Count < r && table.Rows.Count == j)
                                    {
                                        DataRow mynewrow = table.NewRow();
                                        mynewrow["Номер БД"] = "?дополнить";
                                        mynewrow["Ложные срабатывания"] = bbb[j];
                                        mynewrow["Дата проверки"] = curDate;
                                        mynewrow["Примечание"] = "В системе " + name;
                                        table.Rows.Add(mynewrow);
                                    }
                                    else
                                    {
                                        table.Rows[j]["Ложные срабатывания"] = bbb[j];
                                    }
                                }
                            }
                            //break;
                        }
                    }
                }
                ////////////////////////////////////////
                ///
                Form1.Flags = false;
                Form1.Flags_1 = false;
                var rows_to_delete = new List<DataRow>();
                try
                {
                    foreach (DataRow row in table.Rows)
                    {
                        string TableName = row["Ложные срабатывания"].ToString();
                        string TableName1 = row["Нестабильность фона"].ToString();
                        string TableName2 = row["S Pu/Cf 50 см"].ToString();
                        string TableName3 = row["S U 50 см"].ToString();
                        string TableName4 = row["S Cs 50 см"].ToString();
                        string TableName5 = row["Q"].ToString();
                        string TableName6 = row["Колличество срабатываний"].ToString();
                        string TableName7 = row["Пороги"].ToString();
                        string TableName8 = row["S Cs 10 см"].ToString();
                        if ((TableName == "" || TableName == "0" || TableName == null) && (TableName1 == "" || TableName1 == "0" || TableName1 == null) &&
                            (TableName2 == "" || TableName2 == "0" || TableName2 == null) && (TableName3 == "" || TableName3 == "0" || TableName3 == null) &&
                            (TableName4 == "" || TableName4 == "0" || TableName4 == null) && (TableName5 == "" || TableName5 == "0" || TableName5 == null) &&
                            (TableName6 == "" || TableName6 == "0" || TableName6 == null) && (TableName7 == "" || TableName7 == "0" || TableName7 == null) &&
                            (TableName8 == "" || TableName8 == "0" || TableName8 == null))
                        {
                            rows_to_delete.Add(row);
                        }
                    }
                    foreach (var r_ in rows_to_delete)
                    {
                        table.Rows.Remove(r_);
                    }
                    ///////////////////
                    ///Cf
                    ////////////////////
                    if (cf_)
                    {
                        double[] massCf = new double[16];
                        int i = 0;
                        foreach (DataRow row in table.Rows)
                        {
                            double TableName2 = Convert.ToDouble(row["S Pu/Cf 50 см"]);
                            if (TableName2 == 0)
                            { massCf[i] = 0; break; }
                            else massCf[i] = TableName2;
                            i++;
                        }
                        int koll = 0;
                        foreach (var cf in massCf)
                        {
                            if (cf != 0)
                                koll++;
                        }
                        for (int j = 0; j != koll; j++)
                        {
                            table.Rows[j]["S Pu/Cf 50 см"] = 0;
                        }
                        foreach (var cf in massCf)
                        {
                            if (koll == 0)
                            {
                                break;
                            }
                            for (int j = table.Rows.Count; j != 0; j--)
                            {
                                table.Rows[j - koll]["S Pu/Cf 50 см"] = cf;
                                koll--;
                                break;
                            }
                        }
                        //cf_ = false;
                    }
                    ///////////////////
                    rows_to_delete.Clear();

                    if (table.Rows.Count == 1)
                    {
                        foreach (DataRow row in table.Rows)
                        { if (row["Примечание"].ToString() != "")
                            {
                                string pp = row["Примечание"].ToString();
                                char[] Mychar = { 'В', 'с', 'и', ' ', 'т', 'е', 'м', 'в' };
                                pp = pp.TrimStart(Mychar);
                                //int value;
                                //int.TryParse(string.Join("", pp.Where(c => char.IsDigit(c))), out value);
                                row["Номер БД"] = pp;//value;
                                row["Примечание"] = "";
                            }
                        }

                    }
                }
                catch (Exception p)
                {
                    MessageBox.Show(p.ToString());
                }
                var conn_tabl = new OleDbConnection(Form1.conString);
                conn_tabl.Open();

                //////////////////
                string[] mass = new string[]{ "`Номер БД`", "`Тип проверки`", "`Дата проверки`", "`Канал Cs`", "`Канал Св`", "`Пороги`", "`S Cs 10 см`",
                    "`S Cs 50 см`", "`S U 50 см`", "`S Pu/Cf 50 см`", "`Нестабильность фона`", "`Колличество срабатываний`", "`Q`","`Ложные срабатывания`",
                    "`Примечание`", "`s_ColLineage`","`s_Generation`", "`s_GUID`", "`s_Lineage`"};
                ///////////////////////
                try
                {
                    int kolvo_strok = 0;
                    bool validvalue = false;
                    foreach (DataRow row_ in table.Rows)
                    {
                        var array1 = row_.ItemArray;
                        ///
                        string text = "SELECT * FROM `Проверка` WHERE ";
                        for (int arr = 4; arr < array1.Length; arr++)
                        {
                            if (array1[arr] != DBNull.Value)
                            {
                                text = text + mass[arr - 1] + "= ? AND ";
                            }
                        }
                        char[] Mychar = { 'A', 'N', 'D', ' ' };
                        text = text.TrimEnd(Mychar);

                        var command_sv = new OleDbCommand();
                        command_sv.Connection = conn_tabl;

                        command_sv.CommandText = text;

                        for (int arr = 4; arr < array1.Length; arr++)
                        {
                            if (array1[arr] != DBNull.Value)
                            {
                                command_sv.Parameters.AddWithValue("?", array1[arr]);
                            }
                        }

                        using (OleDbDataReader data = command_sv.ExecuteReader())
                        {
                            validvalue = data.Read();
                        }
                        command_sv.Parameters.Clear();
                    }
                    var array1_ = table.Rows[0].ItemArray;
                    string[] blocks = new string[16];
                    DataTable dt = new DataTable();
                    bool vnesti = false;
                    string way_ = "";
                    if (!validvalue)
                    {
                        ///////////////////
                        if (array1_[15].ToString() != "")
                        {
                            string pp = array1_[15].ToString();
                            //int value;
                            //int.TryParse(string.Join("", pp.Where(c => char.IsDigit(c))), out value);
                            char[] Mychar = { 'В', 'с', 'и', ' ', 'т', 'е', 'м', 'в' };
                            pp = pp.TrimStart(Mychar);
                            var command3_sv = new OleDbCommand();
                            command3_sv.Connection = conn_tabl;

                            command3_sv.CommandText = "SELECT `Блок1`, `Блок2`,`Блок3`,`Блок4`,`Блок5`,`Блок6`," +
                                "`Блок7`,`Блок8` FROM `Системы в сборе` WHERE `Номер системы` = ?";
                            command3_sv.Parameters.AddWithValue("?", /*value*/pp);

                            OleDbDataReader reader = command3_sv.ExecuteReader();
                            while (reader.Read())
                            {
                                for (int i = 0; i < 8; i++)
                                {
                                    blocks[i] = reader[i].ToString();
                                }
                            }
                            
                            command3_sv.Parameters.Clear();
                            
                            if (cf_)
                            {
                                string Value_1 = /*value*/pp.ToString() + "(н)";
                                var command9_sv = new OleDbCommand();
                                command9_sv.Connection = conn_tabl;

                                command9_sv.CommandText = "SELECT `Блок1`, `Блок2`,`Блок3`,`Блок4`,`Блок5`,`Блок6`," +
                                                          "`Блок7`,`Блок8` FROM `Системы в сборе` WHERE `Номер системы` = ?";
                                command9_sv.Parameters.AddWithValue("?", Value_1);
                                OleDbDataReader reader1 = command9_sv.ExecuteReader();
                                while (reader1.Read())
                                {
                                    int j = 0;
                                    for (int i = 8; i < 16; i++)
                                    {
                                        blocks[i] = reader1[j].ToString();
                                        j++;
                                    }
                                }
                                command9_sv.Parameters.Clear();

                                if (!reader1.Read())
                                {
                                    var command10_sv = new OleDbCommand();
                                    command10_sv.Connection = conn_tabl;
                                    Value_1 = pp.ToString() + " (н)";
                                    command10_sv.CommandText = "SELECT `Блок1`, `Блок2`,`Блок3`,`Блок4`,`Блок5`,`Блок6`," +
                                                              "`Блок7`,`Блок8` FROM `Системы в сборе` WHERE `Номер системы` = ?";
                                    command10_sv.Parameters.AddWithValue("?", Value_1);
                                    OleDbDataReader reader2 = command10_sv.ExecuteReader();
                                    while (reader2.Read())
                                    {
                                        int j = 0;
                                        for (int i = 8; i < 16; i++)
                                        {
                                            blocks[i] = reader2[j].ToString();
                                            j++;
                                        }
                                    }
                                    command10_sv.Parameters.Clear();
                                }
                                
                                cf_ = false;
                            }

                            if (array1_[1].ToString() == "?дополнить")
                            {
                                List<string> Sbor_system = Directory.GetFiles(Form_System.System_ways, "*.txt").ToList<string>();
                                foreach (var sbor_S in Sbor_system)
                                {
                                    string file_ = Path.GetFileName(sbor_S);
                                    string numbersystem = /*value*/pp.ToString() + ".txt";
                                    if (file_ == numbersystem)
                                    {
                                        vnesti = true;
                                        way_ = Form_System.System_ways + "\\" + numbersystem;
                                        try
                                        {
                                            Stream fs = new FileStream(way_, FileMode.Open, FileAccess.Read);
                                            StreamReader sr = new StreamReader(fs);

                                            dt.Columns.Add("Номер системы");
                                            dt.Columns.Add("Тип системы");
                                            dt.Columns.Add("Тип БД");
                                            string s = sr.ReadLine();
                                            string[] parts = s.Split(',');
                                            for (int i = 1; i < parts.Length - 2; i++)
                                            {
                                                dt.Columns.Add("Блок_" + i);
                                            }
                                            DataRow row = dt.NewRow();
                                            for (int i = 0; i < parts.Length; i++)
                                                row[i] = parts[i];
                                            dt.Rows.Add(row);

                                            for (int i = 3; i < parts.Length; i++)
                                                blocks[i - 3] = parts[i];

                                            while (sr.Peek() != -1)
                                            {
                                                s = sr.ReadLine();
                                                parts = s.Split(',');
                                                DataRow row1 = dt.NewRow();
                                                for (int i = 0; i < parts.Length; i++)
                                                    row1[i] = parts[i];
                                                dt.Rows.Add(row1);
                                                for (int i = 3; i < parts.Length; i++)
                                                    blocks[i - 3] = parts[i];
                                            }
                                            sr.Close();
                                            fs.Close();
                                        }
                                        catch (Exception p)
                                        { MessageBox.Show(p.ToString()); }
                                    }
                                }

                            }
                        }
                    }
                    /////
                    bool kol = true;
                    foreach (DataRow row_ in table.Rows)
                    {
                        var array1 = row_.ItemArray;
                        if (array1_[1].ToString() == "?дополнить")
                        {
                            if (blocks[kolvo_strok] == null)
                            { }
                            else
                            {
                                if (array1[10].ToString() == 0.ToString())
                                {
                                    array1[1] = blocks[kolvo_strok];
                                }
                                else
                                {
                                    if (kol)
                                    {
                                        if(blocks[8] == null)
                                        {}
                                        else
                                        {
                                            kolvo_strok = 8;
                                        }
                                        kol = false;
                                    }
                                    array1[1] = blocks[kolvo_strok];
                                }
                            }
                        }

                        if (!validvalue)
                        {
                            OleDbCommand cmd = new OleDbCommand();
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "INSERT INTO `Проверка` (`Номер БД`, `Тип проверки`, `Дата проверки`, " +
                            "`Канал Cs`, `Канал Св`, `Пороги`, `S Cs 10 см`, `S Cs 50 см`, `S U 50 см`," +
                            " `S Pu/Cf 50 см`, `Нестабильность фона`, `Колличество срабатываний`, `Q`," +
                            " `Ложные срабатывания`, `Примечание`, `s_ColLineage`," +
                            " `s_Generation`, `s_GUID`, `s_Lineage`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                            cmd.Parameters.AddWithValue("@NumberB", array1[1]);
                            cmd.Parameters.AddWithValue("@Type", array1[2]);
                            cmd.Parameters.AddWithValue("@Data", array1[3]);
                            cmd.Parameters.AddWithValue("@Cs", array1[4]);
                            cmd.Parameters.AddWithValue("@Cv", array1[5]);
                            cmd.Parameters.AddWithValue("@Porog", array1[6]);
                            cmd.Parameters.AddWithValue("@S_Cs", array1[7]);
                            cmd.Parameters.AddWithValue("@S_Cs_5", array1[8]);
                            cmd.Parameters.AddWithValue("@S_U", array1[9]);
                            cmd.Parameters.AddWithValue("@S_Pu", array1[10]);
                            cmd.Parameters.AddWithValue("@Fon", array1[11]);
                            cmd.Parameters.AddWithValue("@Kolvo", array1[12]);
                            cmd.Parameters.AddWithValue("@Q", array1[13]);
                            cmd.Parameters.AddWithValue("@L_srab", array1[14]);
                            cmd.Parameters.AddWithValue("@Prim", array1[15]);
                            cmd.Parameters.AddWithValue("@s_C", array1[16]);
                            cmd.Parameters.AddWithValue("@s_G", array1[17]);
                            cmd.Parameters.AddWithValue("@s_GUID", array1[18]);
                            cmd.Parameters.AddWithValue("@s_L", array1[19]);

                            cmd.Connection = conn_tabl;
                            cmd.ExecuteNonQuery();
                        }
                        kolvo_strok++;
                    }
                    ////////////////////////
                    ///внести из файла в таблицу системы в сборе
                    ////////////////////////
                    if (vnesti)
                    {
                        try
                        {
                            var rows = dt.Rows;
                            var rows_ = Blocks.Rows;
                            try
                            {
                                Prov(rows, Blocks);
                            }
                            catch (Exception p1)
                            {
                                MessageBox.Show(p1.ToString());
                                return;
                            }
                            int length = 2;
                            foreach (DataRow row_ in rows)
                            {
                                length = row_.ItemArray.Length;
                                for (int i = row_.ItemArray.Length; i > 2; i--)
                                {
                                    if (row_[i - 1] == null || row_[i - 1].ToString() == "")
                                    {
                                        length = length - 1;
                                    }
                                    else
                                        break;
                                }
                                var row_new = Sys_sb.NewRow();
                                var row_new1 = Sys_sb.NewRow();
                                row_new["Номер системы"] = row_.ItemArray[0];
                                row_new["Тип системы"] = row_.ItemArray[1];
                                row_new["Дата проверки"] = curDate;

                                if (length > 19)
                                {
                                    return;
                                }
                                if (length > 11)
                                {
                                    row_new1["Номер системы"] = row_.ItemArray[0] + "(н)";
                                    row_new1["Тип системы"] = row_.ItemArray[1];
                                    row_new1["Дата проверки"] = curDate;
                                    for (int i = 1; i < 9; i++)
                                    {
                                        row_new["Блок" + i] = row_.ItemArray[i + 2];

                                    }
                                    int g = 1;
                                    for (int i = 9; i < length - 2; i++)
                                    {
                                        row_new1["Блок" + g] = row_.ItemArray[i + 2];
                                        g++;

                                    }
                                }
                                else
                                {
                                    for (int i = 1; i < length - 2; i++)
                                    {
                                        row_new["Блок" + i] = row_.ItemArray[i + 2];

                                    }
                                }


                                if (length > 11)
                                {
                                    var array1_1 = row_new1.ItemArray;
                                    OleDbCommand cmd1 = new OleDbCommand();
                                    cmd1.CommandType = CommandType.Text;
                                    cmd1.CommandText = "INSERT INTO `Системы в сборе` (`Номер системы`, `Тип системы`, `Дата проверки`, " +
                                    "`Местонахождение`, `Примечания`, `Блок1`, `Блок2`, `Блок3`, `Блок4`," +
                                    " `Блок5`, `Блок6`, `Блок7`, `Блок8`, `Книга Протоколов`, `Страница в книге`, `s_ColLineage`," +
                                    " `s_Generation`, `s_GUID`, `s_Lineage`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                                    cmd1.Parameters.AddWithValue("@NumberSys", array1_1[1]);
                                    cmd1.Parameters.AddWithValue("@TypeSys", array1_1[2]);
                                    cmd1.Parameters.AddWithValue("@Data", array1_1[3]);
                                    cmd1.Parameters.AddWithValue("@Location", array1_1[4]);
                                    cmd1.Parameters.AddWithValue("@Prim", array1_1[5]);
                                    cmd1.Parameters.AddWithValue("@Block1", array1_1[6]);
                                    cmd1.Parameters.AddWithValue("@Block2", array1_1[7]);
                                    cmd1.Parameters.AddWithValue("@Block3", array1_1[8]);
                                    cmd1.Parameters.AddWithValue("@Block4", array1_1[9]);
                                    cmd1.Parameters.AddWithValue("@Block5", array1_1[10]);
                                    cmd1.Parameters.AddWithValue("@Block6", array1_1[11]);
                                    cmd1.Parameters.AddWithValue("@Block7", array1_1[12]);
                                    cmd1.Parameters.AddWithValue("@Block8", array1_1[13]);
                                    cmd1.Parameters.AddWithValue("@Book", array1_1[14]);
                                    cmd1.Parameters.AddWithValue("@List", array1_1[15]);
                                    cmd1.Parameters.AddWithValue("@s_C", array1_1[16]);
                                    cmd1.Parameters.AddWithValue("@s_G", array1_1[17]);
                                    cmd1.Parameters.AddWithValue("@s_GUID", array1_1[18]);
                                    cmd1.Parameters.AddWithValue("@s_L", array1_1[19]);

                                    cmd1.Connection = conn_tabl;
                                    cmd1.ExecuteNonQuery();
                                }
                                var array1 = row_new.ItemArray;
                                OleDbCommand cmd = new OleDbCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "INSERT INTO `Системы в сборе` (`Номер системы`, `Тип системы`, `Дата проверки`, " +
                                "`Местонахождение`, `Примечания`, `Блок1`, `Блок2`, `Блок3`, `Блок4`," +
                                " `Блок5`, `Блок6`, `Блок7`, `Блок8`, `Книга Протоколов`, `Страница в книге`, `s_ColLineage`," +
                                " `s_Generation`, `s_GUID`, `s_Lineage`) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                                cmd.Parameters.AddWithValue("@NumberSys", array1[1]);
                                cmd.Parameters.AddWithValue("@TypeSys", array1[2]);
                                cmd.Parameters.AddWithValue("@Data", array1[3]);
                                cmd.Parameters.AddWithValue("@Location", array1[4]);
                                cmd.Parameters.AddWithValue("@Prim", array1[5]);
                                cmd.Parameters.AddWithValue("@Block1", array1[6]);
                                cmd.Parameters.AddWithValue("@Block2", array1[7]);
                                cmd.Parameters.AddWithValue("@Block3", array1[8]);
                                cmd.Parameters.AddWithValue("@Block4", array1[9]);
                                cmd.Parameters.AddWithValue("@Block5", array1[10]);
                                cmd.Parameters.AddWithValue("@Block6", array1[11]);
                                cmd.Parameters.AddWithValue("@Block7", array1[12]);
                                cmd.Parameters.AddWithValue("@Block8", array1[13]);
                                cmd.Parameters.AddWithValue("@Book", array1[14]);
                                cmd.Parameters.AddWithValue("@List", array1[15]);
                                cmd.Parameters.AddWithValue("@s_C", array1[16]);
                                cmd.Parameters.AddWithValue("@s_G", array1[17]);
                                cmd.Parameters.AddWithValue("@s_GUID", array1[18]);
                                cmd.Parameters.AddWithValue("@s_L", array1[19]);

                                cmd.Connection = conn_tabl;
                                cmd.ExecuteNonQuery();

                            }
                            char[] Mychar = { '.', 't', 'x', ' ' };
                            string wayyy = way_.TrimEnd(Mychar);
                            wayyy = wayyy + "(внесено).txt";
                            File.Move(way_, wayyy);
                        }
                        catch (Exception o)
                        {
                            MessageBox.Show(o.ToString());
                        }

                        ////////////////
                    }
                    conn_tabl.Close();
                }
                catch (Exception p)
                { MessageBox.Show(p.ToString()); }
                int w = 1, q = 2;
                try
                {
                    string file = Path.GetFileName(fil);
                    string newPath = Path.Combine(Form1.Proverka_ways_perem, file);
                    File.Move(fil, newPath);
                }
                catch (IOException)
                {
                    do
                    {
                        try
                        {
                            string file = Path.GetFileNameWithoutExtension(fil) + "-" + w + ".txt";
                            string newPath = Path.Combine(Form1.Proverka_ways_perem, file);
                            File.Move(fil, newPath);
                            q = 3;
                        }
                        catch (Exception)
                        { w++; }
                    } while (q == 2);
                }
            }
        }
        public void Prov(DataRowCollection rows, DataTable table)
        {
            try
            {
                var rows_ = table.Rows;

                int k = 0;
                int k1 = 0;
                int length = 2;
                int t2;
                int t3;
                t3 = table.Columns["Примечания"].Ordinal;
                t2 = table.Columns["Отметка выполнения"].Ordinal;
                foreach (DataRow row_ in rows)
                {
                    length = row_.ItemArray.Length;
                    for (int i = row_.ItemArray.Length; i > 2; i--)
                    {
                        if (row_[i - 1] == null || row_[i - 1].ToString() == "")
                        {
                            length = length - 1;
                        }
                        else
                            break;
                    }
                    if (length > 19)
                    {
                        MessageBox.Show("Строка превышает лимит в 16 блоков!");
                        return;
                    }

                    for (int i = 3; i < length; i++)
                    {
                        foreach (DataRow r in rows_)
                        {
                            if (r.ItemArray[0].ToString() == row_.ItemArray[i].ToString())
                            {
                                k++;
                                k1 = length;

                                OleDbConnection dbCon = new OleDbConnection(Form1.conString);
                                dbCon.Open();
                                var array1 = r.ItemArray;

                                if (array1[t2].ToString().Contains(".сохранено в файле"))
                                {
                                    char[] Mychar = { 'с', 'о', 'х', 'р', 'а', 'н', 'е', 'в', 'ф', 'й', 'л', ' ' };
                                    string str = array1[t2].ToString();
                                    str = str.TrimEnd(Mychar);
                                    r[t2] = str;
                                }
                                var ttt = r[t2].ToString();
                                string rr;
                                rr = r[t3].ToString();
                                rr = "Выпущен в составе системы " + row_.ItemArray[0];
                                r[t3] = rr;
                                rr = "";
                                char ch = ttt.Contains("Г") ? 'a' :
                                    ttt.Contains("г") ? 'b' :
                                    'c';
                                switch (ch)
                                {
                                    case 'a':
                                        rr = r[t2].ToString();
                                        rr = rr.Replace("Г", "в");
                                        r[t2] = rr;
                                        break;
                                    case 'b':
                                        rr = r[t2].ToString();
                                        rr = rr.Replace("г", "в");
                                        r[t2] = rr;
                                        break;
                                    case 'c':
                                        rr = r[t2].ToString();
                                        rr = rr + "в";
                                        r[t2] = rr;
                                        break;
                                }
                                array1 = r.ItemArray;
                                OleDbCommand cmd = new OleDbCommand();
                                cmd.CommandType = CommandType.Text;
                                cmd.CommandText = "UPDATE `Блоки` SET `Номер БД` = ?, `Тип БД` = ?, `Номер ФЭУ` = ?," +
                        " `Номинальное U` = ?, `Примечания` = ?, `Местоположение` = ?, `Отметка выполнения` = ?, " +
                        "`КАН` = ?, `s_ColLineage` = ?, `s_Generation` = ?, `s_GUID` = ?, `s_Lineage` = ? " +
                        "WHERE `Номер БД` = ?";
                                cmd.Parameters.AddWithValue("@NumberBD", array1[0]);
                                cmd.Parameters.AddWithValue("@TypeBD", array1[1]);
                                cmd.Parameters.AddWithValue("@FEY", array1[2]);
                                cmd.Parameters.AddWithValue("@Nomin", array1[3]);
                                cmd.Parameters.AddWithValue("@Prim", array1[4]);
                                cmd.Parameters.AddWithValue("@Location", array1[5]);
                                cmd.Parameters.AddWithValue("@Otmetca", array1[6]);
                                cmd.Parameters.AddWithValue("@KAN", array1[7]);
                                cmd.Parameters.AddWithValue("@s_C", array1[8]);
                                cmd.Parameters.AddWithValue("@s_G", array1[9]);
                                cmd.Parameters.AddWithValue("@s_GUID", array1[10]);
                                cmd.Parameters.AddWithValue("@s_L", array1[11]);
                                cmd.Parameters.AddWithValue("@ID", array1[0]);

                                cmd.Connection = dbCon;
                                cmd.ExecuteNonQuery();

                            }
                        }
                    }

                }
                if (k < k1 - 3)
                {
                    MessageBox.Show("Не все блоки существуют!");
                    return;
                }

            }
            catch (Exception p)
            { MessageBox.Show(p.ToString()); }

        }
    }
}
