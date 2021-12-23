using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MCD_RSSOkumaUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Haber> XMLCevir()
        {
            List<Haber> HaberKayitlari = new List<Haber>();
            XDocument XmlKaynak = XDocument.Load(txt_RSS_Url.Text);
            List<XElement> Rows=XmlKaynak.Descendants("item").ToList();
            foreach (XElement item in Rows)
            {
                Haber temp = new Haber();
                temp.Baslik = item.Element("title").Value;
                temp.Link = item.Element("link").Value;
                temp.Aciklama=item.Element("description").Value;
                HaberKayitlari.Add(temp);
            }
            return HaberKayitlari;
        }

        private void btn_Kaynagi_Getir_Click(object sender, EventArgs e)
        {
            List<Haber> Kayitlar = XMLCevir();
            lst_Baslik.DataSource=Kayitlar;
        }

        private void lst_Baslik_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox SecilenDeger = (ListBox)sender;
            Haber SecilenHaber = (Haber)lst_Baslik.SelectedItem;
            webBrowser1.DocumentText = SecilenHaber.Aciklama;
        }
    }
}
