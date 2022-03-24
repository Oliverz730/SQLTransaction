﻿using System;
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
        }

        private void FlyNummerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] seats = DatabaseAccessor.Read("FlightSeats");

            int flight = Convert.ToInt32(FlyNummerComboBox.Text);

            int seat = seats[flight - 1];

            FreeSeatsTextbox.Text = seat.ToString();
        }
    }
}
