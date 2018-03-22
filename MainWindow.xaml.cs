using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Globalization;

namespace routing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string StringFromRichTextBox(RichTextBox rtb)
        {
            TextRange textRange = new TextRange(
                rtb.Document.ContentStart,
                rtb.Document.ContentEnd
            );
            return textRange.Text;
        }

        public static string[][] treasurepoints = new string[48][];

        public static void settreasurepoints()
        {
            treasurepoints[0] = new string[5] { "ギラバニア辺境地帯", "A", "15.5", "16.5", "treasure" };
            treasurepoints[1] = new string[5] { "ギラバニア辺境地帯", "B", "9.3", "12.5", "treasure" };
            treasurepoints[2] = new string[5] { "ギラバニア辺境地帯", "C", "11.1", "31.1", "treasure" };
            treasurepoints[3] = new string[5] { "ギラバニア辺境地帯", "D", "31.5", "20.8", "treasure" };
            treasurepoints[4] = new string[5] { "ギラバニア辺境地帯", "E", "8.3", "28.2", "treasure" };
            treasurepoints[5] = new string[5] { "ギラバニア辺境地帯", "F", "25.7", "20.1", "treasure" };
            treasurepoints[6] = new string[5] { "ギラバニア辺境地帯", "G", "23.4", "12.2", "treasure" };
            treasurepoints[7] = new string[5] { "ギラバニア辺境地帯", "H", "33.0", "31.4", "treasure" };

            treasurepoints[8] = new string[5] { "ギラバニア山岳地帯", "A", "8.6", "32.5", "treasure" };
            treasurepoints[9] = new string[5] { "ギラバニア山岳地帯", "B", "16.1", "9.2", "treasure" };
            treasurepoints[10] = new string[5] { "ギラバニア山岳地帯", "C", "24.0", "31.6", "treasure" };
            treasurepoints[11] = new string[5] { "ギラバニア山岳地帯", "D", "15.7", "33.1", "treasure" };
            treasurepoints[12] = new string[5] { "ギラバニア山岳地帯", "E", "15.4", "22.9", "treasure" };
            treasurepoints[13] = new string[5] { "ギラバニア山岳地帯", "F", "26.0", "13.7", "treasure" };
            treasurepoints[14] = new string[5] { "ギラバニア山岳地帯", "G", "12.2", "5.5", "treasure" };
            treasurepoints[15] = new string[5] { "ギラバニア山岳地帯", "H", "33.1", "9.8", "treasure" };

            treasurepoints[16] = new string[5] { "ギラバニア湖畔地帯", "A", "8.7", "17.7", "treasure" };
            treasurepoints[17] = new string[5] { "ギラバニア湖畔地帯", "B", "5.8", "6.7", "treasure" };
            treasurepoints[18] = new string[5] { "ギラバニア湖畔地帯", "C", "31.9", "6.4", "treasure" };
            treasurepoints[19] = new string[5] { "ギラバニア湖畔地帯", "D", "25.1", "7.8", "treasure" };
            treasurepoints[20] = new string[5] { "ギラバニア湖畔地帯", "E", "19.6", "23.3", "treasure" };
            treasurepoints[21] = new string[5] { "ギラバニア湖畔地帯", "F", "15.9", "28.6", "treasure" };
            treasurepoints[22] = new string[5] { "ギラバニア湖畔地帯", "G", "24.5", "32.0", "treasure" };
            treasurepoints[23] = new string[5] { "ギラバニア湖畔地帯", "H", "29.7", "17.4", "treasure" };

            treasurepoints[24] = new string[5] { "ヤンサ", "A", "31.0", "28.5", "treasure" };
            treasurepoints[25] = new string[5] { "ヤンサ", "B", "13.2", "30.1", "treasure" };
            treasurepoints[26] = new string[5] { "ヤンサ", "C", "31.8", "35.5", "treasure" };
            treasurepoints[27] = new string[5] { "ヤンサ", "D", "22.2", "27.8", "treasure" };
            treasurepoints[28] = new string[5] { "ヤンサ", "E", "32.0", "5.4", "treasure" };
            treasurepoints[29] = new string[5] { "ヤンサ", "F", "20.0", "5.5", "treasure" };
            treasurepoints[30] = new string[5] { "ヤンサ", "G", "21.8", "13.9", "treasure" };
            treasurepoints[31] = new string[5] { "ヤンサ", "H", "12.0", "18.9", "treasure" };

            treasurepoints[32] = new string[5] { "紅玉海", "A", "7.7", "29.7", "treasure" };
            treasurepoints[33] = new string[5] { "紅玉海", "B", "5.2", "15.1", "treasure" };
            treasurepoints[34] = new string[5] { "紅玉海", "C", "32.9", "18.4", "treasure" };
            treasurepoints[35] = new string[5] { "紅玉海", "D", "27.7", "30.0", "treasure" };
            treasurepoints[36] = new string[5] { "紅玉海", "E", "30.5", "25.4", "treasure" };
            treasurepoints[37] = new string[5] { "紅玉海", "F", "16.9", "9.6", "treasure" };
            treasurepoints[38] = new string[5] { "紅玉海", "G", "18.4", "36.3", "treasure" };
            treasurepoints[39] = new string[5] { "紅玉海", "H", "32.7", "8.8", "treasure" };

            treasurepoints[40] = new string[5] { "アジムステップ", "A", "5.3", "24.4", "treasure" };
            treasurepoints[41] = new string[5] { "アジムステップ", "B", "21.7", "36.9", "treasure" };
            treasurepoints[42] = new string[5] { "アジムステップ", "C", "30.9", "22.1", "treasure" };
            treasurepoints[43] = new string[5] { "アジムステップ", "D", "29.2", "35.3", "treasure" };
            treasurepoints[44] = new string[5] { "アジムステップ", "E", "29.5", "11.8", "treasure" };
            treasurepoints[45] = new string[5] { "アジムステップ", "F", "16.5", "25.0", "treasure" };
            treasurepoints[46] = new string[5] { "アジムステップ", "G", "14.9", "33.0", "treasure" };
            treasurepoints[47] = new string[5] { "アジムステップ", "H", "10.6", "15.9", "treasure" };
        }

        //check if there is map info contained in the line
        static string[] checkmap(string line)
        {
            string[] result = new string[2] { "false" , "NoMapFound" };
            if (line.Contains("高地ドラヴァニア"))
            {
                result[0] = "true";
                result[1] = "高地ドラヴァニア";
            }
            if (line.Contains("アバラシア雲海"))
            {
                result[0] = "true";
                result[1] = "アバラシア雲海";
            }
            if(line.Contains("ドラヴァニア雲海"))
            {
                result[0] = "true";
                result[1] = "ドラヴァニア雲海";
            }
            if (line.Contains("クル"))
            {
                result[0] = "true";
                result[1] = "クルザス西部高地";
            }
            if (line.Contains("西部"))
            {
                result[0] = "true";
                result[1] = "クルザス西部高地";
            }
            if (line.Contains("ギラバニア辺境地帯"))
            {
                result[0] = "true";
                result[1] = "ギラバニア辺境地帯";
            }
            if (line.Contains("ギラバニア山岳地帯"))
            {
                result[0] = "true";
                result[1] = "ギラバニア山岳地帯";
            }
            if (line.Contains("ギラバニア湖畔地帯"))
            {
                result[0] = "true";
                result[1] = "ギラバニア湖畔地帯";
            }
            if (line.Contains("アジムステップ"))
            {
                result[0] = "true";
                result[1] = "アジムステップ";
            }
            if (line.Contains("ヤンサ"))
            {
                result[0] = "true";
                result[1] = "ヤンサ";
            }
            if (line.Contains("紅玉海"))
            {
                result[0] = "true";
                result[1] = "紅玉海";
            }
            return result;
        }

        //check if there is cood info contained in the line
        static string[] checknum(string line)
        {
            string[] result = new string[3];
            string tf = "false";
            string double1 = "-1";
            string double2 = "-1";
            result[0] = tf;
            result[1] = double1;
            result[2] = double2;
            int i = 999999999;
            if (line.IndexOf("0") != -1 && line.IndexOf("0") < i)
            {
                i = line.IndexOf("0");
            }

            if (line.IndexOf("1") != -1 && line.IndexOf("1") < i)
            {
                i = line.IndexOf("1");
            }

            if (line.IndexOf("2") != -1 && line.IndexOf("2") < i)
            {
                i = line.IndexOf("2");
            }

            if (line.IndexOf("3") != -1 && line.IndexOf("3") < i)
            {
                i = line.IndexOf("3");
            }

            if (line.IndexOf("4") != -1 && line.IndexOf("4") < i)
            {
                i = line.IndexOf("4");
            }

            if (line.IndexOf("5") != -1 && line.IndexOf("5") < i)
            {
                i = line.IndexOf("5");
            }

            if (line.IndexOf("6") != -1 && line.IndexOf("6") < i)
            {
                i = line.IndexOf("6");
            }

            if (line.IndexOf("7") != -1 && line.IndexOf("7") < i)
            {
                i = line.IndexOf("7");
            }

            if (line.IndexOf("8") != -1 && line.IndexOf("8") < i)
            {
                i = line.IndexOf("8");
            }

            if (line.IndexOf("9") != -1 && line.IndexOf("9") < i)
            {
                i = line.IndexOf("9");
            }

            if (i != 999999999)
            {
                double1 = line.Substring(i, 1);
                while (line.Substring(i+1,1) == "0" || line.Substring(i + 1, 1) == "1" || line.Substring(i + 1, 1) == "2" || line.Substring(i + 1, 1) == "3" || line.Substring(i + 1, 1) == "4" || line.Substring(i + 1, 1) == "5" || line.Substring(i + 1, 1) == "6" || line.Substring(i + 1, 1) == "7" || line.Substring(i + 1, 1) == "8" || line.Substring(i + 1, 1) == "9" || line.Substring(i + 1, 1) == ".")
                {
                    i++;
                    double1 = double1 + line.Substring(i, 1);
                }
                line = line.Substring(i + 1, line.Length - i - 1);
            }

            i = 999999999;
            if (line.IndexOf("0") != -1 && line.IndexOf("0") < i)
            {
                i = line.IndexOf("0");
            }

            if (line.IndexOf("1") != -1 && line.IndexOf("1") < i)
            {
                i = line.IndexOf("1");
            }

            if (line.IndexOf("2") != -1 && line.IndexOf("2") < i)
            {
                i = line.IndexOf("2");
            }

            if (line.IndexOf("3") != -1 && line.IndexOf("3") < i)
            {
                i = line.IndexOf("3");
            }

            if (line.IndexOf("4") != -1 && line.IndexOf("4") < i)
            {
                i = line.IndexOf("4");
            }

            if (line.IndexOf("5") != -1 && line.IndexOf("5") < i)
            {
                i = line.IndexOf("5");
            }

            if (line.IndexOf("6") != -1 && line.IndexOf("6") < i)
            {
                i = line.IndexOf("6");
            }

            if (line.IndexOf("7") != -1 && line.IndexOf("7") < i)
            {
                i = line.IndexOf("7");
            }

            if (line.IndexOf("8") != -1 && line.IndexOf("8") < i)
            {
                i = line.IndexOf("8");
            }

            if (line.IndexOf("9") != -1 && line.IndexOf("9") < i)
            {
                i = line.IndexOf("9");
            }

            if (i != 999999999)
            {
                double2 = line.Substring(i, 1);
                while (line.Substring(i + 1, 1) == "0" || line.Substring(i + 1, 1) == "1" || line.Substring(i + 1, 1) == "2" || line.Substring(i + 1, 1) == "3" || line.Substring(i + 1, 1) == "4" || line.Substring(i + 1, 1) == "5" || line.Substring(i + 1, 1) == "6" || line.Substring(i + 1, 1) == "7" || line.Substring(i + 1, 1) == "8" || line.Substring(i + 1, 1) == "9" || line.Substring(i + 1, 1) == ".")
                {
                    i++;
                    double2 = double2 + line.Substring(i, 1);
                }
            }

            if (double1 != "-1" && double2 != "-1")
            {
                tf = "true";
                result[0] = tf;
                result[1] = double1;
                result[2] = double2;
            }

            return result;
        }

        //delete numbers before names:
        static string deletenumberofname(string name)
        {
            string result = name;
            int l = name.Length - 1;
            if (name.IndexOf("") != -1) {
                result = name.Substring(1, l);
            }
            if (name.IndexOf("") != -1)
            {
                result = name.Substring(1, l);
            }
            if (name.IndexOf("") != -1)
            {
                result = name.Substring(1, l);
            }
            if (name.IndexOf("") != -1)
            {
                result = name.Substring(1, l);
            }
            if (name.IndexOf("") != -1)
            {
                result = name.Substring(1, l);
            }
            if (name.IndexOf("") != -1)
            {
                result = name.Substring(1, l);
            }
            if (name.IndexOf("") != -1)
            {
                result = name.Substring(1, l);
            }
            if (name.IndexOf("") != -1)
            {
                result = name.Substring(1, l);
            }
            return result;
        }

        public static string[][] coordinateadjust (string[][] players, string[][] mapinfo)
        {
            string[][] result = players;

            for (int i = 0; i < result.Length; i++)
            {
                int k = -1;
                double mindistance = 999999999;
                for (int j = 0; j < mapinfo.Length; j++)
                {
                    if (result[i][1] == mapinfo[j][0])
                    {
                        double currentdistance = Program.codistance(result[i], mapinfo[j]);
                        if (currentdistance < mindistance)
                        {
                            k = j;
                            mindistance = currentdistance;
                        }
                    }
                }
                if (mindistance < 3)
                {
                    result[i][2] = mapinfo[k][2];
                    result[i][3] = mapinfo[k][3];
                }
                if (result[i][1] == "ヤンサ")
                {
                    string locationinyanxia = "X";
                    for (int p = 0; p < mapinfo.Length; p++)
                    {
                        if (result[i][1] == mapinfo[p][0])
                        {
                            if (result[i][2] == mapinfo[p][2] && result[i][3] == mapinfo[p][3]) {
                                locationinyanxia = mapinfo[p][1];
                            }
                        }
                    }
                    if (locationinyanxia == "A" || locationinyanxia == "B" || locationinyanxia == "C" || locationinyanxia == "D") {
                        result[i][1] = "ヤンサ(南東)";
                    }
                    if (locationinyanxia == "E" || locationinyanxia == "F" || locationinyanxia == "G" || locationinyanxia == "H")
                    {
                        result[i][1] = "ヤンサ(北西)";
                    }
                }
            }

            return result;
        }

        //change input to string of players
        static string[][] getplayerdata(string origininput, string myname)
        {
            settreasurepoints();
            string[][] players = new string[8][];
            for (int c = 0; c < 8; c++)
            {
                players[c] = new string[5];
            }
            Program.fill2(players);
            string input = origininput + "\n ";
            string[] ifmap = new string[2] { "", "" };
            string[] ifnum = new string[3] { "" , "" , "" };
            string tempstring = "";
            string tempname = "";
            int k = 0;
            int l = 0;
            int i = 0;
            int m = 0;
            int n = 0;
            while (input.Contains("\n"))
            {
                k = input.IndexOf("\n") + 1;
                l = input.Length;
                tempstring = input.Substring(0, k);
                input = input.Substring(k , l - k);
                ifmap = checkmap(tempstring);
                ifnum = checknum(tempstring);
                if (ifmap[0] == "true" && ifnum[0] == "true")
                {
                    m = tempstring.IndexOf("(") + 1;
                    n = tempstring.IndexOf(")");
                    tempname = tempstring.Substring(m, n - m);
                    tempname = deletenumberofname(tempname);
                    if (tempname == myname)
                    {
                        tempname = "私";
                    }
                    players[i][0] = tempname;
                    players[i][1] = ifmap[1];
                    players[i][2] = ifnum[1];
                    players[i][3] = ifnum[2];
                    players[i][4] = "0";
                    i++;
                    for (int j = 0; j < i - 1; j++)
                    {
                        if (players[j][0] == tempname)
                        {
                            players[j][0] = tempname;
                            players[j][1] = ifmap[1];
                            players[j][2] = ifnum[1];
                            players[j][3] = ifnum[2];
                            players[j][4] = "0";
                            players[i - 1][0] = "";
                            players[i - 1][1] = "";
                            players[i - 1][2] = "";
                            players[i - 1][3] = "";
                            players[i - 1][4] = "";
                            i = i - 1;
                        }
                    }
                }
            }
            //players = sortplayersfor4(players);
            players = coordinateadjust(players, treasurepoints);
            return players;
        }


        //Get the first name from full name
        static string getfirstname(string name)
        {
            string result;
            int i = name.IndexOf(" ");
            result = name.Substring(0, i);
            return result;
        }

        //Convert full name to first name in the finished
        static string[][] convertfirstname(string[][] finished)
        {
            string[] firstnamelist = new string[finished.Length];
            Program.fill1(firstnamelist);
            for (int m = 0; m < firstnamelist.Length; m++)
            {
                if (finished[m][0].IndexOf(" ") != -1)
                {
                    firstnamelist[m] = String.Copy(getfirstname(finished[m][0]));
                }
            }
            string[] dupcheck = new string[firstnamelist.Length];
            Program.fill1(dupcheck);
            for (int n = 0; n < dupcheck.Length; n++)
            {
                for (int o = 0; o < firstnamelist.Length; o++)
                {
                    if (o != n)
                    {
                        if (firstnamelist[n] == firstnamelist[o])
                        {
                            dupcheck[n] = "1";
                        }
                    }
                }
            }
            for (int i = 0; i < finished.Length; i++)
            {
                if(dupcheck[i] != "1")
                {
                    finished[i][0] = String.Copy(firstnamelist[i]);
                }
            }            
            return finished;
        }

        public static void yanxiaconverter(string[][] results)
        {
            for (int i = 0; i < results.Length; i++)
            {
                if (results[i][4] == "0" || results[i][4] == "1")
                {
                    if (results[i][1] == "ヤンサ(南東)" || results[i][1] == "ヤンサ(北西)")
                    {
                        results[i][1] = "ヤンサ";
                    }
                }
                if (results[i][4] == "map")
                {
                    if (results[i][0] == "ヤンサ(南東)" || results[i][0] == "ヤンサ(北西)")
                    {
                        results[i][0] = "ヤンサ";
                    }
                    if (results[i][1] == "ヤンサ(南東)" || results[i][1] == "ヤンサ(北西)")
                    {
                        results[i][1] = "ヤンサ";
                    }
                }
                if (results[i][4] == "tele")
                {
                    if (results[i][1] == "ヤンサ(南東)" || results[i][1] == "ヤンサ(北西)")
                    {
                        results[i][1] = "ヤンサ";
                    }
                }
            }
        }

        public static string[][] sumresult(string[][] finished)
        {
            string[][] result = new string[16][];
            for (int c = 0; c < result.Length; c++)
            {
                result[c] = new string[5];
            }
            Program.fill2(result);
            int k = 0;

            for (int i = 0; i < finished.Length; i++)
            {
                string location = "";
                string x = "";
                string y = "";
                if (finished[i][4] == "0" || finished[i][4] == "1")
                {
                    location = finished[i][1];
                    x = finished[i][2];
                    y = finished[i][3];
                    if (finished[i][0] == "私")
                    {
                        result[k][0] = result[i][0] + "私 ";
                    }
                    else
                    {
                        result[k][0] = finished[i][0] + "さん ";
                    }
                    result[k][1] = finished[i][1];
                    result[k][2] = finished[i][2];
                    result[k][3] = finished[i][3];
                    result[k][4] = finished[i][4];

                    for (int j = i + 1; j < finished.Length; j++)
                    {
                        if (finished[j][4] == "0" || finished[j][4] == "1")
                        {
                            if (finished[j][1] == location && finished[j][2] == x && finished[j][3] == y)
                            {
                                if (finished[j][0] == "私")
                                {
                                    result[k][0] = result[k][0] + "と " + finished[j][0] + " ";
                                }
                                else
                                {
                                    result[k][0] = result[k][0] + "と " + finished[j][0] + "さん ";
                                }

                                i++;
                            }
                        }
                    }
                }
                else
                {
                    result[k][0] = finished[i][0];
                    result[k][1] = finished[i][1];
                    result[k][2] = finished[i][2];
                    result[k][3] = finished[i][3];
                    result[k][4] = finished[i][4];
                }
                k++;
            }

            return result;
        }

        //Converting string array to macro
        static string getmacro(string[][] result)
        {
            string[][] finished = new string[16][];
            for (int c = 0; c < finished.Length; c++)
            {
                finished[c] = new string[5];
            }
            Program.fill2(finished);

            yanxiaconverter(result);
            result = convertfirstname(result);
            finished = sumresult(result);

            string output = "/p 整理の結果は以下です、レッツゴー:";
            for (int i = 0; i < finished.Length; i++)
            {
                if (finished[i][4] == "tele")
                {
                    output = output + "\n/p テレポ -->" + finished[i][0];
                }
                if (finished[i][4] == "map")
                {
                    if (finished[i][0] != finished[i][1])
                    {
                        output = output + "\n/p -->" + finished[i][0] + "へ移動";
                    }
                }
                if (finished[i][4] == "0" || finished[i][4] == "1")
                {
                    output = output + "\n/p " + finished[i][0] + "--- " + finished[i][1] + " ( " + finished[i][2] + " , " + finished[i][3] + " )";
                }
            }
            return output;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String input;
            String name;
            int l;
            input = StringFromRichTextBox(Input);
            name = StringFromRichTextBox(MyName);
            l = name.IndexOf("\r");
            if (l != -1)
            {
                name = name.Substring(0, l);
            }
            string[][] players = getplayerdata(input, name);
            string[][] finished = Program.arrange(players);
            Output.SelectAll();
            Output.Selection.Text = getmacro(finished);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Input.SelectAll();
            Input.Selection.Text = "";
            Output.SelectAll();
            Output.Selection.Text = "";
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
    }

    public static class Program
    {
        //implement map data
        public static string[][] telepoints = new string[19][];

        public static string[][] boarders = new string[16][];

        public static void setData()
        {
            telepoints[0] = new string[5] { "不浄の三塔(高地ドラヴァニア)", "高地ドラヴァニア", "16.4", "23.2", "tele" };
            telepoints[1] = new string[5] { "オク・ズンド(アバラシア雲海)", "アバラシア雲海", "10.4", "14.1", "tele" };
            telepoints[2] = new string[5] { "テイルフェザー(高地ドラヴァニア)", "高地ドラヴァニア", "33.2", "23.1", "tele" };
            telepoints[3] = new string[5] { "キャンプ・クラウドトップ(アバラシア雲海)", "アバラシア雲海", "10.2", "33.5", "tele" };
            telepoints[4] = new string[5] { "ファルコンネスト(クルザス西部高地)", "クルザス西部高地", "32.0", "36.7", "tele" };
            telepoints[5] = new string[5] { "モグモグホーム(ドラヴァニア雲海)", "ドラヴァニア雲海", "27.8", "34.2", "tele" };
            telepoints[6] = new string[5] { "白亜の宮殿(ドラヴァニア雲海)", "ドラヴァニア雲海", "10.7", "28.8", "tele" };
            telepoints[7] = new string[5] { "カストルム・オリエンス(ギラバニア辺境地帯)", "ギラバニア辺境地帯", "8.9", "11.3", "tele" };
            telepoints[8] = new string[5] { "ピーリングストーンズ(ギラバニア辺境地帯)", "ギラバニア辺境地帯", "29.8", "26.4", "tele" };
            telepoints[9] = new string[5] { "アラガーナ(ギラバニア山岳地帯)", "ギラバニア山岳地帯", "23.7", "6.5", "tele" };
            telepoints[10] = new string[5] { "アラギリ(ギラバニア山岳地帯)", "ギラバニア山岳地帯", "16.0", "36.5", "tele" };
            telepoints[11] = new string[5] { "ポルタ・プレトリア(ギラバニア湖畔地帯)", "ギラバニア湖畔地帯", "8.4", "21.2", "tele" };
            telepoints[12] = new string[5] { "アラミガン・クォーター(ギラバニア湖畔地帯)", "ギラバニア湖畔地帯", "33.7", "34.5", "tele" };
            telepoints[13] = new string[5] { "明けの玉座(アジムステップ)", "アジムステップ", "23.0", "22.5", "tele" };
            telepoints[14] = new string[5] { "再会の市(アジムステップ)", "アジムステップ", "32.5", "28.6", "tele" };
            telepoints[15] = new string[5] { "烈士庵(ヤンサ)", "ヤンサ(北西)", "26.3", "13.4", "tele" };
            telepoints[16] = new string[5] { "ナマイ村(ヤンサ)", "ヤンサ(南東)", "10.7", "28.8", "tele" };
            telepoints[17] = new string[5] { "オノコロ島(紅玉海)", "紅玉海", "23.2", "9.8", "tele" };
            telepoints[18] = new string[5] { "碧のタマミズ(紅玉海)", "紅玉海", "34.5", "19.4", "tele" };


            boarders[0] = new string[5] { "高地ドラヴァニア", "クルザス西部高地", "5.6", "9.5", "map" };
            boarders[1] = new string[5] { "アバラシア雲海", "クルザス西部高地", "31.6", "4.3", "map" };
            boarders[2] = new string[5] { "クルザス西部高地", "高地ドラヴァニア", "40.0", "29.5", "map" };
            boarders[3] = new string[5] { "クルザス西部高地", "アバラシア雲海", "4.7", "4.7", "map" };
            boarders[4] = new string[5] { "ギラバニア山岳地帯", "ギラバニア辺境地帯", "38.6", "28.8", "map" };
            boarders[5] = new string[5] { "ギラバニア辺境地帯", "ギラバニア山岳地帯", "4.7", "26.4", "map" };
            boarders[6] = new string[5] { "ギラバニア湖畔地帯", "ギラバニア山岳地帯", "33.3", "30.1", "map" };
            boarders[7] = new string[5] { "ギラバニア山岳地帯", "ギラバニア湖畔地帯", "5.8", "21.1", "map" };
            boarders[8] = new string[5] { "ヤンサ(北西)", "アジムステップ", "18.3", "38.9", "map" };
            boarders[9] = new string[5] { "紅玉海", "アジムステップ", "32.3", "35.5", "map" };
            boarders[10] = new string[5] { "ヤンサ(北西)", "ヤンサ(南東)", "17.7", "20.4", "map" };
            boarders[11] = new string[5] { "ヤンサ(南東)", "ヤンサ(北西)", "17.7", "20.4", "map" };
            boarders[12] = new string[5] { "アジムステップ", "ヤンサ(北西)", "31.9", "4.2", "map" };
            boarders[13] = new string[5] { "紅玉海", "ヤンサ(南東)", "38.5", "12.8", "map" };
            boarders[14] = new string[5] { "アジムステップ", "紅玉海", "7.0", "4.2", "map" };
            boarders[15] = new string[5] { "ヤンサ(南東)", "紅玉海", "4.4", "16.7", "map" };
        }

        //parse string to double for the int part
        public static double stringparsetointdouble(string input)
        {
            double result = 0;
            int le = input.Length;
            for (int l = input.Length - 1; l >= 0; l--)
            {
                result = Math.Pow(10, Convert.ToDouble(l)) * Convert.ToDouble((int)Char.GetNumericValue(input[le - l -1])) + result;
            }
            return result;
        }

        //fillout strings with check
        public static void fill1(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = "";
            }
        }


        public static void fill2(string[][] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    input[i][j] = "";
                }
            }
        }

        public static void fill3(string[][][] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    for (int k = 0; k < input[i][j].Length; k++)
                    {
                        input[i][j][k] = "";
                    }
                }
            }
        }

        //distance calculation
        public static double codistance(string[] xy1, string[] xy2)
        {
            double x1 = Convert.ToDouble(xy1[2]);
            double y1 = Convert.ToDouble(xy1[3]);
            double x2 = Convert.ToDouble(xy2[2]);
            double y2 = Convert.ToDouble(xy2[3]);
            double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return d;
        }

        //check if in the same map
        public static Boolean inmap(string map, string[][] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i][1].Equals(map))
                {
                    return true;
                }
            }
            return false;
        }

        //make temp list with undone player
        public static string[][] maketemp(string[][] players)
        {
            string[][] result = new string[8][];
            for (int k = 0; k < 8; k++)
            {
                result[k] = new string[5];
            }
            fill2(result);
            for (int i = 0; i < 8; i++)
            {
                if (players[i][0] != "")
                {
                    if (players[i][4].Equals("0"))
                    {
                        result[i] = players[i];
                    }
                }
            }
            return result;
        }

        //reset temp list
        public static string[][] resettemp()
        {
            string[][] result = new string[8][];
            for (int i = 0; i < 8; i++)
            {
                result[i] = new string[5];
            }
            fill2(result);
            return result;
        }

        //find the next closest point
        public static string[] drouting(string[] init,string[][] points)
        {

            string[] next = new string[5];
            fill1(next);
            double mindistance = 999999999;
            int j = -1;
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i][0] != "")
                {
                    if (points[i][4] == "0")
                    {
                        if (codistance(init, points[i]) < mindistance)
                        {
                            mindistance = codistance(init, points[i]);
                            next = points[i];
                            j = i;
                        }
                    }
                }
            }
            points[j][4] = "1";
            return next;
        }

        //boarder check
        public static string[] boardercheck(string[] from, string[][] boarder)
        {
            string[] nextboarder = boarder[0];
            for (int i = 0; i < boarder.Length; i++)
            {
                if (from[1].Equals(boarder[i][0]) & from[0].Equals(boarder[i][1]))
                {
                    nextboarder = boarder[i];
                }
            }
            return nextboarder;
        }

        public static double moveweight(string init, string target)
        {
            double result = 0;

            if (init == "アジムステップ")
            {
                if (target == "アジムステップ")
                {
                    result = 0;
                }
                if (target == "ヤンサ(北西)")
                {
                    result = 11;
                }
                if (target == "ヤンサ(南東)")
                {
                    result = 999;
                }
                if (target == "紅玉海")
                {
                    result = 11;
                }
                if (target == "ギラバニア辺境地帯" || target == "ギラバニア山岳地帯" || target == "ギラバニア湖畔地帯")
                {
                    result = 9999;
                }
            }

            if (init == "ヤンサ(北西)")
            {
                if (target == "ヤンサ(北西)")
                {
                    result = 0;
                }
                if (target == "ヤンサ(南東)")
                {
                    result = 0;
                }
                if (target == "アジムステップ")
                {
                    result = 11;
                }
                if (target == "紅玉海")
                {
                    result = 999;
                }
                if (target == "ギラバニア辺境地帯" || target == "ギラバニア山岳地帯" || target == "ギラバニア湖畔地帯")
                {
                    result = 9999;
                }
            }

            if (init == "ヤンサ(南東)")
            {
                if (target == "ヤンサ(北西)")
                {
                    result = 0;
                }
                if (target == "ヤンサ(南東)")
                {
                    result = 0;
                }
                if (target == "アジムステップ")
                {
                    result = 999;
                }
                if (target == "紅玉海")
                {
                    result = 11;
                }
                if (target == "ギラバニア辺境地帯" || target == "ギラバニア山岳地帯" || target == "ギラバニア湖畔地帯")
                {
                    result = 9999;
                }
            }

            if (init == "紅玉海")
            {
                if (target == "ヤンサ(北西)")
                {
                    result = 999;
                }
                if (target == "ヤンサ(南東)")
                {
                    result = 11;
                }
                if (target == "アジムステップ")
                {
                    result = 11;
                }
                if (target == "紅玉海")
                {
                    result = 0;
                }
                if (target == "ギラバニア辺境地帯" || target == "ギラバニア山岳地帯" || target == "ギラバニア湖畔地帯")
                {
                    result = 9999;
                }
            }

            if (init == "ギラバニア辺境地帯")
            {
                if (target == "ギラバニア辺境地帯")
                {
                    result = 0;
                }
                if (target == "ギラバニア山岳地帯")
                {
                    result = 11;
                }
                if (target == "ギラバニア湖畔地帯")
                {
                    result = 999;
                }
                if (target == "アジムステップ" || target == "ヤンサ(北西)" || target == "ヤンサ(南東)" || target == "紅玉海")
                {
                    result = 9999;
                }
            }

            if (init == "ギラバニア山岳地帯")
            {
                if (target == "ギラバニア辺境地帯")
                {
                    result = 11;
                }
                if (target == "ギラバニア山岳地帯")
                {
                    result = 0;
                }
                if (target == "ギラバニア湖畔地帯")
                {
                    result = 11;
                }
                if (target == "アジムステップ" || target == "ヤンサ(北西)" || target == "ヤンサ(南東)" || target == "紅玉海")
                {
                    result = 9999;
                }
            }

            if (init == "ギラバニア湖畔地帯")
            {
                if (target == "ギラバニア辺境地帯")
                {
                    result = 999;
                }
                if (target == "ギラバニア山岳地帯")
                {
                    result = 11;
                }
                if (target == "ギラバニア湖畔地帯")
                {
                    result = 0;
                }
                if (target == "アジムステップ" || target == "ヤンサ(北西)" || target == "ヤンサ(南東)" || target == "紅玉海")
                {
                    result = 9999;
                }
            }

            return result;
        }

        //boarder move
        public static string[][] boardermove(string[] init, string[][] boarder, string[][] points)
        {
            double mindistance = 999999999;
            string[][] next = new string[3][];
            next[0] = new string[5] { "", "", "", "", "" };
            next[1] = new string[5] { "", "", "", "", "" };
            next[2] = new string[2] { "", "" };
            int m = -1;
            int n = -1;
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i][0] != "")
                {
                    if (points[i][4] == "0")
                    {
                        for (int j = 1; j < boarder.Length; j++)
                        {
                            if (points[i][1].Equals(boarder[j][0]) & init[1].Equals(boarder[j][1]))
                            {
                                double tempdistance = codistance(init, boarder[j]) + codistance(points[i], boardercheck(boarder[j], boarders)) + moveweight(init[1], boarder[j][0]);
                                if (tempdistance < mindistance)
                                {
                                    mindistance = tempdistance;
                                    m = j;
                                    n = i;
                                }
                            }
                        }
                    }
                }
            }
            if (m != -1)
            {
                next[0] = boarder[m];
                next[1] = points[n];
                next[2][0] = Convert.ToString(Math.Round(mindistance,0));
                next[2][1] = Convert.ToString(n);
            }
            return next;
        }

        public static double teleweight(string init, string target)
        {
            double result = 0;

            if (init == "アジムステップ")
            {
                if (target == "アジムステップ")
                {
                    result = 11;
                }
                if (target == "ヤンサ(北西)")
                {
                    result = 20;
                }
                if (target == "ヤンサ(南東)")
                {
                    result = 30;
                }
                if (target == "紅玉海")
                {
                    result = 20;
                }
                if (target == "ギラバニア辺境地帯" || target == "ギラバニア山岳地帯" || target == "ギラバニア湖畔地帯")
                {
                    result = 999;
                }
            }

            if (init == "ヤンサ(北西)")
            {
                if (target == "ヤンサ(北西)")
                {
                    result = 11;
                }
                if (target == "ヤンサ(南東)")
                {
                    result = 11;
                }
                if (target == "アジムステップ")
                {
                    result = 20;
                }
                if (target == "紅玉海")
                {
                    result = 30;
                }
                if (target == "ギラバニア辺境地帯" || target == "ギラバニア山岳地帯" || target == "ギラバニア湖畔地帯")
                {
                    result = 999;
                }
            }

            if (init == "ヤンサ(南東)")
            {
                if (target == "ヤンサ(北西)")
                {
                    result = 11;
                }
                if (target == "ヤンサ(南東)")
                {
                    result = 11;
                }
                if (target == "アジムステップ")
                {
                    result = 30;
                }
                if (target == "紅玉海")
                {
                    result = 20;
                }
                if (target == "ギラバニア辺境地帯" || target == "ギラバニア山岳地帯" || target == "ギラバニア湖畔地帯")
                {
                    result = 999;
                }
            }

            if (init == "紅玉海")
            {
                if (target == "ヤンサ(北西)")
                {
                    result = 30;
                }
                if (target == "ヤンサ(南東)")
                {
                    result = 20;
                }
                if (target == "アジムステップ")
                {
                    result = 20;
                }
                if (target == "紅玉海")
                {
                    result = 11;
                }
                if (target == "ギラバニア辺境地帯" || target == "ギラバニア山岳地帯" || target == "ギラバニア湖畔地帯")
                {
                    result = 999;
                }
            }

            if (init == "ギラバニア辺境地帯")
            {
                if (target == "ギラバニア辺境地帯")
                {
                    result = 11;
                }
                if (target == "ギラバニア山岳地帯")
                {
                    result = 20;
                }
                if (target == "ギラバニア湖畔地帯")
                {
                    result = 30;
                }
                if (target == "アジムステップ" || target == "ヤンサ(北西)" || target == "ヤンサ(南東)" || target == "紅玉海")
                {
                    result = 999;
                }
            }

            if (init == "ギラバニア山岳地帯")
            {
                if (target == "ギラバニア辺境地帯")
                {
                    result = 20;
                }
                if (target == "ギラバニア山岳地帯")
                {
                    result = 11;
                }
                if (target == "ギラバニア湖畔地帯")
                {
                    result = 20;
                }
                if (target == "アジムステップ" || target == "ヤンサ(北西)" || target == "ヤンサ(南東)" || target == "紅玉海")
                {
                    result = 999;
                }
            }

            if (init == "ギラバニア湖畔地帯")
            {
                if (target == "ギラバニア辺境地帯")
                {
                    result = 30;
                }
                if (target == "ギラバニア山岳地帯")
                {
                    result = 20;
                }
                if (target == "ギラバニア湖畔地帯")
                {
                    result = 11;
                }
                if (target == "アジムステップ" || target == "ヤンサ(北西)" || target == "ヤンサ(南東)" || target == "紅玉海")
                {
                    result = 999;
                }
            }

            return result;
        }

        //telepoint move
        public static string[][] telepointmove(string[] init, string[][] tele, string[][] points)
        {
            double mindistance = 999999999;
            string[][] next = new string[3][];
            next[0] = new string[5] { "", "", "", "", "" };
            next[1] = new string[5] { "", "", "", "", "" };
            next[2] = new string[2] { "", "" };
            int m = -1;
            int n = -1;
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i][0] != "")
                {
                    if (points[i][4] == "0") {
                        for (int j = 1; j < tele.Length; j++)
                        {
                            if (points[i][1].Equals(tele[j][1]))
                            {
                                double tempdistance = codistance(points[i], tele[j]) + teleweight(init[1],tele[j][1]);
                                if (tempdistance < mindistance)
                                {
                                    mindistance = tempdistance;
                                    m = j;
                                    n = i;
                                }
                            }
                        }
                    }
                }
            }
            if (m != -1)
            {
                next[0] = tele[m];
                next[1] = points[n];
                next[2][0] = Convert.ToString(Math.Round(mindistance, 0));
                next[2][1] = Convert.ToString(n);
            }
            return next;
        }

        //find the next closest point in another map
        public static string[][] crossmapdrouting(string[] init, string[][] points, string[][] tele, string[][] boarder)
        {
            string[][] next = new string[3][];
            next[0] = new string[5] { "", "", "", "", "" };
            next[1] = new string[5] { "", "", "", "", "" };
            next[2] = new string[2] { "", "" };
            double mindistance = 999999999;
            string[][] nextboarder = boardermove(init, boarder, points);
            string[][] nexttelepoint = telepointmove(init, tele, points);
            double teled = stringparsetointdouble(nexttelepoint[2][0]);
            double moved = stringparsetointdouble(nextboarder[2][0]);
            if (nextboarder[0][0] != "")
            {
                if (moved < mindistance)
                {
                    mindistance = moved;
                    next = nextboarder;
                    if (nexttelepoint[0][0] != "")
                    {
                        if (teled < mindistance)
                        {
                            mindistance = teled;
                            next = nexttelepoint;
                        }
                    }
                }
            }
            else
            {
                mindistance = teled;
                next = nexttelepoint;
            }
            points[(int)Char.GetNumericValue(next[2][1][0])][4] = "1";
            return next;
        }

        //check if all player points has been reached
        public static Boolean notdone(string[][] players)
        {
            Boolean tf;
            tf = false;
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i][0] != "")
                {
                    {
                        if (players[i][4].Equals("0"))
                        {
                            tf = true;
                        }
                    }
                }
            }
            return tf;
        }


        //reset players flags
        public static string[][] resetplayers(string[][] players)
        {
            for (int i = 0; i < players.Length; i++)
                if (players[i][0] != "")
                {
                    {
                        players[i][4] = "0";
                    }
                }
            return players;
        }

        //filt out the shortest path
        public static string[][] shortestpath(string[][][] all)
        {
            int n = 0;
            double l;
            double mindis = 999999999;
            for (int i = 0; i < all.Length; i++)
            {
                l = 0;
                if (all[i][0][0] != "")
                {
                    for (int j = 1; j < all[i].Length; j++)
                    {
                        if (all[i][j][0] != "")
                        {
                            if (all[i][j][4].Equals("map"))
                            {
                                l = l + codistance(all[i][j], all[i][j - 1]) + codistance(boardercheck(all[i][j], boarders), all[i][j + 1]);
                                j++;
                            }
                            else
                            {
                                if (all[i][j][4].Equals("0") || all[i][j][4].Equals("1"))
                                {
                                    l = l + codistance(all[i][j], all[i][j - 1]);
                                }
                                if (all[i][j][4].Equals("tele"))
                                {
                                    l = l + 7;
                                }
                            }
                        }
                    }
                    if (l < mindis)
                    {
                        mindis = l;
                        n = i;
                    }
                }
            }
            string[][] result = all[n];
            return result;
        }

        //check if the player has been arranged
        public static Boolean checkdone(string temp, string[][] allarrangement)
        {
            for (int i = 0; i < allarrangement.Length; i++)
            {
                if (temp == allarrangement[i][0])
                {
                    return false;
                }
            }
            return true;
        }


        //get the final list for shortest move
        public static string[][] arrange(string[][] players)
        {
            setData();
            string[][] finishedarrangement = new string[16][];
            string[][][] allarrangements = new string[8][][];

            for (int a = 0; a < 8; a++)
            {
                allarrangements[a] = new string[16][];
                for (int b = 0; b < 16; b++)
                {
                    allarrangements[a][b] = new string[5];
                }
            }

            for (int c = 0; c < 16; c++)
            {
                finishedarrangement[c] = new string[5];
            }

            fill2(finishedarrangement);
            fill3(allarrangements);

            for (int i = 0; i < 8; i++)
            {
                if (players[i][0] != "")
                {
                    allarrangements[i][1] = players[i];
                    players[i][4] = "1";
                    string[][] temp = new string[8][];
                    for (int a = 0; a < 8; a++)
                    {
                        temp[a] = new string[5];
                    }
                    fill2(temp);
                    int k = 2;
                    double mindd = 999999999;
                    int z;
                    string[] firsttele = new string[5];
                    for (int y = 0; y < telepoints.Length; y++)
                    {
                        if (allarrangements[i][1][1] == telepoints[y][1])
                        {
                            if (codistance(allarrangements[i][1], telepoints[y]) < mindd)
                            {
                                firsttele = telepoints[y];
                                mindd = codistance(allarrangements[i][1], telepoints[y]);
                            }
                        }
                    }
                    allarrangements[i][0] = firsttele;
                    while (notdone(players))
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (players[j][0] != "")
                            {
                                if (players[j][1].Equals(allarrangements[i][k - 1][1]) && players[j][4].Equals("0"))
                                {
                                    temp[j] = players[j];
                                    players[j][4] = "1";
                                }
                            }
                        }
                        for (int h = 0; h < temp.Length; h++)
                        {
                            if (temp[h][0] != "")
                            {
                                temp[h][4] = "0";
                            }
                        }
                        while (notdone(temp))
                        {
                            string[][] samemaptele = telepointmove(allarrangements[i][k - 1], telepoints, temp);
                            string[] nextmove = drouting(allarrangements[i][k - 1], temp);
                            for (int g = 0; g < temp.Length; g++)
                            {
                                if (temp[g][0] != "")
                                {
                                    if (checkdone(temp[g][0], allarrangements[i]))
                                    {
                                        temp[g][4] = "0";
                                    }
                                }
                            }
                            if (codistance(nextmove, allarrangements[i][k - 1]) <= Convert.ToDouble(samemaptele[2][0]))
                            {
                                allarrangements[i][k] = drouting(allarrangements[i][k - 1], temp);
                                k++;
                            }
                            else
                            {
                                allarrangements[i][k] = samemaptele[0];
                                allarrangements[i][k + 1] = samemaptele[1];
                                k++;
                                k++;
                                temp[(int)Char.GetNumericValue(samemaptele[2][1][0])][4] = "1";
                            }
                        }
                        temp = resettemp();
                        if (notdone(players))
                        {
                            string[][] nextcrossmap = crossmapdrouting(allarrangements[i][k - 1], players, telepoints, boarders);
                            allarrangements[i][k] = nextcrossmap[0];
                            allarrangements[i][k + 1] = nextcrossmap[1];
                            k = k + 2;
                        }
                    }
                }
                players = resetplayers(players);
            }
            finishedarrangement = shortestpath(allarrangements);
            return finishedarrangement;
        }
    }
}




