using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {        
        
        int RandomNumber;
        Random oner = new Random();
        String[] Gift = new string[] { "筆記型電腦", "隨身碟", "智慧型手機", "馬克杯", "平板電腦", "面紙" };
        String[] GiftName = new string[] { "NoteBook", "FlashDrive", "Iphone", "Cup", "Tabket", "Paper" };

        protected void Page_Load(object sender, EventArgs e)
        
        {

            DateTime ChrisDate = new DateTime(2024, 12, 25);
            TimeSpan Diff = ChrisDate - DateTime.Now;
            Date.Text = "距離聖誕節還剩:" + Diff.Days + "天";

            Welcome.Text = "以下是我們準備的禮物:";

            for (int i = 0; i < Gift.Length; i++)
            {
                if (i != Gift.Length - 1)
                    Welcome.Text += Gift[i] + "、";
                else
                    Welcome.Text += Gift[i] + "。";
            }

        }

        protected void EndShow_Click(object sender, EventArgs e)
        {

            RandomNumber = oner.Next(0, 6);
            GiftShow.Text = "你抽到的是:" + Gift[RandomNumber] + "<br>";
            Image1.ImageUrl = "jpg/" + GiftName[RandomNumber] + ".jpg";

        }
    }
}