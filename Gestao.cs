﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelasDesktopPIM
{
    public partial class Gestao : Form
    {
        public Gestao()
        {
            InitializeComponent();
        }

        private void Gestao_Load(object sender, EventArgs e)
        {
     
        }



        private void buttonGestão_Click(object sender, EventArgs e)
        {
            
        }


        private void buttonVendas_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            vendas.ShowDialog();
        }


        private void buttonGerClient_Click(object sender, EventArgs e)
        {
            ListClientes clientes = new ListClientes();
            clientes.ShowDialog();
        }

        private void buttonGerProdut_Click(object sender, EventArgs e)
        {
            GesProdutos produtos = new GesProdutos();
            produtos.ShowDialog();
        }

        private void buttonGerProducao_Click(object sender, EventArgs e)
        {
            GesProducoes producoes = new GesProducoes();
            producoes.ShowDialog();
        }
    }
}
