using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteBlobStorage
{
    public partial class FormPrincipal : Form
    {
        private const string CONTAINER = "testecontainer";

        public FormPrincipal()
        {
            InitializeComponent();

            BlobStorageHelper.CheckContainer(CONTAINER);
            AtualizarListagemBlobs();
        }

        private bool NomeBlobValido()
        {
            bool valido = !String.IsNullOrWhiteSpace(txtNomeBlob.Text);
            if (!valido)
                MessageBox.Show("Preencha o nome do blob!");

            return valido;
        }

        private void AtualizarListagemBlobs()
        {
            lstCarregados.Items.Clear();
            lstCarregados.Items.AddRange(
                BlobStorageHelper.ListBlockBlobs(CONTAINER)
                    .ToArray());
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (!NomeBlobValido())
                return;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BlobStorageHelper.UploadBlockBlob(
                    CONTAINER, txtNomeBlob.Text, openFileDialog1.FileName);
                AtualizarListagemBlobs();
                MessageBox.Show("Blob criado com sucesso!");
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (!NomeBlobValido())
                return;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BlobStorageHelper.DownloadBlockBlob(
                    CONTAINER, txtNomeBlob.Text, saveFileDialog1.FileName);
                AtualizarListagemBlobs();
                MessageBox.Show("Blob baixado com sucesso!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!NomeBlobValido())
                return;

            BlobStorageHelper.DeleteBlockBlob(CONTAINER, txtNomeBlob.Text);
            AtualizarListagemBlobs();
            MessageBox.Show("Blob removido com sucesso!");
        }
    }
}