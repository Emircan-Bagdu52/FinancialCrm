using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinancialCrm
{
	public partial class LoginFrm : Form
	{
		public LoginFrm()
		{
			InitializeComponent();
		}

		FinancialCrmDbEntities db = new FinancialCrmDbEntities();

		private void button1_Click(object sender, EventArgs e)
		{
			// Kullanıcı adı ve şifreyi textboxtan alıyoruz
			string username = textBox1.Text.Trim();
			string password = textBox2.Text.Trim();

			// Kullanıcı adı ve şifre boş bırakılmışsa uyarı ver
			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Lütfen kullanıcı adı ve şifreyi doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Veritabanında kullanıcı adı ve şifreyi kontrol et
			var user = db.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);

			if (user != null)
			{
				// Giriş başarılı
				MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

				// FrmBilling formuna yönlendirme
				FrmBilling frmBilling = new FrmBilling();
				frmBilling.Show();
				this.Hide();
			}
			else
			{
				// Giriş başarısız
				MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
