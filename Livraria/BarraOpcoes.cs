using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class BarraOpcoes : UserControl
    {
        public BarraOpcoes()
        {
            InitializeComponent();
        }

        public void DesabilitaNovo()
        {
            btnNovo.Enabled = false;
        }

        public void HabilitaNovo()
        {
            btnNovo.Enabled = true;
        }

        public void DesabilitaCopiar()
        {
            btnCopiar.Enabled = false;
        }

        public void HabilitaCopiar()
        {
            btnCopiar.Enabled = true;
        }

        public void DesabilitaColar()
        {
            btnColar.Enabled = false;
        }

        public void HabilitaColar()
        {
            btnColar.Enabled = true;
        }

        public void DesabilitaSalvar()
        {
            btnSalvar.Enabled = false;
        }

        public void HabilitaSalvar()
        {
            btnSalvar.Enabled = true;
        }

        public void DesabilitaExcluir()
        {
            btnExcluir.Enabled = false;
        }

        public void HabilitaExcluir()
        {
            btnExcluir.Enabled = true;
        }

        public void DesabilitaAlterar()
        {
            btnAlterar.Enabled = false;
        }

        public void HabilitaAlterar()
        {
            btnAlterar.Enabled = true;
        }

        public void DesabilitaCancelar()
        {
            btnCancelar.Enabled = false;
        }

        public void HabilitaCancelar()
        {
            btnCancelar.Enabled = true;
        }
    }
}