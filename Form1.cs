using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_transaktion_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            DatabaseAccessor.canOpen();
            InitializeComponent();
        }

        private void UncommitedButton_Click(object sender, EventArgs e)
        {
            DatabaseAccessor.BeginUncommited();
        }

        private void SerializableButton_Click(object sender, EventArgs e)
        {
            DatabaseAccessor.BeginSerializable();
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            DatabaseAccessor.Update("FlightSeats", Convert.ToInt32(ReserveTextbox.Text), Convert.ToInt32(FlyNummerComboBox.Text));
            CommitButton.Enabled = true;
            RollbackButton.Enabled = true;
        }

        private void FlyNummerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int flight = Convert.ToInt32(FlyNummerComboBox.Text);

            int seat = DatabaseAccessor.Read("FlightSeats", flight);

            FreeSeatsTextbox.Text = seat.ToString();
        }

        private void CommitButton_Click(object sender, EventArgs e)
        {
            DatabaseAccessor.Commit();

            CommitButton.Enabled = false;
            RollbackButton.Enabled = false;
        }

        private void RollbackButton_Click(object sender, EventArgs e)
        {
            DatabaseAccessor.Rollback();

            RollbackButton.Enabled = false;
            CommitButton.Enabled = false;
        }
    }
}
