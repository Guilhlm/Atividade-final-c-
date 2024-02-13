﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using System.IO;
using System.Runtime.InteropServices;

namespace qrcode
{
    public partial class Form1 : Form
    {
        QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
        private object picQRcode;

        public Form1()
        {
            InitializeComponent();
        }

        private void BTNGERAR_Click(object sender, EventArgs e)
        {
            string dados = TXT1.Text .Trim();

            if(string .IsNullOrEmpty(dados) )
            {
                MessageBox.Show ("seguinte meu paceiro deu erro, insere algo ae nmrl", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error ); 
                return;
            }

            QRCodeGenerator qrGerador = new QRCodeGenerator();
            QRCodeData qrcodedados = qrGerador.CreateQrCode(dados, QRCodeGenerator.ECCLevel.L);
            QRCode qrCode = new QRCode(qrcodedados);
            Bitmap qrCodeImagem = qrCode.GetGraphic(10);

            PIC_CODE.Image = qrCodeImagem;
            PIC_CODE.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void BTNRESETAR_Click(object sender, EventArgs e)
        {
            TXT1.Text = "";
            PIC_CODE.Image = null;
        }

        private void BTNSAIR_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("OLOKO quer sair paulin?", "sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void TXT1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
