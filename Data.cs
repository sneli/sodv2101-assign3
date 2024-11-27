using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eilidh_assign3
{
    internal class Data
    {
        public static List<Dancers> GetDancers()
        {
            List<Dancers> dancers = new List<Dancers>();

            Dancers dancer = new Dancers()
            {
                FullName = "Gene Kelly",
                MainStyle = "Tap",
                DOB = "August 23rd, 1912",
                DOD = "February 2nd, 1996",
                YearsActive = "1931-1994",
                PhotoPath = Properties.Resources.gene_kelly
            };
            dancers.Add(dancer);
            dancer = new Dancers()
            {
                FullName = "José Limón",
                MainStyle = "Modern",
                DOB = "January 12th, 1908",
                DOD = "December 2nd, 1972",
                YearsActive = "1929-1969",
                PhotoPath = Properties.Resources.jose_limon
            };
            dancers.Add(dancer);
            dancer = new Dancers()
            {
                FullName = "Mikhail Baryshnikov",
                MainStyle = "Ballet",
                DOB = "January 27th, 1948",
                DOD = "N/A",
                YearsActive = "1968-Present",
                PhotoPath = Properties.Resources.mikhail_baryshnikov
            };
            dancers.Add(dancer);
            dancer = new Dancers()
            {
                FullName = "Fred Astaire",
                MainStyle = "Tap",
                DOB = "May 10th, 1899",
                DOD = "Juse 22nd, 1987",
                YearsActive = "1904-1981",
                PhotoPath = Properties.Resources.fred_astaire
            };
            dancers.Add(dancer);
            dancer = new Dancers()
            {
                FullName = "Anna Pavlova",
                MainStyle = "Ballet",
                DOB = "February 12th, 1881",
                DOD = "January 23rd, 1931",
                YearsActive = "1899-1931",
                PhotoPath = Properties.Resources.anna_pavlova
            };
            dancers.Add(dancer);
            dancer = new Dancers()
            {
                FullName = "Martha Graham",
                MainStyle = "Modern",
                DOB = "May 11th, 1894",
                DOD = "April 1st, 1991",
                YearsActive = "1923-1970"
                ,
                PhotoPath = Properties.Resources.martha_graham
            };
            dancers.Add(dancer);
            dancer = new Dancers()
            {
                FullName = "Margot Fonteyn",
                MainStyle = "Ballet",
                DOB = "May 18th, 1919",
                DOD = "February 21st, 1991",
                YearsActive = "1931-1979",
                PhotoPath = Properties.Resources.margot_fonteyn
            };
            dancers.Add(dancer);
            dancer = new Dancers()
            {
                FullName = "Ginger Rogers",
                MainStyle = "Tap",
                DOB = "July 16th, 1911",
                DOD = "April 5th, 1995",
                YearsActive = "1925-1987",
                PhotoPath = Properties.Resources.ginger_rogers
            };
            dancers.Add(dancer);
            dancer = new Dancers()
            {
                FullName = "Steven \"tWitch\" Boss",
                MainStyle = "Hip-Hop",
                DOB = "Sept 28th, 1982",
                DOD = "December 13th, 2022",
                YearsActive = "2003-2022",
                PhotoPath = Properties.Resources.twitch
            };
            dancers.Add(dancer);
            dancer = new Dancers()
            {
                FullName = "Katherine Dunham",
                MainStyle = "Modern",
                DOB = "June 22nd, 1909",
                DOD = "May 21st, 2006",
                YearsActive = "1928-1978",
                PhotoPath = Properties.Resources.katherine_dunham
            };
            dancers.Add(dancer);
            dancer = new Dancers()
            {
                FullName = "Bob Fosse",
                MainStyle = "Jazz",
                DOB = "July 23rd, 1927",
                DOD = "September 23rd, 1987",
                YearsActive = "1947-1987",
                PhotoPath = Properties.Resources.bob_fosse
            };
            dancers.Add(dancer);
            dancer = new Dancers()
            {
                FullName = "Marie Taglioni",
                MainStyle = "Ballet",
                DOB = "April 23rd, 1804",
                DOD = "April 22nd, 1884",
                YearsActive = "1824-1847",
                PhotoPath = Properties.Resources.marie_taglioni
            };
            dancers.Add(dancer);
            dancer = new Dancers()
            {
                FullName = "Jason Samuels Smith",
                MainStyle = "Tap",
                DOB = "October 4th, 1980",
                DOD = "N/A",
                YearsActive = "2003-Present",
                PhotoPath = Properties.Resources.jason_samuels_smith
            };
            dancers.Add(dancer);
            dancer = new Dancers()
            {
                FullName = "Philip \"Wizard\" Kim",
                MainStyle = "Breakdancing",
                DOB = "January 25th, 1997",
                DOD = "N/A",
                YearsActive = "2009-Present",
                PhotoPath = Properties.Resources.phil_wizard
            };
            dancers.Add(dancer);
            dancer = new Dancers()
            {
                FullName = "Travis Wall",
                MainStyle = "Modern",
                DOB = "September 16th, 1987",
                DOD = "N/A",
                YearsActive = "1999-Present",
                PhotoPath = Properties.Resources.travis_wall
            };
            dancers.Add(dancer);
            dancer = new Dancers()
            {
                FullName = "Florence Mills",
                MainStyle = "Jazz",
                DOB = "January 25th, 1896",
                DOD = "November 1st, 1927",
                YearsActive = "1901-1927",
                PhotoPath = Properties.Resources.florence_mills
            };
            dancers.Add(dancer);
            dancer = new Dancers()
            {
                FullName = "Leon James",
                MainStyle = "Swing",
                DOB = "April 27th, 1913",
                DOD = "July 30th, 1970",
                YearsActive = "~1943-1961",
                PhotoPath = Properties.Resources.leon_james
            };
            dancers.Add(dancer);
            dancer = new Dancers()
            {
                FullName = "Anna Sokolow",
                MainStyle = "Modern",
                DOB = "February 9th, 1910",
                DOD = "March 29th, 2000",
                YearsActive = "1930-1997",
                PhotoPath = Properties.Resources.anna_sokolow
            };
            dancers.Add(dancer);

            return dancers;
        }
    }
}
