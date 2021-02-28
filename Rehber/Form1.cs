using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rehber
{
    public partial class Form1 : Form
    {
        RehberEntities db = new RehberEntities();
        TBLREHBER rehberim = new TBLREHBER();

        int rehber1 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        string emailim;
        private void button1_Click(object sender, EventArgs e)
        { 
            emailim = TextMail.Text.ToString() + ComboGmail.Text.ToString();
            rehberim.Ad_Soyad = TextName.Text.ToString().ToUpper();
            rehberim.Tel = TextTel.Text.ToString();
            rehberim.Email = emailim;
            rehberim.Cinsiyet= ComboCinsiyet.Text.ToString();

            db.TBLREHBERs.Add(rehberim);
            db.SaveChanges();
            tolist();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void tolist()
        {

            GridRehber.DataSource = db.TBLREHBERs.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tolist();
        }

        private void ButtonSil_Click(object sender, EventArgs e)
        {
            if (rehber1 !=0)
            {
                
                db.TBLREHBERs.Remove(db.TBLREHBERs.Find(rehber1));
                db.SaveChanges();
                rehber1 = 0;
                tolist();
            }
          
        }

        private void GridRehber_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>-1)
            {
                rehber1 = int.Parse(GridRehber.Rows[e.RowIndex].Cells[0].Value.ToString());
                TextName.Text = GridRehber.Rows[e.RowIndex].Cells[1].Value.ToString();
           TextTel.Text= GridRehber.Rows[e.RowIndex].Cells[2].Value.ToString();
                TextMail.Text = GridRehber.Rows[e.RowIndex].Cells[3].Value.ToString();
               ComboCinsiyet.Text = GridRehber.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
            else
            {
                MessageBox.Show("hatalı tıklama");
            }
           
           
        }

        private void ButtonGüncelle_Click(object sender, EventArgs e)
        {
            if (rehber1 != 0)
            {
                var duzenleme = db.TBLREHBERs.Find(rehber1);
                duzenleme.Ad_Soyad = TextName.Text.ToUpper();
                duzenleme.Tel = TextTel.Text;
                duzenleme.Email = TextMail.Text + ComboGmail.Text.ToString();
                duzenleme.Cinsiyet = ComboCinsiyet.Text.ToString();
                tolist();
            }
            else
            {
                MessageBox.Show("silemezsiniz");
            }
           

        }
    }
}
