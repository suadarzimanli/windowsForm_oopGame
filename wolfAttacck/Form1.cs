using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wolfAttacck.Models;

namespace wolfAttacck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Account account = new Account();
        Damage damage = new Damage();

        private void btnClick_Click(object sender, EventArgs e)
        {
            account.userName = txtName.Text;
            account.race = cmbRace.SelectedItem.ToString();
            account.branch = cmbBranch.SelectedItem.ToString();
            account.weapon = txtWeapon.Text;
            ChangeState(false);
            ChangeVisible(true);
        }

        public void ChangeState(bool state)
        {
            txtName.Enabled = state;
            txtWeapon.Enabled = state;
            cmbBranch.Enabled = state;
            cmbRace.Enabled = state;
            btnClick.Enabled = state;

        }

        public void ChangeVisible(bool isVisible)
        {
            lblHealth.Visible = pgbWolfman.Visible = btnAttack.Visible = isVisible;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            account.Attack();
            damage.Attack2();
            lblHealth.Width -= account.damage;
            MessageBox.Show($"You have done {account.damage} damage to the enemy.");
            lblOurHealth.Width -= damage.damage2;
            MessageBox.Show($"Enemy have done {damage.damage2} damage to the you.");

            if (lblHealth.Width <= 0)
            {
                MessageBox.Show("You won the enemy.");
                pgbWolfman.Visible = false;
            }
            if (lblOurHealth.Width <= 0)
            {
                MessageBox.Show("You lost.");
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
