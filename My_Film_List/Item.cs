using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Film_List
{
    internal class Item
    {
        string Name;
        int CountOfEpisodesMax;
        int CountOfEpisodesNow;
        int Duration;
        DateTime ReleaseDate;
        float Rating;
        string Link;

        public Item()
        {
            SetName("");
            SetCountOfEpisodesMax(0);
            SetCountOfEpisodesNow(0);
            SetDuration(0);
            SetReleaseDate(DateTime.Now);
            SetRating(0);
            SetLink("");
        }
        public Item(string n,int cm, int cn, int d, DateTime date, float r, string l)
        {
            SetName(n);
            SetCountOfEpisodesMax(cm);
            SetCountOfEpisodesNow(cn);
            SetDuration(d);
            SetReleaseDate(date);
            SetRating(r);
            SetLink(l);
        }
        public void SetName(string value)
        {
            Name = value;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetCountOfEpisodesMax(int value)
        {
            CountOfEpisodesMax=value;
        }
        public int GetCountOfEpisodesMax()
        {
            return CountOfEpisodesMax;
        }
        public void SetCountOfEpisodesNow(int value)
        {
            CountOfEpisodesNow = value;
        }
        public int GetCountOfEpisodesNow()
        {
            return CountOfEpisodesNow;
        }
        public void SetDuration(int value)
        {
            Duration = value;
        }
        public int GetDuration()
        {
            return Duration;
        }
        public void SetReleaseDate(DateTime value)
        {
            ReleaseDate = value;
        }
        public DateTime GetReleaseDate()
        {
            return ReleaseDate;
        }
        public void SetRating(float value)
        {
            Rating = value;
        }
        public float GetRating()
        {
            return Rating;
        }
        public void SetLink(string value)
        {
            Link = value;
        }
        public string GetLink()
        {
            return Link;
        }
    }
}
